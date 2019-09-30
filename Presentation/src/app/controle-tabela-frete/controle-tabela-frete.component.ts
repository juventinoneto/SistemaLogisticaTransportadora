import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Message } from 'primeng/components/common/api';
import { ColetaGrid } from '../models/coleta-grid.model';
import { RegistrarTarifa } from './models/registrar-tarifa.model';
import { RegistrarSimulacaoTarifa } from './models/registrar-simulacao-tarifa.model';
import { ControleTabelaFreteService } from './controle-tabela-frete.service';

@Component({
  selector: 'app-controle-tabela-frete',
  templateUrl: './controle-tabela-frete.component.html',
  styleUrls: ['./controle-tabela-frete.component.css']
})
export class ControleTabelaFreteComponent implements OnInit {

  coleta: ColetaGrid = new ColetaGrid();

  formGroup: FormGroup = this.buildForm();

  display: boolean = false;

  @Input() msgs: Message[] = [];
  @Output() newItemEvent = new EventEmitter<string>();



  constructor(
    private freteService: ControleTabelaFreteService
  ) { }

  ngOnInit() {
  }

  open(coleta: ColetaGrid) {
    this.display = true;
    this.coleta = coleta;
    this.verificaTarifaCadastrada();
    this.carregarValores();
  }

  buildForm(): FormGroup {
    return new FormGroup({
      nomeCliente: new FormControl(''),
      documentoCliente: new FormControl(''),
      ruaCliente: new FormControl(''),
      bairroCliente: new FormControl(''),
      cidadeCliente: new FormControl(''),
      numeroEnderecoCliente: new FormControl(''),
      cepCliente: new FormControl(''),
      complementoCliente: new FormControl(''),
      ufCliente: new FormControl(''),
      nomeDestinatario: new FormControl(''),
      ruaDestinatario: new FormControl(''),
      bairroDestinatario: new FormControl(''),
      numeroEnderecoDestinatario: new FormControl(),
      cepDestinatario: new FormControl(''),
      complementoDestinatario: new FormControl(''),
      ufDestinatario: new FormControl(''),
      cidadeDestinatario: new FormControl(''),
      valorFrete: new FormControl('')
    });
  }

  carregarValores() {
    this.formGroup = new FormGroup({
      nomeCliente: new FormControl(this.coleta.cliente.nome),
      documentoCliente: new FormControl(this.coleta.cliente.documento),
      ruaCliente: new FormControl(this.coleta.cliente.endereco.ruaAvenida),
      bairroCliente: new FormControl(this.coleta.cliente.endereco.bairro),
      cidadeCliente: new FormControl(this.coleta.cliente.endereco.cidade),
      numeroEnderecoCliente: new FormControl(this.coleta.cliente.endereco.numero),
      cepCliente: new FormControl(this.coleta.cliente.endereco.cep),
      complementoCliente: new FormControl(this.coleta.cliente.endereco.complemento),
      ufCliente: new FormControl(this.coleta.cliente.endereco.uf),
      nomeDestinatario: new FormControl(this.coleta.nomeDestinatario),
      ruaDestinatario: new FormControl(this.coleta.endereco.ruaAvenida),
      bairroDestinatario: new FormControl(this.coleta.endereco.bairro),
      numeroEnderecoDestinatario: new FormControl(this.coleta.endereco.numero),
      cepDestinatario: new FormControl(this.coleta.endereco.cep),
      complementoDestinatario: new FormControl(this.coleta.endereco.complemento),
      ufDestinatario: new FormControl(this.coleta.endereco.uf),
      cidadeDestinatario: new FormControl(this.coleta.endereco.cidade),
      valorFrete: new FormControl('')
    });
  }

  private verificaTarifaCadastrada() {
    if (this.coleta.tarifas.length > 0) {
      this.msgs.push({severity:'info', summary:'Info Message', detail:'Já existe uma tarifa cadastrada. Para alterá-la, edite os campos.'});
    }
  }

  private salvarFrete() {
    let simulacao = new RegistrarSimulacaoTarifa();
    simulacao.data = new Date();
    simulacao.idTarifa = this.coleta.tarifas.length > 0 && this.coleta.tarifas[0].idTarifa > 0 ? this.coleta.tarifas[0].idTarifa : null;
    // simulacao.status = 'C';
    simulacao.valor = +this.formGroup.get('valorFrete').value;

    let tarifa = new RegistrarTarifa();
    tarifa.idColeta = this.coleta.idColeta;
    tarifa.idTarifa = this.coleta.tarifas.length > 0 && this.coleta.tarifas[0].idTarifa > 0 ? this.coleta.tarifas[0].idTarifa : null;
    tarifa.simulacoes = [ simulacao ];

    if (this.formGroup.get('valorFrete').value) {
      if (tarifa.idTarifa > 0) {
        this.freteService.put(tarifa).subscribe(resp => {
          if (resp.sucesso) {
            this.msgs.push({ severity: 'success', summary: 'Success Message', detail: 'Tarifa Editada com Sucesso' });
            this.newItemEvent.emit();
            this.display = false;
          } else {
            this.msgs.push({ severity: 'error', summary: 'Error Message', detail: 'Erro Inesperado' });
            this.newItemEvent.emit();
            this.display = false;
          }
        });  
      } else {
        this.freteService.post(tarifa).subscribe(resp => {
          if (resp.sucesso) {
            this.msgs.push({ severity: 'success', summary: 'Success Message', detail: 'Tarifa Cadastrada com Sucesso' });
            this.newItemEvent.emit();
            this.display = false;
          } else {
            this.msgs.push({ severity: 'error', summary: 'Error Message', detail: 'Erro Inesperado' });
            this.newItemEvent.emit();
            this.display = false;
          }
        });  
      }
    }
  }

}

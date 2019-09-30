import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ColetaGrid } from '../models/coleta-grid.model';
import { RegistrarExpedicao } from './models/registrar-expedicao.model';
import { ControleExpedicaoService } from 'src/controle-expedicao.service';
import { Message } from 'primeng/api';

@Component({
  selector: 'app-controle-expedicao',
  templateUrl: './controle-expedicao.component.html',
  styleUrls: ['./controle-expedicao.component.css']
})
export class ControleExpedicaoComponent implements OnInit {

  formGroup: FormGroup = this.buildForm();

  coleta: ColetaGrid = new ColetaGrid();

  display: boolean = false;

  events: any[];

  @Input() msgs: Message[] = [];
  @Output() newItemEvent = new EventEmitter<string>();

  constructor(
    private expedicaoService: ControleExpedicaoService
  ) { }

  ngOnInit() {
    this.buildForm();
  }

  open(coleta: ColetaGrid) {
    this.display = true;
    this.coleta = coleta;
    this.carregarValores();
  }

  buildForm(): FormGroup {
    return new FormGroup({
      nomeCliente: new FormControl(''),
      tipoDocumentoCliente: new FormControl(''),
      documentoCliente: new FormControl(''),
      ruaCliente: new FormControl(''),
      bairroCliente: new FormControl(''),
      cidadeCliente: new FormControl(''),
      numeroEnderecoCliente: new FormControl(''),
      cepCliente: new FormControl(''),
      complementoCliente: new FormControl(''),
      ufCliente: new FormControl(''),
      data: new FormControl('')
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
      data: new FormControl('')
    });
  }

  salvar() {
    let expedicao = new RegistrarExpedicao();
    expedicao.coleta = this.coleta;
    expedicao.data = this.formGroup.get('data').value;

    if (expedicao.data) {
      this.expedicaoService.post(expedicao).subscribe(resp => {
        if (resp.sucesso) {
          this.msgs.push({ severity: 'success', summary: 'Success Message', detail: 'Coleta Cadastrada com Sucesso' });
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

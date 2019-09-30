import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ControleColetaDefinicaoCargaService } from './controle-coleta-definicao-carga.service';
import { SolicitarColeta } from './models/solicitar-coleta.model';
import { SolicitarColetaCliente } from './models/solicitar-coleta-cliente.model';
import { Endereco } from '../models/endereco.model';
import { Message } from 'primeng/components/common/api';
import { SelectItem } from 'primeng/api';
import { Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-controle-coleta-definicao-carga',
  templateUrl: './controle-coleta-definicao-carga.component.html',
  styleUrls: ['./controle-coleta-definicao-carga.component.css']
})
export class ControleColetaDefinicaoCargaComponent implements OnInit {

  @Input() msgs: Message[] = [];
  @Output() newItemEvent = new EventEmitter<string>();

  formGroup: FormGroup;

  display: boolean = false;

  ufs: SelectItem[] = [];

  constructor(private controleColetaDefinicaoCargaService: ControleColetaDefinicaoCargaService) { }

  ngOnInit() {
    this.inicializarUfs();
    this.buildForm();
  }

  private inicializarUfs() {
    this.ufs = [
      { label: 'AC', value: 'AC' },
      { label: 'AL', value: 'AL' },
      { label: 'AP', value: 'AP' },
      { label: 'AM', value: 'AM' },
      { label: 'BA', value: 'BA' },
      { label: 'CE', value: 'CE' },
      { label: 'DF', value: 'DF' },
      { label: 'ES', value: 'ES' },
      { label: 'GO', value: 'GO' },
      { label: 'MA', value: 'MA' },
      { label: 'MT', value: 'MT' },
      { label: 'MS', value: 'MS' },
      { label: 'MG', value: 'MG' },
      { label: 'PA', value: 'PA' },
      { label: 'PB', value: 'PB' },
      { label: 'PR', value: 'PR' },
      { label: 'PE', value: 'PE' },
      { label: 'PI', value: 'PI' },
      { label: 'RJ', value: 'RJ' },
      { label: 'RN', value: 'RN' },
      { label: 'RS', value: 'RS' },
      { label: 'RO', value: 'RO' },
      { label: 'RR', value: 'RR' },
      { label: 'SC', value: 'SC' },
      { label: 'SP', value: 'SP' },
      { label: 'SE', value: 'SE' },
      { label: 'TO', value: 'TO' }
    ]
  }

  open() {
    this.display = true;
  }

  buildForm() {
    this.formGroup = new FormGroup({
      nomeCliente: new FormControl('', Validators.required),
      tipoDocumentoCliente: new FormControl(''),
      documentoCliente: new FormControl('', Validators.required),
      ruaCliente: new FormControl('', Validators.required),
      bairroCliente: new FormControl('', Validators.required),
      cidadeCliente: new FormControl('', Validators.required),
      numeroEnderecoCliente: new FormControl('', Validators.required),
      cepCliente: new FormControl('', Validators.required),
      complementoCliente: new FormControl(''),
      ufCliente: new FormControl('', Validators.required),
      nomeDestinatario: new FormControl('', Validators.required),
      ruaDestinatario: new FormControl('', Validators.required),
      bairroDestinatario: new FormControl('', Validators.required),
      numeroEnderecoDestinatario: new FormControl('', Validators.required),
      cepDestinatario: new FormControl('', Validators.required),
      complementoDestinatario: new FormControl(''),
      ufDestinatario: new FormControl('', Validators.required),
      cidadeDestinatario: new FormControl('', Validators.required),
      dataColeta: new FormControl('', Validators.required)
    });
  }

  salvar() {
    let cliente = new SolicitarColetaCliente();
    cliente.nome = this.formGroup.get('nomeCliente').value;
    cliente.documento = this.formGroup.get('documentoCliente').value;

    let enderecoCliente = new Endereco();
    enderecoCliente.ruaAvenida = this.formGroup.get('ruaCliente').value;
    enderecoCliente.bairro = this.formGroup.get('bairroCliente').value;
    enderecoCliente.cidade = this.formGroup.get('cidadeCliente').value;
    enderecoCliente.numero = this.formGroup.get('numeroEnderecoCliente').value;
    enderecoCliente.cep = this.formGroup.get('cepCliente').value;
    enderecoCliente.complemento = this.formGroup.get('complementoCliente').value;
    enderecoCliente.uf = this.formGroup.get('ufCliente').value;
    cliente.endereco = enderecoCliente;


    let enderecoDestinatario = new Endereco();
    enderecoDestinatario.ruaAvenida = this.formGroup.get('ruaDestinatario').value;
    enderecoDestinatario.bairro = this.formGroup.get('bairroDestinatario').value;
    enderecoDestinatario.cidade = this.formGroup.get('cidadeDestinatario').value;
    enderecoDestinatario.numero = this.formGroup.get('numeroEnderecoDestinatario').value;
    enderecoDestinatario.cep = this.formGroup.get('cepDestinatario').value;
    enderecoDestinatario.complemento = this.formGroup.get('complementoDestinatario').value;
    enderecoDestinatario.uf = this.formGroup.get('ufDestinatario').value;

    let coleta = new SolicitarColeta();
    coleta.cliente = cliente;
    coleta.nomeDestinatario = this.formGroup.get('nomeDestinatario').value;
    coleta.endereco = enderecoDestinatario;
    coleta.data = this.formGroup.get('dataColeta').value;

    if (this.formGroup.valid) {
      this.controleColetaDefinicaoCargaService.post(coleta).subscribe(resp => {
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

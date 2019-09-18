import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl }        from '@angular/forms';

@Component({
  selector: 'app-controle-coleta-definicao-carga',
  templateUrl: './controle-coleta-definicao-carga.component.html',
  styleUrls: ['./controle-coleta-definicao-carga.component.css']
})
export class ControleColetaDefinicaoCargaComponent implements OnInit {

  formGroup: FormGroup;

  display: boolean = false;

  constructor() { }

  ngOnInit() {
    this.buildForm();
  }

  open() {
    this.display = true;
  }

  buildForm() {
    this.formGroup = new FormGroup({
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
      nomeDestinatario: new FormControl(''),
      ruaDestinatario: new FormControl(''),
      bairroDestinatario: new FormControl(''),
      numeroEnderecoDestinatario: new FormControl(''),
      cepDestinatario: new FormControl(''),
      complementoDestinatario: new FormControl(''),
      ufDestinatario: new FormControl(''),
      cidadeDestinatario: new FormControl(''),
      dataColeta: new FormControl('')
    });
  }

}

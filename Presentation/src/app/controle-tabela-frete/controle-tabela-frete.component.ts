import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-controle-tabela-frete',
  templateUrl: './controle-tabela-frete.component.html',
  styleUrls: ['./controle-tabela-frete.component.css']
})
export class ControleTabelaFreteComponent implements OnInit {

  formGroup: FormGroup;

  display: boolean = false;

  constructor() { }

  ngOnInit() {
  }

  open() {
    this.display = true;
  }

  buildForm() {
    this.formGroup = new FormGroup({
      nomeCliente: new FormControl({disable: true}),
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
      valorFrete: new FormControl('')
    });
  }

}

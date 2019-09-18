import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

// import dayGridPlugin from '@fullcalendar/daygrid';
// import timeGridPlugin from '@fullcalendar/timegrid';
// import interactionPlugin from '@fullcalendar/interaction';

@Component({
  selector: 'app-controle-expedicao',
  templateUrl: './controle-expedicao.component.html',
  styleUrls: ['./controle-expedicao.component.css']
})
export class ControleExpedicaoComponent implements OnInit {

  formGroup: FormGroup;

  display: boolean = false;

  events: any[];

  constructor() { }

  ngOnInit() {
    this.buildForm();
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
      data: new FormControl('')
    });
  }

}

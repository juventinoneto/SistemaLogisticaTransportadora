import { Component, OnInit, ViewChild } from '@angular/core';
import { ColetaGrid } from '../models/coleta-grid.model';
import { ControleTabelaFreteComponent } from '../controle-tabela-frete/controle-tabela-frete.component';
import { ControleExpedicaoComponent } from '../controle-expedicao/controle-expedicao.component';

@Component({
  selector: 'app-painel-geral',
  templateUrl: './painel-geral.component.html',
  styleUrls: ['./painel-geral.component.css']
})
export class PainelGeralComponent implements OnInit {

  @ViewChild('controleTabelaFrete') controleTabelaFrete: ControleTabelaFreteComponent;
  @ViewChild('controleExpedicao') controleExpedicao: ControleExpedicaoComponent;


  coletas: ColetaGrid[] = [
    { idColeta: 1, dataColeta: new Date(), status: "-" },
    { idColeta: 2, dataColeta: new Date(), status: "-" },
    { idColeta: 3, dataColeta: new Date(), status: "-" },
  ];

  constructor() { }

  ngOnInit() {
  }

  definirCarga() {
    console.log('Definição de carga');
    this.controleExpedicao.open();
  }

  simularFrete() {
    console.log('Simular frete');
    //this.controleTabelaFrete.display = true;
    this.controleTabelaFrete.open();
  }

}

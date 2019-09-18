import { Component, OnInit, ViewChild } from '@angular/core';
import { ColetaGrid } from '../models/coleta-grid.model';
import { ControleTabelaFreteComponent } from '../controle-tabela-frete/controle-tabela-frete.component';
import { ControleExpedicaoComponent } from '../controle-expedicao/controle-expedicao.component';
import { ControleColetaDefinicaoCargaComponent } from '../controle-coleta-definicao-carga/controle-coleta-definicao-carga.component';

@Component({
  selector: 'app-painel-geral',
  templateUrl: './painel-geral.component.html',
  styleUrls: ['./painel-geral.component.css']
})
export class PainelGeralComponent implements OnInit {

  @ViewChild('controleTabelaFrete', { static: true }) controleTabelaFrete: ControleTabelaFreteComponent;
  @ViewChild('controleExpedicao', { static: true }) controleExpedicao: ControleExpedicaoComponent;
  @ViewChild('controleColetaDefinicaoDeCarga', { static: true }) controleColetaDefinicaoDeCarga: ControleColetaDefinicaoCargaComponent;

  


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

  cadastrarColeta() {
    console.log('Cadastrar Coleta');
    //this.controleTabelaFrete.display = true;
    this.controleColetaDefinicaoDeCarga.open();
  }

}

import { Component, OnInit, ViewChild } from '@angular/core';
import { ColetaGrid } from '../models/coleta-grid.model';
import { ControleTabelaFreteComponent } from '../controle-tabela-frete/controle-tabela-frete.component';
import { ControleExpedicaoComponent } from '../controle-expedicao/controle-expedicao.component';
import { ControleColetaDefinicaoCargaComponent } from '../controle-coleta-definicao-carga/controle-coleta-definicao-carga.component';
import { PainelGeralService } from './painel-geral.service';
import { Router } from '@angular/router'
import { Message } from 'primeng/components/common/api';

@Component({
  selector: 'app-painel-geral',
  templateUrl: './painel-geral.component.html',
  styleUrls: ['./painel-geral.component.css']
})
export class PainelGeralComponent implements OnInit {

  @ViewChild('controleTabelaFrete', { static: true }) controleTabelaFrete: ControleTabelaFreteComponent;
  @ViewChild('controleExpedicao', { static: true }) controleExpedicao: ControleExpedicaoComponent;
  @ViewChild('controleColetaDefinicaoDeCarga', { static: true }) controleColetaDefinicaoDeCarga: ControleColetaDefinicaoCargaComponent;

  coletas: ColetaGrid[] = [];
  msgs: Message[] = [];

  constructor(
    private painelGeralService: PainelGeralService,
    private router: Router
  ) { }

  ngOnInit() {
    this.getColetas();
  }

  private getColetas() {
    this.painelGeralService.get().subscribe(resp => this.coletas = resp);
  }

  definirCarga(coleta: ColetaGrid) {
    console.log('Definição de carga');
    this.controleExpedicao.open(coleta);
  }

  simularFrete(coleta: ColetaGrid) {
    console.log('Simular frete');
    this.controleTabelaFrete.open(coleta);
  }

  cadastrarColeta(coleta: ColetaGrid) {
    console.log('Cadastrar Coleta');
    //this.controleTabelaFrete.display = true;
    this.controleColetaDefinicaoDeCarga.open();
  }

  visualizarDespachos() {
    this.router.navigateByUrl('despachos');
  }

  definirStatus(coleta: ColetaGrid) {
    let status = "Realizada";

    if (coleta.tarifas.length > 0) {
      status = "Tarifa Registrada";
    }

    return status;
  }

  desabilitarAcaoDespacho(coleta: ColetaGrid): boolean {
    return coleta.tarifas.length > 0;
  }

  atualizarGrid() {
    this.getColetas();
  }

}

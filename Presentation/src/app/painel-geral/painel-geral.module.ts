import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PainelGeralComponent } from './painel-geral.component';
import { ControleColetaDefinicaoCargaModule } from '../controle-coleta-definicao-carga/controle-coleta-definicao-carga.module';
import { ControleExpedicaoModule } from '../controle-expedicao/controle-expedicao.module';
import { ControleTabelaFreteModule } from '../controle-tabela-frete/controle-tabela-frete.module';
import { SharedModule } from '../shared/shared.module';
import { AppModule } from '../app.module';

@NgModule({
  imports: [
    CommonModule,
    // ControleColetaDefinicaoCargaModule,
    ControleExpedicaoModule,
    ControleTabelaFreteModule,
    SharedModule,
  ],
  declarations: [
    PainelGeralComponent
  ]
})
export class PainelGeralModule { }

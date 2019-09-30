import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PainelGeralComponent } from './painel-geral.component';
import { ControleColetaDefinicaoCargaModule } from '../controle-coleta-definicao-carga/controle-coleta-definicao-carga.module';
import { ControleExpedicaoModule } from '../controle-expedicao/controle-expedicao.module';
import { ControleTabelaFreteModule } from '../controle-tabela-frete/controle-tabela-frete.module';
import { SharedModule } from '../shared/shared.module';
import { HttpClientModule }    from '@angular/common/http';
import { MessagesModule } from 'primeng/messages';
import { MessageModule } from 'primeng/message';
import { VisualizarDespachoModule } from '../visualizar-despacho/visualizar-despacho.module';



@NgModule({
  imports: [
    CommonModule,
    ControleColetaDefinicaoCargaModule,
    ControleExpedicaoModule,
    ControleTabelaFreteModule,
    VisualizarDespachoModule,
    SharedModule,
    HttpClientModule,
    MessageModule,
    MessagesModule
  ],
  declarations: [
    PainelGeralComponent
  ]
})
export class PainelGeralModule { }

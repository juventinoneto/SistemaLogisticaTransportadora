import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from './shared/shared.module';
import { AppRoutingModule } from './app-routing.module';
import { ControleTabelaFreteModule } from './controle-tabela-frete/controle-tabela-frete.module';
import { ControleColetaDefinicaoCargaModule } from './controle-coleta-definicao-carga/controle-coleta-definicao-carga.module';
import { ControleExpedicaoModule } from './controle-expedicao/controle-expedicao.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    SharedModule,
    AppRoutingModule,
    ControleTabelaFreteModule,
    ControleColetaDefinicaoCargaModule,
    ControleExpedicaoModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

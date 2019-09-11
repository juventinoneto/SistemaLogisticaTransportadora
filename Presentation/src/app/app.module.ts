import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from './shared/shared.module';
import { AppRoutingModule } from './app-routing.module';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { PainelGeralModule } from './painel-geral/painel-geral.module';
import { ControleTabelaFreteModule } from './controle-tabela-frete/controle-tabela-frete.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    SharedModule,
    AppRoutingModule,
    AngularFontAwesomeModule,
    PainelGeralModule,
    ControleTabelaFreteModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

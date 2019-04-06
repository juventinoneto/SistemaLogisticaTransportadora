import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ControleExpedicaoComponent } from './controle-expedicao/controle-expedicao.component';
import { ControleColetaDefinicaoCargaComponent } from './controle-coleta-definicao-carga/controle-coleta-definicao-carga.component';
import { ControleTabelaFreteComponent } from './controle-tabela-frete/controle-tabela-frete.component';

const routes: Routes = [
  { path: 'controle-tabela-frete', component: ControleTabelaFreteComponent },
  { path: 'controle-expedicao', component: ControleExpedicaoComponent },
  { path: 'controle-coleta', component: ControleColetaDefinicaoCargaComponent },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule 
  ]
})
export class AppRoutingModule { }

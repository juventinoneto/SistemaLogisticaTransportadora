import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PainelGeralComponent } from './painel-geral/painel-geral.component';
import { VisualizarDespachoComponent } from './visualizar-despacho/visualizar-despacho.component';

const routes: Routes = [
  { path: '', component: PainelGeralComponent },
  { path: 'main', component: PainelGeralComponent },
  { path: 'despachos', component: VisualizarDespachoComponent }
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

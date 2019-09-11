import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PainelGeralComponent } from './painel-geral/painel-geral.component';

const routes: Routes = [
  { path: '', component: PainelGeralComponent },
  { path: 'main', component: PainelGeralComponent }
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

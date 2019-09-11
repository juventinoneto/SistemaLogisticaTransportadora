import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ControleTabelaFreteComponent } from './controle-tabela-frete.component';
import { SharedModule } from 'primeng/components/common/shared';
import { DialogModule } from 'primeng/dialog';


@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    DialogModule
  ],
  declarations: [
    ControleTabelaFreteComponent
  ],
  exports: [
    ControleTabelaFreteComponent
  ]
})
export class ControleTabelaFreteModule { }

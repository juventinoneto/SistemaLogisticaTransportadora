import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ControleExpedicaoComponent } from './controle-expedicao.component';
import { SharedModule } from 'primeng/components/common/shared';
import { DialogModule } from 'primeng/dialog';
// import { FullCalendarModule } from 'primeng/fullcalendar';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    DialogModule,
    // FullCalendarModule
  ],
  declarations: [
    ControleExpedicaoComponent
  ],
  exports: [
    ControleExpedicaoComponent
  ]
})
export class ControleExpedicaoModule { }

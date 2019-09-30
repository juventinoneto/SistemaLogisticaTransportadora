import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FullCalendarModule } from 'primeng/fullcalendar';
import { SharedModule } from 'primeng/components/common/shared';
import { VisualizarDespachoComponent } from './visualizar-despacho.component';
import { DialogModule } from 'primeng/dialog';
import { TableModule } from 'primeng/table';

@NgModule({
  declarations: [
    VisualizarDespachoComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FullCalendarModule,
    DialogModule,
    TableModule
  ],
  exports: [
    VisualizarDespachoComponent
  ]
})
export class VisualizarDespachoModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ControleExpedicaoComponent } from './controle-expedicao.component';
import { SharedModule } from 'primeng/components/common/shared';
import { DialogModule } from 'primeng/dialog';
import { FullCalendarModule } from 'primeng/fullcalendar';
import { DropdownModule } from 'primeng/dropdown';
import { AccordionModule } from 'primeng/accordion';
import { CalendarModule } from 'primeng/calendar';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    DialogModule,
    FullCalendarModule,
    DropdownModule,
    AccordionModule,
    CalendarModule
  ],
  declarations: [
    ControleExpedicaoComponent
  ],
  exports: [
    ControleExpedicaoComponent
  ]
})
export class ControleExpedicaoModule { }

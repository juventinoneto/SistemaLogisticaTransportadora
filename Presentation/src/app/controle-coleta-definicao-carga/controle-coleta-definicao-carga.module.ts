import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ControleColetaDefinicaoCargaComponent } from './controle-coleta-definicao-carga.component';
import { SharedModule } from 'primeng/components/common/shared';
import { DialogModule } from 'primeng/dialog';
import { AccordionModule } from 'primeng/accordion';
import { RadioButtonModule } from 'primeng/radiobutton';
import { InputMaskModule } from 'primeng/inputmask';
import { CalendarModule } from 'primeng/calendar';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    DialogModule,
    AccordionModule,
    RadioButtonModule,
    InputMaskModule,
    CalendarModule,
    ReactiveFormsModule
  ],
  declarations: [
    ControleColetaDefinicaoCargaComponent
  ],
  exports: [
    ControleColetaDefinicaoCargaComponent,
    // NgModule,
    // CommonModule
  ]
})
export class ControleColetaDefinicaoCargaModule { }

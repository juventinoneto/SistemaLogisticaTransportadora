import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccordionModule } from 'primeng/accordion';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';

@NgModule({
  imports: [
    CommonModule,
    AccordionModule,
    TableModule,
    DialogModule
  ],
  declarations: [],
  exports: [
    AccordionModule,
    TableModule,
    DialogModule
  ]
})
export class SharedModule { }

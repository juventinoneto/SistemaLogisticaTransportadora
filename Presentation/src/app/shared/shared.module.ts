import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComponentsModule } from './components/components.module';
import { AccordionModule } from 'primeng/accordion';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';

@NgModule({
  imports: [
    CommonModule,
    ComponentsModule,
    AccordionModule,
    TableModule,
    DialogModule
  ],
  declarations: [],
  exports: [
    ComponentsModule,
    AccordionModule,
    TableModule,
    DialogModule
  ]
})
export class SharedModule { }

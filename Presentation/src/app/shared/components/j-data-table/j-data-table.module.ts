import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { JDataTableComponent } from './j-data-table.component';
import { MatTableModule } from '@angular/material/table'; 

@NgModule({
  imports: [
    CommonModule,
    MatTableModule
  ],
  declarations: [
    JDataTableComponent
  ],
  exports: [
    JDataTableComponent
  ]
})
export class JDataTableModule { }

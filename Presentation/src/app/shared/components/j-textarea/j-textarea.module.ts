import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { JTextareaComponent } from './j-textarea.component';
import { MatInputModule } from '@angular/material/input';

@NgModule({
  imports: [
    CommonModule,
    MatInputModule
  ],
  declarations: [
    JTextareaComponent
  ], 
  exports: [
    JTextareaComponent
  ]
})
export class JTextareaModule { }

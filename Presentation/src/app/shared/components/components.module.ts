import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { JInputModule } from './j-input/j-input.module';
import { JTextareaModule } from './j-textarea/j-textarea.module';

@NgModule({
  imports: [
    CommonModule,
    JInputModule,
    JTextareaModule
  ],
  declarations: [
  ],
  exports: [
    JInputModule,
    JTextareaModule
  ]
})
export class ComponentsModule { }

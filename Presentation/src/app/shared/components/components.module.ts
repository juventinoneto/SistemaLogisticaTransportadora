import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { JInputModule } from './j-input/j-input.module';
import { JTextareaModule } from './j-textarea/j-textarea.module';
import { JDataTableModule } from './j-data-table/j-data-table.module';
import { JDialogueComponent } from './j-dialogue/j-dialogue.component';
import { JDialogueModule } from './j-dialogue/j-dialogue.module';

@NgModule({
  imports: [
    CommonModule,
    JInputModule,
    JTextareaModule,
    JDataTableModule,
    JDialogueModule
  ],
  declarations: [JDialogueComponent],
  exports: [
    JInputModule,
    JTextareaModule,
    JDataTableModule,
    JDialogueModule
  ]
})
export class ComponentsModule { }

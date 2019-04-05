import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { JInputComponent } from './j-input.component';

@NgModule({
  imports: [
    CommonModule,
    MatInputModule
  ],
  declarations: [
    JInputComponent
  ],
  exports: [
    JInputComponent
  ]
})
export class JInputModule { }

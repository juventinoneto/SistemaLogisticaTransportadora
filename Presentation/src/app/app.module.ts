import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material';
import { JInputModule } from './shared/components/j-input/j-input.module';
import { JTextareaModule } from './shared/components/j-textarea/j-textarea.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    JInputModule,
    JTextareaModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

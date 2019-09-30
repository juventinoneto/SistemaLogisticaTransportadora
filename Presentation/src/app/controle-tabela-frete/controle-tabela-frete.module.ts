import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ControleTabelaFreteComponent } from './controle-tabela-frete.component';
import { SharedModule } from 'primeng/components/common/shared';
import { DialogModule } from 'primeng/dialog';
import { AccordionModule } from 'primeng/accordion';
import { MessagesModule } from 'primeng/messages';
import { MessageModule } from 'primeng/message';
import { HttpClientModule }    from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    DialogModule,
    AccordionModule,
    MessageModule,
    MessagesModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  declarations: [
    ControleTabelaFreteComponent
  ],
  exports: [
    ControleTabelaFreteComponent
  ]
})
export class ControleTabelaFreteModule { }

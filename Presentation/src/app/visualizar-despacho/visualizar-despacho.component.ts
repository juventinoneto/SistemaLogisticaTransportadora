import { Component, OnInit, OnChanges, SimpleChanges } from '@angular/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGridPlugin from '@fullcalendar/timegrid';
import interactionPlugin from '@fullcalendar/interaction';
import { Router } from '@angular/router';
import { ControleColetaDefinicaoCargaService } from '../controle-coleta-definicao-carga/controle-coleta-definicao-carga.service';
import { ExpedicaoCalendarData } from './models/expedicao-calendar-data.model';
import * as moment from 'moment';

@Component({
  selector: 'app-visualizar-despacho',
  templateUrl: './visualizar-despacho.component.html',
  styleUrls: ['./visualizar-despacho.component.css']
})
export class VisualizarDespachoComponent implements OnInit {

  events: any[] = [];
  eventsAux: any[] = [];
  valoresGrid: ExpedicaoCalendarData[] = [];
  display = false;

  options: any;

  header: any;

  dataAtual: Date = new Date();

  expedicoes: ExpedicaoCalendarData[] = [];

  constructor(
    private router: Router,
    private coletaService: ControleColetaDefinicaoCargaService
  ) { }

  ngOnInit() {
    this.getColetas();    
    this.options = this.getOptions();
  }

  getOptions() {
    return {
      plugins: [dayGridPlugin, timeGridPlugin, interactionPlugin],
      locale: 'pt-br',
      header: {
        left: 'prev,next',
        center: 'title',
        right: 'dayGridMonth,timeGridWeek,timeGridDay'
      },
      editable: true,
      dateClick: (e) => {        
        this.valoresGrid = this.expedicoes.filter(x => x.data.toString().split('T')[0] == e.dateStr);
        this.display = true;
      }
    };
  }

  retornarPainelGeral() {
    this.router.navigateByUrl('main');
  }

  private getColetas() {
    this.coletaService.get().subscribe(resp => {
      this.expedicoes = resp; this.expedicoes.forEach(ex => {
        this.eventsAux.push({
          "title": `Coleta nº ${ex.idColeta}`,
          "start": ex.data
        });
      });
    });
    setTimeout(() => { 
      this.events = this.eventsAux;
      this.options = this.getOptions();
    }, 1000);
  }
}

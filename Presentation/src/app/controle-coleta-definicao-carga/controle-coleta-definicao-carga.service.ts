import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { SolicitarColeta } from './models/solicitar-coleta.model';
import { ResultBase } from '../models/result-base.model';
import { catchError, map, tap } from 'rxjs/operators';
import { ExpedicaoCalendarData } from '../visualizar-despacho/models/expedicao-calendar-data.model';

const url = 'http://localhost:46425/api/SolicitaColetaCliente';

@Injectable({
  providedIn: 'root'
})
export class ControleColetaDefinicaoCargaService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(
    private http: HttpClient
  ) { }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  public post(model: SolicitarColeta): Observable<ResultBase> {
    return this.http.post<ResultBase>(url, model, this.httpOptions).pipe(
      tap(() => console.log('Realizando nova solicitação de coleta')),
      catchError(this.handleError<ResultBase>('erro'))
    );
  }

  public get(): Observable<ExpedicaoCalendarData[]> {
    return this.http.get<ExpedicaoCalendarData[]>(url)
      .pipe(
        catchError(this.handleError<any[]>('coletas', []))
      );
  }
}

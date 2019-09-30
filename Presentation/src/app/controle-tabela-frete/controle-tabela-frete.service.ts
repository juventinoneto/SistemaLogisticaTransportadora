import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { ResultBase } from '../models/result-base.model';
import { RegistrarTarifa } from './models/registrar-tarifa.model';
import { tap, catchError } from 'rxjs/operators';

const url = 'http://localhost:46425/api/ControleTabelaFrete';

@Injectable({
  providedIn: 'root'
})
export class ControleTabelaFreteService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(
    private http: HttpClient
  ) { }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.message}`);
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  public post(model: RegistrarTarifa): Observable<ResultBase> {
    return this.http.post<ResultBase>(url, model, this.httpOptions).pipe(
      tap(() => console.log('Realizando nova tarifa')),
      catchError(this.handleError<ResultBase>('erro'))
    );
  }

  public put(model: RegistrarTarifa): Observable<ResultBase> {
    return this.http.put<ResultBase>(url, model, this.httpOptions).pipe(
      tap(() => console.log('Realizando alteração de tarifa')),
      catchError(this.handleError<ResultBase>('erro'))
    );
  }
}

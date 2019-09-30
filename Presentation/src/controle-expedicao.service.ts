import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { ResultBase } from './app/models/result-base.model';
import { RegistrarExpedicao } from './app/controle-expedicao/models/registrar-expedicao.model';
import { tap, catchError } from 'rxjs/operators';

const url = 'http://localhost:46425/api/ControleExpedicao';

@Injectable({
  providedIn: 'root'
})
export class ControleExpedicaoService {

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

  public post(model: RegistrarExpedicao): Observable<ResultBase> {
    return this.http.post<ResultBase>(url, model, this.httpOptions).pipe(
      tap(() => console.log('Cadastrando nova expedicao')),
      catchError(this.handleError<ResultBase>('erro'))
    );
  }
}

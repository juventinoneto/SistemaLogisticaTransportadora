import { Injectable } from '@angular/core';
import { catchError, map, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ColetaGrid } from '../models/coleta-grid.model';

const url = 'http://localhost:46425/api/values';
const proxyurl = "https://cors-anywhere.herokuapp.com/";

@Injectable({
  providedIn: 'root'
})
export class PainelGeralService {

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

  public get(): Observable<ColetaGrid[]> {
    return this.http.get<ColetaGrid[]>(url)
    .pipe(
      catchError(this.handleError<any[]>('coletas', []))
    );
  }
}

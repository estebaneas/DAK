import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CondadoService {

  constructor(private http: HttpClient) { }

  getQuery(query: string) {

    const url = `https://localhost:44318/api/Condado/${query}`;

    return this.http.get(url)
  }

  // Obtiene Lista Condado
  getCondadoList() {
    return this.getQuery('ListaCondado')
      .pipe(map(data => data));
  }
}

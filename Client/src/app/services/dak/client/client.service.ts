import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private http: HttpClient) { }

  getQuery(query: string) {

    const url = `https://localhost:8080/${query}`;

    return this.http.get(url)
  }

  // Obtiene Lista Clientes
  addClient() {
    return this.getQuery('client')
      .pipe(map(data => data));
  }

  // Obtiene Lista Clientes
  getClientList() {
    return this.getQuery('client')
      .pipe(map(data => data));
  }

  // Obtiene un Cliente
  getClient(id: string) {
    return this.getQuery(`clients/${id}`)
    .pipe(map (data =>  data ));
  }
}

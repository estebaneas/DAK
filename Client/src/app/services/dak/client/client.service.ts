import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { map } from 'rxjs/operators';
import { cliente } from '../../../components/models/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private http: HttpClient) { }

  getQuery(query: string) {

    const url = `https://localhost:44318/api/Cliente/${query}`;

    return this.http.get(url)
  }

  getQueryWithData(query: string, data: string) {

    const url = `https://localhost:44318/api/Cliente/${query}?busqueda=${data}`;

    return this.http.get(url)
  }


  postQuery(query: string, body: any) {

    const url = `https://localhost:44318/api/Cliente/${query}`;

    return this.http.post(url, body)
  }

  // Obtiene Lista Clientes
  addClient(cli: cliente) {
    return this.postQuery('RegistrarCliente', cli)
      .pipe(map(data => {
        console.log(data);
        data
      }));
  }

    // Obtiene Lista Clientes
    getClients(document: string) {
      return this.getQueryWithData('BuscarCliente', document)
        .pipe(map(data => data));
    }

    
    // Obtiene Lista Clientes
    getGroup(document: string) {
      return this.getQueryWithData('BuscarClienteGrupo', document)
        .pipe(map(data => data));
    }


}

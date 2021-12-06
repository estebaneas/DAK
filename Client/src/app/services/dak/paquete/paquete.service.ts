import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { paquete } from 'src/app/components/models/paquete';
import { pagoPaquete } from '../../../components/models/pagoPaquete';

@Injectable({
  providedIn: 'root'
})
export class PaqueteService {

  constructor(private http: HttpClient) { }

  
  postQueryData(query: string, data: any) {

    const url = `https://localhost:44318/api/Paquete/${query}`;
    console.log(data + "LLEGOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");

    return this.http.post(url, data, {headers: { 'Content-Type': 'application/json' }});
  }
  registrarPaquete(paquete: paquete) {
    console.log("LLEGO ESTE PAQUETEEEEEEEEEEE" + JSON.stringify(paquete))
    return this.postQueryData("RegistrarPaquete", JSON.stringify(paquete))
    .pipe(map(data => data));
  }

}

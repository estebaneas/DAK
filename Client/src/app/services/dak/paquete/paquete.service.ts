
import { HttpClient } from '@angular/common/http';

import { map } from 'rxjs/operators';
import { paquete } from 'src/app/components/models/paquete';
import { Injectable } from '@angular/core';

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


  async getPaquetes(filtro:any)
  {

     console.log("remitente"+filtro.remitente)
    let parametros="fechaRecibido="+filtro.recibido+
    "&fechaEntregado="+
    "&estado="+filtro.estado+
    "&documentoRemitente="+filtro.remitente+
    "&documentoDestinatario="+filtro.destinatario+
    "&numFactura="+
    "&pagina="+
    "&tracking="+filtro.tracking+
    "&paginaActual="+filtro.paginaActual+
    "&paginaTot="+filtro.paginaTot+
    "&paginasPorHoja="+filtro.paginasPorHoja;

      return await fetch("https://localhost:44318/api/Paquete/GetPaquetes?"+parametros)
    
  }
}


import { destroyPlatform, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PaqueteService {

  constructor() { }

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



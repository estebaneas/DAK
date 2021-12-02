import { Injectable } from '@angular/core';
import { paquete } from 'src/app/components/models/paquete';

@Injectable({
  providedIn: 'root'
})
export class PagoService {

  constructor() { }

    pagar()
    {
      //TODO Llamar al metodo de pagar y luego al metodo de guardar paquete
    }
    // Guarda lista paquete en localStorage
    localStorage(paquete: paquete) {
      localStorage.setItem("paquete", JSON.stringify(paquete))
    }
}

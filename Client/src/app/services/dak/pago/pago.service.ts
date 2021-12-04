import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { paquete } from 'src/app/components/models/paquete';

@Injectable({
  providedIn: 'root'
})
export class PagoService {

  constructor(private http: HttpClient) { }

    getQuery(query: string) {

    const url = `https://localhost:44318/api/Factura/${query}`;

    return this.http.get(url)
  }

    pagar()
    {
      //TODO Llamar al metodo de pagar y luego al metodo de guardar paquete
    }

    calcularMonto()
    {
      return this.getQuery('CalcularMonto')
      .pipe(map(data => data));
    }
    // Guarda lista paquete en localStorage
    localStorage(paquete: paquete) {
      localStorage.setItem("paquete", JSON.stringify(paquete))
    }
}

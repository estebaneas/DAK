import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { paquete } from 'src/app/components/models/paquete';
import { pagoPaquete } from '../../../components/models/pagoPaquete';

@Injectable({
  providedIn: 'root'
})
export class PagoService {

  constructor(private http: HttpClient) { }

  getQuery(query: string) {

    const url = `https://localhost:44318/api/Factura/${query}`;

    return this.http.get(url)
  }

  getCalcularPrecio(distancia: number, peso: number, grupo: number) {

    const url = `https://localhost:44318/api/Factura/CalcularPrecio?distancia=${distancia}&peso=${peso}&grupo=${grupo}`;

    return this.http.get(url)
  }

  pagar() {
    //TODO Llamar al metodo de pagar y luego al metodo de guardar paquete
  }
  getCalcularPrecioDescuento(factura: pagoPaquete)
  {
    console.log(JSON.stringify(factura));
  }

  calcularMonto(distancia: number, peso: number, grupo: number) {
    
    return this.getCalcularPrecio(distancia, peso, grupo)
      .pipe(map(data => data));
  }
  // Guarda lista paquete en localStorage
  localStorage(paquete: paquete) {
    localStorage.setItem("paquete", JSON.stringify(paquete))
  }
}

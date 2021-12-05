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

  
  getQueryData(query: string, data: any) {

    const url = `https://localhost:44318/api/Factura/${query}`;
    console.log("Entro a getQueryData con esta data: " + data)
    

    return this.http.post(url, data, {headers: { 'Content-Type': 'application/json' }});
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
    console.log("llego al servicio getCalcularPrecioDescuento con esta data: " + JSON.stringify(factura));
    factura.FechaDepago = new Date();
    return this.getQueryData("CalcularPrecioFinal", JSON.stringify(factura))
    .pipe(map(data => data));
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

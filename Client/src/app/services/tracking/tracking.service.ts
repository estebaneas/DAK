import { Injectable } from '@angular/core';
import { coordenadas } from '../../components/tracking/models/coordenadas.interface';
import { HttpClient } from '@angular/common/http';
import { Observable, observable } from 'rxjs';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class TrackingService {

 private RastrearNumero = "https://localhost:44361/api/Tracking/Rastrear?NumeroTracking=";
 private VerificarNumero = "https://localhost:44361/api/Tracking/VerificarNumero?NumeroTracking=";

  constructor(private http:HttpClient) { }
  rastrear(numeroTracking:string):Observable<coordenadas>{
    return this.http.get<coordenadas>(this.RastrearNumero+numeroTracking)
  }

  async verificar(numeroTracking:string){
    var dato = await this.http.get<boolean>(this.VerificarNumero+numeroTracking).pipe(map(data=>console.log(data)))
    console.log(dato) 
    console.log("1");
    return dato;
  }
}

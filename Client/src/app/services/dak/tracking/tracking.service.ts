import { Injectable,Output,EventEmitter } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class TrackingService {
@Output() puente: EventEmitter<any> = new EventEmitter();
  constructor() { }

 async verificar(numeroTracking:string)
  {
      return await fetch("https://localhost:44361/api/Tracking/VerificarNumero?NumeroTracking="+numeroTracking)
  }

  async cargarHubicacion(numeroTracking:string)
  {
      return await fetch("https://localhost:44361/api/Tracking/Rastrear?NumeroTracking="+numeroTracking)
  }

}

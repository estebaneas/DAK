import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'estadoPaquete'
})
export class EstadoPaquetePipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    
 /** RECIBIDO,
        EN_PROCESO,
        ENVIADO,
        ENTREGADO,
        DEVUELTO */

    let estadoPaquete;

    switch (value) {
      case 0:
        estadoPaquete = "Recibido"

        break;
      case 1:
        estadoPaquete = "En Proceso"
        break;
      case 2:
        estadoPaquete = "Enviado"
        break;
      case 3:
        estadoPaquete = "Entregado"
        break;
      case 4:
        estadoPaquete = "Devuelto"
        break;
      default:
        estadoPaquete = "Error"
        break;
    }

    return estadoPaquete
  }
 
}

import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'tamanoPaquete'
})
export class TamanoPaquetePipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    let tamanioPaquete;
    
/** MUY_CHICO,
        CHICO,
        MEDIANO,
        GRANDE,
        MUY_GRANDE */

    switch (value) {
      case 0:
        tamanioPaquete = "Muy chico"
        break;
      case 1:
        tamanioPaquete = "Chico"
        break;
      case 2:
        tamanioPaquete = "Mediano"
        break;

      case 3:
        tamanioPaquete = "Grande"
        break;
      case 4:
        tamanioPaquete = "Muy grande"
        break;
      default:
        break;
    }

    return tamanioPaquete;
  }

}
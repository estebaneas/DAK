import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'estadoPaqueteStyle'
})
export class EstadoPaqueteStylePipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    let estadoPaquete;

  switch (value) {
    case 0:
      estadoPaquete = "badge-secondary"

      break;
    case 1:
      estadoPaquete = "badge-info"
      break;
    case 2:
      estadoPaquete = "badge-primary"
      break;
    case 3:
      estadoPaquete = "badge-success"
      break;
    case 4:
      estadoPaquete = "badge-danger"
      break;
    default:
      estadoPaquete = "Error"
      break;
  }

  return estadoPaquete
  }

  
}

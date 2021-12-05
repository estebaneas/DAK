import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { paquete } from '../models/paquete';
import { PagoService } from '../../services/dak/pago/pago.service';
import { ClientService } from '../../services/dak/client/client.service';
import { debounceTime } from 'rxjs/operators';
import { pagoPaquete } from '../models/pagoPaquete';

@Component({
  selector: 'app-pago',
  templateUrl: './pago.component.html',
  styleUrls: ['./pago.component.css']
})
export class PagoComponent {

  loading: boolean = true;
  selected: number = 0;
  items: any[] = [
    { id: 1, name: 'Debito' },
    { id: 2, name: 'Visa' },
    { id: 3, name: 'Mercado Pago' },
    { id: 4, name: 'Efectivo' },
  ];
  paquetePago: paquete;
  distancia: number = 0;
  peso: number = 0;
  subtotal: number = 0;
  descuento: number = 0;
  total: number = 0;

  constructor(private PagoService: PagoService,
    private ClientService: ClientService) {
    let grupo: number;
    //Objeto de paquete
    this.paquetePago = JSON.parse(localStorage.getItem("paquete") as string);
    //Trae el grupo dependiendo del documento del remitente
    this.ClientService.getGroup(this.paquetePago.remitente)
      .subscribe((data: any) => {
        grupo = data;
        this.PagoService.calcularMonto(this.paquetePago.distancia, this.paquetePago.peso, grupo)
          .subscribe((data: any) => {
            this.subtotal = data;
            this.loading = false;
          })
      }
      )
    this.loading = false;
  }


  selectOption(event: any) {
    let pago: pagoPaquete = new pagoPaquete({
      Numero: 0,
      Monto: this.subtotal,
      FechaDepago: new Date(),
      MontoFinal: 0,
      TipoPago: this.selected
    });

    this.PagoService.getCalcularPrecioDescuento(pago).subscribe((data: any ) => {
      this.total = data;
      this.descuento = this.subtotal - this.total;});

  }

  formPago = new FormGroup(
    {
      metodoDePago: new FormControl('', [Validators.required])
    })

}

import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { paquete } from '../models/paquete';
import { PagoService } from '../../services/dak/pago/pago.service';

@Component({
  selector: 'app-pago',
  templateUrl: './pago.component.html',
  styleUrls: ['./pago.component.css']
})
export class PagoComponent{

  loading: boolean = true;
  selected: number = 0;
  items: any[] = [
    { id: 1, name: 'Debito' },
    { id: 2, name: 'Visa' },
    { id: 3, name: 'Mercado Pago' },
    { id: 4, name: 'Efectivo' },
  ];
  paquetePago : paquete;

  constructor(private PagoService: PagoService) { 

    this.paquetePago = JSON.parse(localStorage.getItem("paquete") as string);
    this.PagoService.calcularMonto()
    .subscribe((data: any) => {
      //TODO
      this.loading = false;
    });
    this.loading = false;
    
  }


  selectOption( event: any) {
    //getted from event
    // console.log(this.selected);
  }

  formPago = new FormGroup(
    {
      metodoDePago: new FormControl('', [Validators.required])
    })

}

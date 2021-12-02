import { Component} from '@angular/core';
import { FormControl, FormGroup, Validators} from '@angular/forms';
import { paquete } from '../../models/paquete';
import { CondadoService } from 'src/app/services/dak/condado/condado.service';
import { PagoService } from '../../../services/dak/pago/pago.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ingresar-paquete',
  templateUrl: './ingresar-paquete.component.html',
  styleUrls: ['./ingresar-paquete.component.css']
})
export class IngresarPaqueteComponent{

  condados: any[] = [];
  loading: boolean = true;

  constructor(private condadoService: CondadoService,
              private PagoService: PagoService,
              private router: Router) {
    
    
    this.condadoService.getCondadoList()
    .subscribe((data: any) => {
      this.condados = data;
      this.loading = false;
    });
   }

   formPaquete = new FormGroup(
    {
      remitente: new FormControl('', [Validators.required]),
      destinatario: new FormControl('', [Validators.required]),
      calle: new FormControl('', [Validators.required]),
      condado: new FormControl('', [Validators.required]),
      localidad: new FormControl('', [Validators.required]),
      detalle: new FormControl('', [Validators.required]),
      peso: new FormControl('', [Validators.required])
    }
  )

  
  pagar(paquete: paquete)
  {
    paquete.remitente = this.formPaquete.value['remitente'],
    paquete.destinatario = this.formPaquete.value['destinatario'],
    paquete.calle = this.formPaquete.value['calle'],
    paquete.condado = this.formPaquete.value['condado'],
    paquete.localidad = this.formPaquete.value['localidad'],
    paquete.detalle = this.formPaquete.value['detalle'],
    paquete.peso = this.formPaquete.value['peso']

    //Se guarda en localStorage
    this.PagoService.localStorage(paquete);
    //Se navega a pago
    this.router.navigateByUrl('/pago');

  }

    //#region Validaciones
    get remitente()
    {
      return this.formPaquete.get('remitente');
    }
  
    get destinatario()
    {
      return this.formPaquete.get('destinatario');
    }
    get calle()
    {
      return this.formPaquete.get('calle');
    }
    get condado()
    {
      return this.formPaquete.get('condado');
    }
    get localidad()
    {
      return this.formPaquete.get('localidad');
    }
    get detalle()
    {
      return this.formPaquete.get('detalle');
    }
    get peso()
    {
      return this.formPaquete.get('peso');
    }
    //#endregion


}

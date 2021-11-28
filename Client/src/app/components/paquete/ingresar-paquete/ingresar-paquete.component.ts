import { Component} from '@angular/core';
import { FormControl, FormGroup, Validators} from '@angular/forms';
import { CondadoService } from 'src/app/services/dak/condado/condado.service';

@Component({
  selector: 'app-ingresar-paquete',
  templateUrl: './ingresar-paquete.component.html',
  styleUrls: ['./ingresar-paquete.component.css']
})
export class IngresarPaqueteComponent{

  condados: any[] = [];
  loading: boolean = true;

  constructor(private condadoService: CondadoService) {
    this.condadoService.getCondadoList()
    .subscribe((data: any) => {
      console.log(data);
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

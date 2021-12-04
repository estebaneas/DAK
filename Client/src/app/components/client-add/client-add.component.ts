import { Component } from '@angular/core';
import { FormControl, FormControlName, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-client-add',
  templateUrl: './client-add.component.html',
  styleUrls: ['./client-add.component.css']
})
export class ClientAddComponent{

  radio: any;
  isChecked: boolean = true;
  items: any[] = [
    { id: 3, name: 'Fijo' },
    { id: 1, name: 'Peso' },
    { id: 2, name: 'Peso Distancia' }
  ];

  constructor() { }
  formCliente = new FormGroup(
    {
      telefono: new FormControl('', [Validators.required]),
      localidad: new FormControl('', [Validators.required]),
      calle: new FormControl('', [Validators.required]),
      detalleDireccion: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required]),
      documento: new FormControl('', [Validators.required]),
      nombre: new FormControl('', [Validators.required]),
      apellido: new FormControl('', [Validators.required]),
      rut: new FormControl('', [Validators.required]),
      razonSocial: new FormControl('',),
      grupo: new FormControl('', [Validators.required]),
    }
  )
  // agregar(paquete: paquete)
  // {

  // }

  cambiarTrue()
  {
    this.isChecked = true;
  }

  cambiarFalse()
  {
    this.isChecked = false;
  }


}

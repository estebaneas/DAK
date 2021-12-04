import { Component } from '@angular/core';
import { FormControl, FormControlName, FormGroup, Validators } from '@angular/forms';
import { cliente } from '../models/cliente';
import { empresa } from '../models/empresa';
import { persona } from '../models/persona';
import { CondadoService } from 'src/app/services/dak/condado/condado.service';
import { ClientService } from '../../services/dak/client/client.service';

@Component({
  selector: 'app-client-add',
  templateUrl: './client-add.component.html',
  styleUrls: ['./client-add.component.css']
})
export class ClientAddComponent {

  radio: any;
  isChecked: boolean = true;
  condados: any[] = [];
  loading: boolean = true;
  items: any[] = [
    { id: 3, name: 'Fijo' },
    { id: 1, name: 'Peso' },
    { id: 2, name: 'Peso Distancia' }
  ];

  constructor(private condadoService: CondadoService,
              private clienteServie: ClientService) { 

    this.condadoService.getCondadoList()
    .subscribe((data: any) => {
      console.log(data);
      this.condados = data;
      this.loading = false;
    });
  }
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
      condado: new FormControl('',[Validators.required])
    }
  )

  agregarCliente() {
    let result = this.mapearCliente();
    console.log('Entro a agregar cliente con estos datos:' + result.telefono);
    this.clienteServie.addClient(result)
    .subscribe((data: any) => {
      this.condados = data;
      this.loading = false;
    });

  }

  mapearCliente() {

    let tipoDocumento: number = 1;
    let docu: string;

    let per: persona = {
      documento : this.formCliente.value['documento'],
      nombre : this.formCliente.value['nombre'],
      apellido : this.formCliente.value['apellido'],
    }

    let emp: empresa = {
      rut : this.formCliente.value['rut'],
      razon_social : this.formCliente.value['razonSocial'],
    }

    if(emp.razon_social != null){
      tipoDocumento = 0,
      docu = this.formCliente.value['rut']
    }
    else{
      docu = this.formCliente.value['documento']
    }

    let cli: cliente = {
      tipo_documento : tipoDocumento,
      documento : docu,
      telefono : this.formCliente.value['telefono'],
      localidad : this.formCliente.value['localidad'],
      calle : this.formCliente.value['calle'],
      detalle_direccion : this.formCliente.value['detalleDireccion'],
      email : this.formCliente.value['email'],
      id_condado : this.condados.find(f=> f.Nombre == this.formCliente.value['condado']).ID,
      grupo: this.items.find(f=> f.name == this.formCliente.value['grupo']).id,
      persona : per,
      empresa : emp
    };

    return cli;
  }

  cambiarTrue() {
    this.isChecked = true;
  }

  cambiarFalse() {
    this.isChecked = false;
  }


}

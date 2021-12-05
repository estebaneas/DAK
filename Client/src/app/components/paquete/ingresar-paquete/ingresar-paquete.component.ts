import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, FormGroup, Validators } from '@angular/forms';


import { CondadoService } from 'src/app/services/dak/condado/condado.service';
import { PagoService } from '../../../services/dak/pago/pago.service';
import { Observable } from 'rxjs';
import { debounce, debounceTime, startWith } from 'rxjs/operators';
import { map } from 'rxjs/operators';
import { ClientService } from '../../../services/dak/client/client.service';
import { paquete } from '../../models/paquete';

@Component({
  selector: 'app-ingresar-paquete',
  templateUrl: './ingresar-paquete.component.html',
  styleUrls: ['./ingresar-paquete.component.css']
})
export class IngresarPaqueteComponent implements OnInit {

  condados: any[] = [];
  clients: string[] = [];
  loading: boolean = true;

  control: FormControl = new FormControl();
  filClients: Observable<string[]> = new Observable<string[]>();

  constructor(private condadoService: CondadoService,
    private PagoService: PagoService,
    private ClientService: ClientService,
    private router: Router) {

    this.condadoService.getCondadoList()
      .subscribe((data: any) => {
        this.condados = data;
        this.loading = false;
      });

    console.log("Lista CLi" + this.clients)

  }

  ngOnInit(): void {
    this.filClients = this.control.valueChanges.pipe(
      debounceTime(500),
      startWith(''),
      map(val => this._filter(val))
    )

  }

  //#region Filtro
  private _filter(val: string): string[] {
    const formatVal = val.toLocaleLowerCase();

    this.ClientService.getClients(formatVal)
      .subscribe((data: any) => {
        this.clients = data
      });
    return this.clients.filter(client => client.toLocaleLowerCase().indexOf(formatVal) === 0);
  }
  //#endregion

  formPaquete = new FormGroup(
    {
      calle: new FormControl('', [Validators.required]),
      condado: new FormControl('', [Validators.required]),
      localidad: new FormControl('', [Validators.required]),
      detalle: new FormControl('', [Validators.required]),
      peso: new FormControl('', [Validators.required]),
    }
  )


  pagar(paquete: paquete, remitente: string, destrinatario: string) {


    paquete.remitente = remitente,
    paquete.destinatario = destrinatario,
    paquete.calle = this.formPaquete.value['calle'],
    paquete.condado = this.formPaquete.value['condado'],
    paquete.distancia = this.condados.find(f => f.Nombre == this.formPaquete.value['condado']).Distancia,
    paquete.localidad = this.formPaquete.value['localidad'],
    paquete.detalle = this.formPaquete.value['detalle'],
    paquete.peso = this.formPaquete.value['peso'],
    paquete.grupo = this.formPaquete.value['grupo']

    //Se guarda en localStorage
    this.PagoService.localStorage(paquete);
    //Se navega a pago
    this.router.navigateByUrl('/pago');

  }

  //#region Validaciones
  get remitente() {
    return this.formPaquete.get('remitente');
  }

  get destinatario() {
    return this.formPaquete.get('destinatario');
  }
  get calle() {
    return this.formPaquete.get('calle');
  }
  get condado() {
    return this.formPaquete.get('condado');
  }
  get localidad() {
    return this.formPaquete.get('localidad');
  }
  get detalle() {
    return this.formPaquete.get('detalle');
  }
  get peso() {
    return this.formPaquete.get('peso');
  }
  //#endregion


}

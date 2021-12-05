import { Component, OnInit } from '@angular/core';
import { PaqueteService } from 'src/app/services/dak/paquete/paquete.service';
import { Title } from '@angular/platform-browser';
import { FormControl, FormGroup } from '@angular/forms';
import { ErrorComponent } from '../../modales/error/error.component';
import { filtroPaquete } from '../../models/filtroPaquete';
import { MatDialog } from '@angular/material/dialog';
@Component({
  selector: 'app-listar-paquetes',
  templateUrl: './listar-paquetes.component.html',
  styleUrls: ['./listar-paquetes.component.css']
})
export class ListarPaquetesComponent implements OnInit {

  constructor( private service:PaqueteService, private titleService:Title,private errorWindow:MatDialog) { }
  public paquetes: any = []
  formFiltro = new FormGroup({
    fechaRecibido : new FormControl(),
    remitente : new FormControl(),
    destinatario : new FormControl(),
    estado : new FormControl(),
    tracking : new FormControl(),
  })

  public disAnterior = true;
  public disSiguiente = true;
  public paginaActual = 1
  public totPaginas?:any
  public paginasPorHoja = 30

  ngOnInit(): void {
    this.loadPaquetes()
    
  }


  resetFitro() {
    this.formFiltro.reset()
    this.loadPaquetes()
  }

  nextPage(){
    this.paginaActual+=1
    this.disSiguiente=true;
    this.disAnterior=true;
    this.loadPaquetes() 
  }

  prePage(){
    this.paginaActual-=1
    this.disSiguiente=true;
    this.disAnterior=true;
    this.loadPaquetes() 
  }
  error()
  {
    let errorData=["No se pudo conectar con el servidor","Intentelo mas tarde"]
    sessionStorage.setItem("errorData",JSON.stringify(errorData))
    this.errorWindow.open(ErrorComponent,{
      height: '150px',
      width: '320px',
      panelClass:"test",    
    })
    this.paquetes=[]
    this.disAnterior=true;
    this.disSiguiente=true;
    this.paginaActual =1
    this.formFiltro.reset()
 }

  async loadPaquetes() {
    let filtro: any={
      recibido:this.formFiltro.value["fechaRecibido"],
      remitente:this.formFiltro.value["remitente"],
      destinatario:this.formFiltro.value["destinatario"],
      estado:this.formFiltro.value["estado"],
      tracking:this.formFiltro.value["tracking"],
      paginaActual:this.paginaActual,
      totPaginas:this.totPaginas,
      paginasPorHoja:this.paginasPorHoja,
     }

    try {
      const respuesta = await (await this.service.getPaquetes(filtro)).json();
      console.log("respuesta")
      this.titleService.setTitle("Lista de Paquetes")
      this.paquetes=respuesta.paquetes;
      let totalPaginas=this.totPaginas= Math.ceil(respuesta.totalDePaquetesRegistrados/this.paginasPorHoja)
      if(this.paginaActual>1){
        this.disAnterior=false;
      }
      else{
        this.disAnterior=true;
      }
      if(this.paginaActual<totalPaginas){
        console.log(this.totPaginas)
        this.disSiguiente=false;
      }
      else{
        console.log(this.paginaActual)
        this.disSiguiente=true;
      }
     }
    catch(error) {
      console.log(error)
      this.error()
     }
  }

 
  


}

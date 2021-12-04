import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators} from '@angular/forms';
import { Router } from '@angular/router';
import { ErrorComponent } from '../../modales/error/error.component';

import { TrackingService } from 'src/app/services/dak/tracking/tracking.service';
import { coordenadas } from '../../models/coordenadas';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-tracking-home',
  templateUrl: './tracking-home.component.html',
  styleUrls: ['./tracking-home.component.css']
})
export class TrackingHomeComponent implements OnInit {

  constructor(private service: TrackingService , private route:Router,private errorWindow:MatDialog) { }

  public mensaje = ""
  public formTracking= new FormGroup({
    numeroTracking : new FormControl('',[Validators.required]),
 
  })
  public isDisabled : boolean =true;
  public disableInput:boolean = false;
  public errorData?:string[]

  ngOnInit(): void {
  }

validate(){
  this.mensaje="";
  if (this.formTracking.value['numeroTracking']!=""){
    this.isDisabled=false;
  }
  else{
    this.isDisabled=true;
  }
}

  async verificar() {
    this.mensaje=""
    
    var tracking = this.formTracking.value['numeroTracking']

      try {
        this.formTracking.get("numeroTracking")?.disable()
        this.disableInput = true;
        this.isDisabled = true;
        const respuesta = await (await this.service.verificar(tracking)).json();
        if (respuesta) {
          console.log(respuesta)
          this.mostrarhubicacion(tracking);
        }
        else {
          console.log("Ese numero no existe");
          this.mensaje="El numero que ingreso es invalido o no existe"
          this.isDisabled = false
          this.formTracking.get("numeroTracking")?.enable()
        }
      } catch (error) {
        this.error();
        this.isDisabled = false;
      }
  }

  error()
  {
    this.errorData=["No se pudo conectar con el servidor","Intentelo mas tarde",]
    this.formTracking.get("numeroTracking")?.enable()
    sessionStorage.setItem("errorData",JSON.stringify(this.errorData))
    
    this.errorWindow.open(ErrorComponent,{
      height: '150px',
      width: '320px',
      panelClass:"test",    
    })
    this.errorData=[];
 }

  async mostrarhubicacion(tracking:string)
  {
    const coordenadas =  <coordenadas> await (await this.service.cargarHubicacion(tracking)).json();
    if(coordenadas!=null){
      sessionStorage.setItem("coords",JSON.stringify(coordenadas))
      sessionStorage.setItem("tracking",tracking);
      this.route.navigateByUrl('tracking-results');
    }
    else{
      this.isDisabled=false;
      this.formTracking.get("numeroTracking")?.enable()
      this.errorData=["Hubo un error al comunicarse con el servicio de tracking","Intentelo mas tarde",]
      sessionStorage.setItem("errorData",JSON.stringify(this.errorData))
      console.log("EROOR")
      console.log(this.errorData)
      this.errorWindow.open(ErrorComponent,{
        height: '150px',
        width: '320px',
        panelClass:"test",
      })
      this.errorData=[]
    }
 
    
    //this.service.puente.emit(coordenadas);
  }
}

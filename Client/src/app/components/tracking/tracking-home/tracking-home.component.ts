import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators} from '@angular/forms';
import { Router } from '@angular/router';

import { TrackingService } from 'src/app/services/dak/tracking/tracking.service';
import { coordenadas } from '../../models/coordenadas';
interface pokemon {
  id:number;
  name:string;
}
@Component({
  selector: 'app-tracking-home',
  templateUrl: './tracking-home.component.html',
  styleUrls: ['./tracking-home.component.css']
})
export class TrackingHomeComponent implements OnInit {

  constructor(private service: TrackingService , private route:Router) { }
  public formTracking= new FormGroup({
    numeroTracking : new FormControl('',[Validators.required])
  })

  ngOnInit(): void {
  }

  async verificar() {
    var tracking = this.formTracking.value['numeroTracking']
    try{
      const respuesta = await (await this.service.verificar(tracking)).json();
      if(respuesta){
        this.mostrarhubicacion(tracking);
      }
      else{
        console.log("Ese numero no existe");
      }
    }catch(error){
      console.log(error);
    }
  }

  async mostrarhubicacion(tracking:string)
  {
    const coordenadas =  <coordenadas> await (await this.service.cargarHubicacion(tracking)).json();
    sessionStorage.setItem("coords",JSON.stringify(coordenadas))
    this.route.navigateByUrl('tracking-results');
    
    this.service.puente.emit(coordenadas);
  }
}

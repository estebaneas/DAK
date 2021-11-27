import { Component, OnInit } from '@angular/core';
import { TrackingService } from '../../../services/tracking/tracking.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { coordenadas } from '../models/coordenadas.interface';

@Component({
  selector: 'app-tracking',
  templateUrl: './tracking.component.html',
  styleUrls: ['./tracking.component.css']
})
export class TrackingComponent implements OnInit {
  prueba?:string;
  existe?:boolean;
  coords?:coordenadas;
  constructor(private servicio:TrackingService) { }
  formTracking = new FormGroup({
      numeroTracking: new FormControl('',Validators.required)
  });
 
  rastrear(tracking:string){
    this.servicio.rastrear(tracking).subscribe(data=>this.coords=data);
    this.servicio.rastrear(tracking).subscribe(data=>console.log(data));
  }
  async verificar()
  {
    var bool=false;
    var tracking=this.formTracking.value['numeroTracking']
   // await this.servicio.verificar(tracking).subscribe((data:any)=>console.log(data));
    console.log(2);
    if(bool){
      this.existe=bool;
      this.rastrear(tracking)
    }
    else{
      alert("LOQUITAA")
    }
    console.log(3)
   // console.log(dato)
  }
  ngOnInit(): void {

  }

}

import { Component, OnInit } from '@angular/core';


import { MatDialogRef } from '@angular/material/dialog';
@Component({
  selector: 'app-detalle-tracking',
  templateUrl: './detalle-tracking.component.html',
  styleUrls: ['./detalle-tracking.component.css']
})
export class DetalleTrackingComponent implements OnInit {

  public detalles = [
    { detalle: "Paquete en proceso", fecha: "10/11/2021 16:32" },
    { detalle: "Paquete en camino", fecha: "11/11/2021 09:45" },
    { detalle: "Paquete entregado", fecha: "14/11/2021 18:23" },

    
  ]
  
  constructor(public dialog:MatDialogRef<DetalleTrackingComponent>) { }
  //detalles =JSON.parse(sessionStorage.getItem("detalles")!);
 ;

  ngOnInit(): void {
   

  }

  cerrar(){
    //console.log(this.detalles,"Detalles")
    this.dialog.close();

   
  }
}

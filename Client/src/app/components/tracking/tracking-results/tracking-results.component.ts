import { Component, OnInit } from '@angular/core';
import { inject } from '@angular/core/testing';
import { MatDialogRef,MatDialogConfig,MatDialog, MAT_DIALOG_DATA, MatDialogActions, MatDialogModule } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { DetalleTrackingComponent } from '../../modales/detalle-tracking/detalle-tracking.component';


@Component({
  selector: 'app-tracking-results',
  templateUrl: './tracking-results.component.html',
  styleUrls: ['./tracking-results.component.css']
})
export class TrackingResultsComponent implements OnInit {
 
  constructor(private dialog:MatDialog,private router:Router) { }
  tracking:string = sessionStorage.getItem("tracking")!;
  clientes=["1","2","3"]
  
  ngOnInit(): void {

  }

  otroNumero()
  {
    this.router.navigate(["/tracking-home"]);
  }

  verDetalle()
  {
      let dialogRef = this.dialog.open(DetalleTrackingComponent, {
      height: '400px',
      width: '600px',
    });
  }


}

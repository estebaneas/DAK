import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-error',
  templateUrl: './error.component.html',
  styleUrls: ['./error.component.css']
})
export class ErrorComponent implements OnInit {

  constructor(public dialog:MatDialogRef<ErrorComponent>) { }
  public errorData:string[]=JSON.parse(sessionStorage.getItem("errorData")!)
  
  ngOnInit(): void {
  }

  cerrar(){
    sessionStorage.removeItem("errorData")
    this.dialog.close()  
  }
}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'app-tracking-home',
  templateUrl: './tracking-home.component.html',
  styleUrls: ['./tracking-home.component.css']
})
export class TrackingHomeComponent implements OnInit {

  constructor() { }

  formTracking= new FormGroup({
    numeroTracking : new FormControl('',[Validators.required])
  })

  ngOnInit(): void {
  }

  verificar(){

  }
}

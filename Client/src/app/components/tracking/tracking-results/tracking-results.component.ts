import { Component, OnInit } from '@angular/core';
import { TrackingService } from 'src/app/services/dak/tracking/tracking.service';


@Component({
  selector: 'app-tracking-results',
  templateUrl: './tracking-results.component.html',
  styleUrls: ['./tracking-results.component.css']
})
export class TrackingResultsComponent implements OnInit {

  
  constructor(private service: TrackingService) { }

  ngOnInit(): void {
    var coordenadas = JSON.parse(sessionStorage.getItem('coords')!);
    console.log(coordenadas)

  }


}

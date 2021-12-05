import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-tracking-layout',
  templateUrl: './tracking-layout.component.html',
  styleUrls: ['./tracking-layout.component.css']
})
export class TrackingLayoutComponent implements OnInit {

  constructor(private titleService:Title) { }

  ngOnInit(): void {
    this.titleService.setTitle("DAK Tracking")
  }

}

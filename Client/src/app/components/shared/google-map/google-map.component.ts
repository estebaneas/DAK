import { Component, OnDestroy, OnInit } from '@angular/core';
import { Loader } from '@googlemaps/js-api-loader';
import { coordenadas } from '../../models/coordenadas';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';


@Component({
  selector: 'app-google-map',
  templateUrl: './google-map.component.html',
  styleUrls: ['./google-map.component.css']
})
export class GoogleMapComponent implements OnInit {

  constructor(private router:Router) {}
  coords:coordenadas = JSON.parse(sessionStorage.getItem("coords")!);
   
  
  ngOnInit(): void {
    
    if(sessionStorage.getItem("coords")==null){
      this.router.navigate(["/tracking-home"]);
    }
    sessionStorage.clear();
    let loader = new Loader({
      apiKey: "AIzaSyCivABarU0Y-yPySojqjaL_glEdTIE2GaU",
      
    })

    let lat = Number(this.coords.lat);
    let lng = Number(this.coords.lng);
    
    loader.load().then(()=>{
      const map = new google.maps.Map(document.getElementById("map")as HTMLDivElement,{
        center:{lat, lng},zoom:15,disableDefaultUI:true
      })

      var marcador = new google.maps.Marker({
        position:null,
        map:null
      })
      let latLng = new google.maps.LatLng(lat,lng)
      console.log(latLng)
      colocarMarcador(latLng,map,marcador);


      //let latlng = new google.maps.LatLng(coordenadas);
     // console.log(latlng.lat());

      /*map.addListener("click", function(r:any){
        let h = r
        let latlng = new google.maps.LatLng(1,1);
        console.log(latlng)
        console.log(r.latLng.lat())
     
        //  console.log(h)
      })*/

     /* google.maps.event.addListener(map, 'click', function(e:any){
        let latlng =e.latLng; 
        console.log(latlng)
       
       colocarMarcador(latlng,map,marcador);
      })*/
     /* let test = new google.maps.LatLng(-0.8373335735951748, 36.75251554019303)
      marcador.setPosition(test)
      marcador.setMap(map);
      */
      function colocarMarcador(posicion:any, map:any, marcador:any) {
           marcador.setPosition(posicion)
           marcador.setMap(map)
        }
      
      
      /*var poligonoprueba = new google.maps.Polygon({
        strokeColor: "#FF0000",
        strokeOpacity: 0.8,
        strokeWeight: 2,
        fillColor: "#FF0000",
        fillOpacity: 0.35,
        editable: false,
        clickable: false,
        paths:[{"lat":-1.2760092538030647, "lng": 36.78646590698086},
        {"lat":-1.272748494438406,"lng": 36.88585784368319},
        {"lat":-1.327151142570387,"lng": 36.86989333571546},
        {"lat":-1.3218310617877784, "lng":36.77856948368499}],
        map:map,
        //map: map,
        //path: [{"lat":0,"lng":0},{"lat":1,"lng":0},{"lat":1,"lng":1},{"lat":0,"lng":1}],
        //map: map,
      });*/

    })

    

  }
}

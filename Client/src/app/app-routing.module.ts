import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { MainLayoutComponent } from './components/layouts/main-layout/main-layout.component';
import { TrackingLayoutComponent } from './components/layouts/tracking-layout/tracking-layout.component';
import { LoginComponent } from './components/login/login.component';
import { DetalleTrackingComponent } from './components/modales/detalle-tracking/detalle-tracking.component';
import { IngresarPaqueteComponent } from './components/paquete/ingresar-paquete/ingresar-paquete.component';
import { GoogleMapComponent } from './components/shared/google-map/google-map.component';
import { TrackingHomeComponent } from './components/tracking/tracking-home/tracking-home.component';
import { TrackingResultsComponent } from './components/tracking/tracking-results/tracking-results.component';
import { PagoComponent } from './components/pago/pago.component';

const routes: Routes = [
  
  {path:'',component:GoogleMapComponent},
  {path: '', pathMatch: 'full', redirectTo : 'home'},
  {path:'',component:MainLayoutComponent,children:[
    {path:'home',component:HomeComponent},
    {path:'login',component:LoginComponent},
    {path:'ingresarPaquete', component:IngresarPaqueteComponent},
    {path:'pago', component:PagoComponent},
  ]},

  {path:'deta',component:DetalleTrackingComponent},
  {path:'',component:TrackingLayoutComponent, children:[
    {path:'tracking-home',component:TrackingHomeComponent},
    {path:'tracking-results',component:TrackingResultsComponent},
    
  ]},
  {path: '**', pathMatch: 'full', redirectTo : 'home'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

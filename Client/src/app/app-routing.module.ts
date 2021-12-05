import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { MainLayoutComponent } from './components/layouts/main-layout/main-layout.component';
import { TrackingLayoutComponent } from './components/layouts/tracking-layout/tracking-layout.component';
import { LoginComponent } from './components/login/login.component';
import { IngresarPaqueteComponent } from './components/paquete/ingresar-paquete/ingresar-paquete.component';
import { TrackingHomeComponent } from './components/tracking/tracking-home/tracking-home.component';
import { TrackingResultsComponent } from './components/tracking/tracking-results/tracking-results.component';
import { PagoComponent } from './components/pago/pago.component';
import { ClientAddComponent } from './components/client-add/client-add.component';
import { ListarPaquetesComponent } from './components/paquete/listar-paquetes/listar-paquetes.component';

const routes: Routes = [
  {path: '', pathMatch: 'full', redirectTo : 'home'},
  {path:'',component:MainLayoutComponent,children:[
    {path:'home',component:HomeComponent},
    {path:'login',component:LoginComponent},
    {path:'ingresarPaquete', component:IngresarPaqueteComponent},
    {path:'listarPaquetes', component:ListarPaquetesComponent},
    {path:'pago', component:PagoComponent},
    {path:'agregarCliente', component:ClientAddComponent},
  ]},

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

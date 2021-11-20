
import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ClientDetalleComponent } from './components/client/client-detalle/client-detalle.component';
import { LoginComponent } from './components/login/login.component';

export const ROUTES: Routes = [
    {path: 'home', component: HomeComponent},
    {path: 'client/:id', component: ClientDetalleComponent},
    {path: 'login', component: LoginComponent},
    {path: '', pathMatch: 'full', redirectTo : 'home'},
    {path: '**', pathMatch: 'full', redirectTo : 'home'}
];
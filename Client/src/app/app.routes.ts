
import { Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ClientDetalleComponent } from './components/client/client-detalle/client-detalle.component';

export const ROUTES: Routes = [
    {path: 'home', component: HomeComponent},
    {path: 'client/:id', component: ClientDetalleComponent},
    {path: '', pathMatch: 'full', redirectTo : 'home'},
    {path: '**', pathMatch: 'full', redirectTo : 'home'}
];
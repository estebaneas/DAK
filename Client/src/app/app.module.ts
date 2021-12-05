import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';


import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

//Componentes
import { TrackingLayoutComponent } from './components/layouts/tracking-layout/tracking-layout.component';
import { TrackingHomeComponent } from './components/tracking/tracking-home/tracking-home.component';
import { TrackingHeaderComponent } from './components/tracking/tracking-header/tracking-header.component';
import { TrackingFooterComponent } from './components/tracking/tracking-footer/tracking-footer.component';
import { TrackingResultsComponent } from './components/tracking/tracking-results/tracking-results.component';
import { HomeComponent } from './components/home/home.component';
import { MainLayoutComponent } from './components/layouts/main-layout/main-layout.component';
import { LoginComponent } from './components/login/login.component';
import { IngresarPaqueteComponent } from './components/paquete/ingresar-paquete/ingresar-paquete.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { LoginLayoutComponent } from './components/layouts/login-layout/login-layout.component';
import { LoadingComponent } from './components/shared/loading/loading.component';
import { SearchTrackingComponent } from './components/tracking/search-tracking/search-tracking.component';
import { DetalleTrackingComponent } from './components/modales/detalle-tracking/detalle-tracking.component';
import { MatDialogModule } from '@angular/material/dialog';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CommonModule } from '@angular/common';
import { ErrorComponent } from './components/modales/error/error.component';
import { PagoComponent } from './components/pago/pago.component';

//Angular Material
import { MatSliderModule } from '@angular/material/slider';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatFormFieldModule } from '@angular/material/form-field'
// import { MatFormField } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { ClientAddComponent } from './components/client-add/client-add.component';
import { GoogleMapComponent } from './components/shared/google-map/google-map.component';

import { ListarPaquetesComponent } from './components/paquete/listar-paquetes/listar-paquetes.component';
import { EstadoPaquetePipe } from './components/pipes/estado-paquete.pipe';
import { TamanoPaquetePipe } from './components/pipes/tamano-paquete.pipe';
import { EstadoPaqueteStylePipe } from './components/pipes/estado-paquete-style.pipe';


@NgModule({
  declarations: [
    AppComponent,
    TrackingLayoutComponent,
    TrackingHomeComponent,
    TrackingHeaderComponent,
    TrackingFooterComponent,
    TrackingResultsComponent,
    HomeComponent,
    MainLayoutComponent,
    LoginComponent,
    IngresarPaqueteComponent,
    NavbarComponent,
    FooterComponent,
    LoginLayoutComponent,
    LoadingComponent,
    SearchTrackingComponent,
    DetalleTrackingComponent,
    ErrorComponent, 
    PagoComponent,
    ClientAddComponent,
    GoogleMapComponent,
    ListarPaquetesComponent,
    EstadoPaquetePipe,
    TamanoPaquetePipe,
    EstadoPaqueteStylePipe,


  ],
  imports: [
    CommonModule,
    MatDialogModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    RouterModule,
    NoopAnimationsModule,
    MatSliderModule,
    MatAutocompleteModule,
    MatFormFieldModule,
    // MatFormField,
    MatInputModule,
    BrowserAnimationsModule,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

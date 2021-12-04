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
import { GoogleMapsComponent } from './components/shared/google-maps/google-maps.component';

//Angular Material
import { MatSliderModule } from '@angular/material/slider';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatFormFieldModule } from '@angular/material/form-field'
// import { MatFormField } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';


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
    GoogleMapsComponent
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
    MatInputModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

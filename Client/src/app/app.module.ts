import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
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
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
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
    LoadingComponent
  ],
  imports: [
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    RouterModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

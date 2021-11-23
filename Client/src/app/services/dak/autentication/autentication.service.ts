import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AutenticationService {

  constructor() { }

  verficiarCliente(user:string, pass:string)
  {

    if(user == "admin" && pass == "1234")
    {
      this.login();
    }
    else
    {
      this.logOut();
    }
  }

  login()
  {
    localStorage.setItem("login", "logueado")
  }

  logOut(){
    localStorage.setItem("login", "no logueado")
  }
}

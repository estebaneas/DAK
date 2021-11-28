import { Component, OnInit } from '@angular/core';
import { FormControl, FormControlName, FormGroup, Validators } from '@angular/forms';
import { AutenticationService } from '../../services/dak/autentication/autentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  constructor(private auth: AutenticationService)
  {

  }
  formLogin = new FormGroup(
    {
      user: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required])
    }
  )

  login(values:any)
  {
    console.log(values);
    this.auth.verficiarCliente(this.formLogin.value['user'], this.formLogin.value['password']);
  }

  //#region Validaciones
  get user()
  {
    return this.formLogin.get('user');
  }

  get password()
  {
    return this.formLogin.get('password');
  }
  //#endregion

}

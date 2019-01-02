import { Component, OnInit } from '@angular/core';
import {login} from '../login/login';
import {LoginService} from '../login.service';
import { first } from 'rxjs/operators';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers:[LoginService]
})
export class LoginComponent implements OnInit {
Logcredentials:login;
  constructor(private service:LoginService, private route:Router) { 
    this.Logcredentials = new login();
  }

  ngOnInit() {
    if(localStorage.getItem("IsLoggedIn")!="true")
    {
      this.route.navigate(['/login']);
    }
  }

 //** methods validates user
login(credentails:login)
{
  this.service.login(credentails).pipe(first()).subscribe(data => {
    console.log(data);
    var IsLogin= data.IsLogin;
    var Message = data.Message;
    if(IsLogin==true && Message=="User Exists")
    {
      localStorage.setItem("IsLoggedIn","true");
      this.route.navigate(['/products']);
    }    
  });
}
}

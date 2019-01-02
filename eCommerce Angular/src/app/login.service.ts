import { Injectable } from '@angular/core';
import {login} from '../app/login/login';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class LoginService {
url:any="http://localhost:49973";
  constructor(private http:HttpClient) { }
   
  //** methods validates user by interacting API
  login(credentials:login)
  {
    return this.http.post<any>(this.url+"/api/eCommerce/Login",credentials)
        .pipe(map(Response => {
            return Response;
        }));
  }
}

import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import {Vendor} from '../app/Vendor';
import {Order} from '../app/products/Order';
@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  url:any="http://localhost:49973";
vendors:Vendor;
  constructor(private http:HttpClient) { }
  //  ** methods returns list of products by selected user Vendor // Currently not using this
  // GetProductsbyVendor(vendor:Vendor)
  // {
  //   return this.http.post<any>(this.url+"/api/eCommerce/GetProductsbyVendor",vendor)
  //   .pipe(map(Response => {
  //       return Response;
  //   }));
  // }

  //** methods returns list of products by all users
  GetProductsbyAllVendors()
  {
    return this.http.get<any>(this.url+"/api/eCommerce/GetProductsbyAllVendors")
    .pipe(map(Response => {
        return Response;
    }));
  }
//** methods save order
  Order(order:Order)
  {
    return this.http.post<any>(this.url+"/api/eCommerce/ConfirmOrder",order)
      .pipe(map(Response => {
          return Response;
      }));
  }
  
}

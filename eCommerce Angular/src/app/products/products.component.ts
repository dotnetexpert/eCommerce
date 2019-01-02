import { Component, OnInit } from '@angular/core';
import {Products} from '../products/products';
import {ProductsService} from '../products.service';
import { first } from 'rxjs/operators';
import { Router } from '@angular/router';
import {Vendor} from '../Vendor';
import {Order} from '../products/Order';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  productlist:Products[];
  vendors:Vendor;
  constructor(private service:ProductsService, private route:Router) { }

  ngOnInit() {
    // returns list of products of all vendor
    this.service.GetProductsbyAllVendors().pipe(first()).subscribe(data => {
      this.productlist=data;
      console.log(this.productlist);
    });
  }

confirmOrder(order:Order)
{
  this.service.Order(order).pipe(first()).subscribe(data => {
        this.route.navigate(['/confirm'])
      });
}

  logout()
{
  localStorage.setItem("IsLoggedIn","false");
  this.route.navigate(['/login']);
}
   //** methods returns list of products of selected vendor
// getproducts(vendor:Vendor)
// {
//   debugger
//   this.service.GetProductsbyVendor(vendor).pipe(first()).subscribe(data => {
//     this.productlist=data;
//     console.log(this.productlist);
//   });
// }

 //** methods to logout current user

}

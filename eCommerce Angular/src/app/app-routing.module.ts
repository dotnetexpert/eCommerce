import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from '../app/login/login.component';
import {ProductsComponent} from '../app/products/products.component';
import {ConfirmationComponent} from '../app/confirmation/confirmation.component';
const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'confirm', component: ConfirmationComponent },
  { path: '**', redirectTo: 'login' }
];
@NgModule({
  exports:[RouterModule],
  imports: [ RouterModule.forRoot(routes) ],
})

export class AppRoutingModule { }

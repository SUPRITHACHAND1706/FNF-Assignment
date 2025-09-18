import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Components/login-component/login-component';
import { Signup } from './Components/signup/signup';
import { FoodList } from './Components/food-list/food-list';
import { Checkout } from './Components/checkout/checkout';


const routes: Routes = [
  {path:'',redirectTo : '/signup', pathMatch: 'full'},
  {path:'signup',component:Signup},
  {path:'login',component: LoginComponent},
  {path:'food-list',component:FoodList},
  {path:'checkout',component:Checkout}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

 }

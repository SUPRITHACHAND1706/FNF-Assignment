import { NgModule, provideBrowserGlobalErrorListeners, provideZonelessChangeDetection } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Signup } from './Components/signup/signup';
import { FilterPipe } from './filter-pipe';
import { FoodList } from './Components/food-list/food-list';
import { RestaurantList } from './Components/restaurant-list/restaurant-list';
import { Checkout } from './Components/checkout/checkout';
import { LoginComponent } from './Components/login-component/login-component';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import {  HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    App,
    Signup,
    FoodList,
    RestaurantList,
    Checkout,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule,
    FilterPipe,
    HttpClientModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection()
  ],
  bootstrap: [App]
})
export class AppModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ]
})
export class CartItemModule { 
  foodName: string = '';
  restaurantName: string = '';
  price: number= 0;
  quantity: number=0;
}

// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class Cart {
  
// }


import { Injectable } from '@angular/core';

export interface CartItem {

  foodName: string;

  restaurantName: string;

  price: number;

  quantity: number;

}

@Injectable({

  providedIn: 'root'

})

export class Cart {
  reduce(arg0: (sum: any, item: any) => any, arg1: number): number {
    throw new Error('Method not implemented.');
  }
  getTotalAmount(): number {
    throw new Error('Method not implemented.');
  }

  addCartItem(item: CartItem) {

    const cart: CartItem[] = JSON.parse(localStorage.getItem('cart') || '[]');

    cart.push(item);

    localStorage.setItem('cart', JSON.stringify(cart));

  }

  getCartItems(): CartItem[] {

    return JSON.parse(localStorage.getItem('cart') || '[]');

  }

  clearCart() {

    localStorage.removeItem('cart');

  }

}
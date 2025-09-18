// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-checkout',
//   standalone: false,
//   templateUrl: './checkout.html',
//   styleUrl: './checkout.css'
// })
// export class Checkout {

// }

import { Component } from '@angular/core';
import { Cart } from '../../Services/cart';

import { HttpClient } from '@angular/common/http';

@Component({

  selector: 'app-checkout',

  standalone: false,

  templateUrl: './checkout.html',

  styleUrls: ['./checkout.css']

})

export class Checkout {
  address: string = '';
  paymentMethod: string = '';
  totalAmount: number = 0;
  orderMessage: string = '';
  calculateTotal: any;
  cartItems: import("c:/Users/6152776/Desktop/Training/Angular/FoodApp/FoodApp/src/app/Services/cart").CartItem[];

  // constructor(private http: HttpClient) {}
  constructor(private cartService: Cart, private http: HttpClient) {
    ngOnInit()
    {
      this.cartItems = JSON.parse(localStorage.getItem('cart') || '[]');
      this.calculateTotal();
    }

    
    this.calculateTotal() 
    {
      this.totalAmount=this.cartService.getCartItems().reduce((sum:number, item:any) => sum + item.price * item.quantity, 0);
    }
  }
  

  checkout() {

    const cart = JSON.parse(localStorage.getItem('cart') || '[]');

    const user = JSON.parse(localStorage.getItem('currentUser') || '{}');

    const order = {

      userId: user.id,

      items: cart,

      dateTime: new Date().toISOString(),

      totalAmount: cart.reduce((sum: number, item: any) => sum + item.price * item.quantity, 0)

    };

    this.http.post('http://localhost:5196/api/Order', order).subscribe(

      () => {

        alert('Order placed successfully!');

        localStorage.removeItem('cart'); // Optional, to clear cart after checkout

      },

      error => {
        alert('Error placing order');
      }
    );
  }
}


function ngOnInit() {
  throw new Error('Function not implemented.');
}


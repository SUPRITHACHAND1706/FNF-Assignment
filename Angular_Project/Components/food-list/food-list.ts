import { Component } from '@angular/core';
import { RESTAURANTS } from '../../Models/cart-item/restaurants.data';

interface CartItem {
  name: string;
  price: number;
  quantity: number;
}

@Component({
  selector: 'app-food-list',
  standalone: false,
  templateUrl: './food-list.html',
  styleUrls: ['./food-list.css']
})
export class FoodList {
  restaurants = RESTAURANTS;
  cart: CartItem[] = [];
  total: number = 0;

  constructor() {
    // Load cart from localStorage if it exists
    const cartData = localStorage.getItem('cart');
    this.cart = cartData ? JSON.parse(cartData) : [];
    this.calculateTotal();
  }

  addToCart(item: CartItem) {
    let found = false;
    for (let cartItem of this.cart) {
      if (cartItem.name === item.name) {
        cartItem.quantity += item.quantity;
        found = true;
        break;
      }
    }
    if (!found) {
      this.cart.push({ ...item });
    }
    localStorage.setItem('cart', JSON.stringify(this.cart));
    this.calculateTotal();
  }

  removeFromCart(name: string) {
    this.cart = this.cart.filter(item => item.name !== name);
    localStorage.setItem('cart', JSON.stringify(this.cart));
    this.calculateTotal();
  }

  calculateTotal() {
    this.total = this.cart.reduce((sum, item) => sum + item.price * item.quantity, 0);
  }

  clearCart() {
    this.cart = [];
    localStorage.removeItem('cart');
    this.total = 0;
  }
}

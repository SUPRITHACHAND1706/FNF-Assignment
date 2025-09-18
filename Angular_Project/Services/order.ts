import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class Order {
  private apiUrl = "http://localhost:5196/api/Order";
  constructor(private http:HttpClient) { }

  createOrder(orderData: any) {
    return this.http.post(`${this.apiUrl}/orders`, orderData);
  }

  getOrdersByUser(userId: string) {
    return this.http.get(`${this.apiUrl}/orders?userId=${userId}`);
  }
  getOrderDetails(orderId: string) {
    return this.http.get(`${this.apiUrl}/orders/${orderId}`);
  }
  cancelOrder(orderId: string) {
    return this.http.delete(`${this.apiUrl}/orders/${orderId}`);
  }
  updateOrderStatus(orderId: string, status: string) {
    return this.http.put(`${this.apiUrl}/orders/${orderId}`, { status });
  }
}

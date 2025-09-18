import { Component } from '@angular/core';
import { Router } from '@angular/router';
interface User {
  id: number;
  username: string;
  address: string;
  password: string;
}

@Component({
  selector: 'app-login-component',
  standalone: false,
  templateUrl: './login-component.html',
  styleUrl: './login-component.css'
})


export class LoginComponent {
  
  username: string = '';
  password: string = '';
  address: string = '';
  router: any;

  login() {
    const users:User[] = JSON.parse(localStorage.getItem('users') || '[]');
    const user = users.find((t: User) => t.username === this.username && t.password === this.password);

    if (user) {
      localStorage.setItem('currentUser', JSON.stringify(user));
      this.address = user.address; // Show address and allow change
      alert('Login successful!');
      this.router.navigate(['/food-list']); // Navigate to food list after login

    } else {
      alert('Invalid credentials!');
    }
  }

  changeAddress(newAddress: string) {

    let user = JSON.parse(localStorage.getItem('currentUser') || '{}');

    user.address = newAddress;

    localStorage.setItem('currentUser', JSON.stringify(user));

    const users = JSON.parse(localStorage.getItem('users') || '[]');

    const idx = users.findIndex((u:User) => u.id === users.id);

    if (idx !== -1) {

      users[idx].address = newAddress;

      localStorage.setItem('users', JSON.stringify(users));

      this.address = newAddress;

      alert('Address updated!');

    }
  }

}


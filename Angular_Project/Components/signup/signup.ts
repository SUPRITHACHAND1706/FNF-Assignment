import { Component } from '@angular/core';

@Component({
  selector: 'app-signup',
  standalone: false,
  templateUrl: './signup.html',
  styleUrl: './signup.css'
})
export class Signup {
  username: string = '';
  address: string = '';
  password: string = '';
  successMessage: string = '';
  router: any;

  signup() {
    const users = JSON.parse(localStorage.getItem('users') || '[]');
    const id = Date.now(); // auto-generated ID
    users.push({ id, username: this.username, address: this.address, password: this.password });
    localStorage.setItem('users', JSON.stringify(users));
    // Optionally reset form after signup
    this.username = '';
    this.address = '';
    this.password = '';
    alert('Signup successful!');
    this.successMessage = 'Signup successful! Please log in.';
    this.router.navigate(['/login']); // Navigate to login after signup
  }
}

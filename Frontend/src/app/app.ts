import { Component, inject, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Ping } from './core/ping';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  private api = inject(Ping);
  msg = signal('');
  ping(){
    this.api.ping().subscribe({
      next: (response) => {
        this.msg.set(response);
      },
      error: (error) => {
        this.msg.set('Ping failed');
      }
    });
  }
  
}

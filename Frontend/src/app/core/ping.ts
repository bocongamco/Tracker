import { Injectable,inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class Ping {
  private http = inject(HttpClient);
  ping(){
    return this.http.get('/api/ping',{ responseType: 'text' });
  }
}

import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Activity } from '../models/activity.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls:['./home.component.css']
})
export class HomeComponent {

  model: Activity = new Activity();
  baseURL: string = "https://localhost:44362/";

  constructor(private http: HttpClient, private router: Router) {
  }


  onSubmit() {
    console.log(this.model);
    const headers = { 'content-type': 'application/json' }
    const body = JSON.stringify(this.model);
    console.log(body);
    this.http.post(this.baseURL + 'api/activity', body, { 'headers': headers });
    this.router.navigateByUrl('/list');
  }
}

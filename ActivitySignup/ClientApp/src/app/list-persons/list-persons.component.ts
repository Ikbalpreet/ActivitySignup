import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Activity } from '../models/activity.model';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './list-persons.component.html'
})
export class ListPersonsComponent {
  public activites: Activity[];
  baseURL: string = "https://localhost:44362/";

  constructor(http: HttpClient) {
    http.get<Activity[]>(this.baseURL + 'api/activity').subscribe(result => {
      this.activites = result;
    }, error => console.error(error));
  }
}


import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Bicycle} from "../models/bicycle.model"

const baseurl = "https://localhost:5019/api/order"

@Injectable({
  providedIn: 'root'
})
export class BicycleService {

  constructor(private http: HttpClient) {  }
  create(data: any): Observable<any> {
    return this.http.post(baseurl, data)
  }
}

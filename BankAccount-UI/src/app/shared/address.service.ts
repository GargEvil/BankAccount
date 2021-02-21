import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Address } from './address.model';
import {  throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AddressService {


  constructor(private http: HttpClient) { }


  formData: Address = new Address();
  readonly baseURL = 'https://localhost:44394/api/address';

  getAllAddresses() {
    return this.http.get(this.baseURL)
      .pipe(
        map((data: Address[]) => {
        return data;
      }), catchError(error => {
        return throwError("Something went wrong!");
      })
      )
  }
}

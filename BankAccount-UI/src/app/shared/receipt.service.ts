import { throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { Receipt } from './receipt.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ReceiptService {

  constructor(private http:HttpClient) { }

  formData:Receipt = new Receipt();
  readonly receiptURL = 'https://localhost:44394/api/receipt/';

  getReceiptService(id:string) {
    return this.http.get(this.receiptURL + id)
      .pipe(
        map((data: Receipt) =>{
          return data;
        }), catchError(error =>{
          return throwError("Something went wrong!");
        })
      )
  }
}

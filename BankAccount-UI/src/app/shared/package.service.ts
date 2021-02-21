import { Package } from './package.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PackageService {

  constructor(private http:HttpClient) { }

  formData:Package = new Package();
  readonly packageURL = 'https://localhost:44394/api/package';

  getAllPackages() {
    return this.http.get(this.packageURL)
    .pipe(
      map((data: Package[])=>{
        return data;
      }), catchError(error => {
        return throwError("Something went wrong!");
      })
    )
  }
}

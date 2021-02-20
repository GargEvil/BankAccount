import { Users } from './users.model';
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http:HttpClient) { }

  formData:Users = new Users();
  readonly baseURL ='https://localhost:44394/api/user'

  postUser(){
    return this.http.post(this.baseURL, this.formData);
  }
}

import { Package } from './../../shared/package.model';
import { PackageService } from './../../shared/package.service';
import { Address } from './../../shared/address.model';
import { AddressService } from './../../shared/address.service';
import { GenderType } from '../../shared/helper/gender-type';
import { UsersService } from './../../shared/users.service';
import { Component, OnInit } from '@angular/core';
import {  NgForm } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-users-form',
  templateUrl: './users-form.component.html',
  styles: [
  ]
})
export class UsersFormComponent implements OnInit {

public genderTypes = Object.values(GenderType).filter(value=> typeof value == 'string');

public phoneNumberPattern = "^(06)\d{7,9}$";

editable=true;

addresses: Address[];

minDate = new Date(1900, 0, 1);
maxDate = new Date(2003, 0, 1);


  constructor(public service:UsersService,
     private addressService:AddressService,
     private router:Router)  { }
  
  ngOnInit(): void {
    this.getAddressList();
  }

  getAddressList(){
    this.addressService
    .getAllAddresses()
    .subscribe((data:any)=>{
      console.log(data);
      this.addresses = data;
    });
  }

 goBack(){
    this.router.navigate(['']);
 }

 goNext(pageName:string):void{
   this.router.navigate([`${pageName}`]);
   
 }
  
  
}

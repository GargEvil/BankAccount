import { Package } from './../../shared/package.model';
import { PackageService } from './../../shared/package.service';
import { Address } from './../../shared/address.model';
import { AddressService } from './../../shared/address.service';
import { GenderType } from '../../shared/helper/gender-type';
import { UsersService } from './../../shared/users.service';
import { Component, OnInit } from '@angular/core';
import {  NgForm } from '@angular/forms';


@Component({
  selector: 'app-users-form',
  templateUrl: './users-form.component.html',
  styles: [
  ]
})
export class UsersFormComponent implements OnInit {

public genderTypes = Object.values(GenderType).filter(value=> typeof value == 'string');

packages: Package[];

addresses: Address[];

minDate = new Date(1900, 0, 1);
maxDate = new Date(2003, 0, 1);


  constructor(public service:UsersService,
     private addressService:AddressService,
     private packageService:PackageService)  { }
  
  ngOnInit(): void {
    this.getAddressList();
    this.getPackageList();
  }

  getAddressList(){
    this.addressService
    .getAllAddresses()
    .subscribe((data:any)=>{
      console.log(data);
      this.addresses = data;
    });
  }

  getPackageList(){
    this.packageService
    .getAllPackages()
    .subscribe((data:any) =>{
      console.log(data);
      this.packages = data;
    })
  }

  onSubmit(form: NgForm){
    this.service.postUser().subscribe(
      res => {
          
          
      },
      err =>{console.log(err);}
    )
    
  }
}

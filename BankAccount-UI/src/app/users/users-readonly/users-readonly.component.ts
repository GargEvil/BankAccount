import { GenderType } from './../../shared/helper/gender-type';
import { Package } from './../../shared/package.model';
import { PackageService } from './../../shared/package.service';
import { AddressService } from './../../shared/address.service';
import { Address } from './../../shared/address.model';
import { UsersService } from './../../shared/users.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-users-readonly',
  templateUrl: './users-readonly.component.html',
  styles: [
  ]
})
export class UsersReadonlyComponent implements OnInit {

  public genderTypes = Object.values(GenderType).filter(value=> typeof value == 'string');

  addresses: Address[];

  packages: Package[];

  editable = false;

  constructor(private route:ActivatedRoute,
    public service:UsersService,
    private addressService:AddressService,
    private packageService:PackageService,
    private router:Router) { }

  ngOnInit(): void {
    console.log(this.route.snapshot.queryParams.data);
    this.getPackageList();
    this.getAddressList();
  }

  clearForm(){
    this.service.formData.firstName='';
    this.service.formData.lastName='';
    this.service.formData.emailAddress='';
    this.service.formData.packageId= null;
    this.service.formData.phoneNumber = '';
    this.service.formData.addressId = null;
    this.service.formData.dateOfBirth = null;
    this.service.formData.gender = null;
    this.service.formData.identificationNumber='';
  }

  getPackageList(){
    this.packageService
    .getAllPackages()
    .subscribe((data:any) =>{
      console.log(data);
      this.packages = data;
    });
  }
  getAddressList(){
      this.addressService
      .getAllAddresses()
      .subscribe((data:any)=>{
        console.log(data);
        this.addresses = data;
      });
  }

  onSubmit(form: NgForm){
    this.service.postUser().subscribe(
      res => {
         
      },
      err =>{console.log(err);}
    )

    this.router.navigate(['']);
    this.clearForm();
  }

  goBack(pageName:string):void{
    this.router.navigate([`${pageName}`])
  }
    

}


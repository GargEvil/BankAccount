import { UsersService } from './../../shared/users.service';
import { Package } from './../../shared/package.model';
import { PackageService } from './../../shared/package.service';
import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-package-form',
  templateUrl: './package-form.component.html',
  styles: [
  ]
})
export class PackageFormComponent implements OnInit {

  
packages: Package[];

editable=true;

  constructor(public service:UsersService,
     public packageService:PackageService,
     public router:Router) { }

  ngOnInit(): void {
    
    this.getPackageList()
  }


  getPackageList(){
    this.packageService
    .getAllPackages()
    .subscribe((data:any) =>{
      console.log(data);
      this.packages = data;
    })
  }

  goToUsers(pageName:string):void{
    this.router.navigate([`${pageName}`])
  }
}

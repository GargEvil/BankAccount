import { UsersService } from './../../shared/users.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-users-form',
  templateUrl: './users-form.component.html',
  styles: [
  ]
})
export class UsersFormComponent implements OnInit {



  constructor(public service:UsersService) { }
  ngOnInit(): void {
  }

  onSubmit(form: NgForm){
    this.service.postUser().subscribe(
      res => {

      },
      err =>{console.log(err);}
    )
  }
}

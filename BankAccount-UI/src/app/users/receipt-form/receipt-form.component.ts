import { ReceiptService } from './../../shared/receipt.service';
import { Receipt } from './../../shared/receipt.model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-receipt-form',
  templateUrl: './receipt-form.component.html',
  styleUrls: ['./receipt-form.component.css']
})
export class ReceiptFormComponent implements OnInit {

  receipt:Receipt;
  id:string;

  constructor(private service:ReceiptService, private route: ActivatedRoute)
  {
      route.paramMap.subscribe(
    (params) => {
      this.id= params.get('id');
    });
  }

  ngOnInit(): void {
    this.getReceipt();
  }

  getReceipt(){
    this.service
    .getReceiptService(this.id)
    .subscribe((data:any) =>{
      this.receipt = data;
    })
  }

}

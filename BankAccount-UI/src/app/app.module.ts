
import { MaterialModule } from './material.module';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { RouterModule, Routes} from '@angular/router';

import { AppComponent } from './app.component';
import { UsersComponent } from './users/users.component';
import { UsersFormComponent } from './users/users-form/users-form.component';
import { PackageFormComponent } from './package/package-form/package-form.component';
import { UsersReadonlyComponent } from './users/users-readonly/users-readonly.component';
import { ReceiptFormComponent } from './users/receipt-form/receipt-form.component';

const routes:Routes = [
  {
    path: '', component:PackageFormComponent
  },

{
  path:'users/users-form', component: UsersFormComponent
},
{
  path:'users', component: UsersComponent
},
{
  path:'readonly', component: UsersReadonlyComponent
},
{
  path:'receipt/:id', component: ReceiptFormComponent 
}
];

@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    UsersFormComponent,
    PackageFormComponent,
    UsersReadonlyComponent,
    ReceiptFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    MaterialModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

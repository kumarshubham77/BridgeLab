import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminloginComponent } from './adminlogin/adminlogin.component';
import { AdminopComponent } from './adminop/adminop.component';
import { AddclientComponent } from './addclient/addclient.component';


const routes: Routes = [
  {
    path: 'adminlogin',
    component: AdminloginComponent
  },
  {
    path: 'adminoperation',
    component: AdminopComponent
  },
  {
    path: 'addclient',
    component: AddclientComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

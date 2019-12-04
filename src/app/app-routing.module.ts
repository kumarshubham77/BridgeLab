import { NgModule } from '@angular/core';
import { RegistrationComponent } from './Components/registration/registration.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { CardComponent } from './Components/card/card.component';
import { DashboradComponent } from './Components/dashborad/dashborad.component';
import { ForgotComponent } from './Components/forgot/forgot.component';
import { ResetComponent } from './Components/reset/reset.component';


const routes: Routes = [
  {
    path:'', 
    redirectTo:'/card',
    pathMatch:'full'
  },
  {
    path: 'card',
     component :CardComponent
    },
  { 
    path: 'register',
    component: RegistrationComponent 
  },  
  { 
    path:'login', 
    component: LoginComponent
  },  
  {
    path: 'dashboard', 
    component :DashboradComponent
  },
  {
    path: 'forgot',
    component :ForgotComponent
  },
  {
    path: 'reset',
    component :ResetComponent
  }
  
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

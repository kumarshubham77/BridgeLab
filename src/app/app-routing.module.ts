import { NgModule } from '@angular/core';
import { RegistrationComponent } from './Components/registration/registration.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { CardComponent } from './Components/card/card.component';
import { DashboradComponent } from './Components/dashborad/dashborad.component';

const routes: Routes = [
  { path: 'register', component: RegistrationComponent },
  { path : '', component: LoginComponent},
  {path: 'card', component :CardComponent},
  {path: 'dashboard', component :DashboradComponent}
  
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

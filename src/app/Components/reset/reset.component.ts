import { Component, OnInit } from '@angular/core';
import { UserServiceService } from 'src/app/user-service.service';
import { FormGroup, Validators, FormControl } from '@angular/forms';

@Component({
  selector: 'app-reset',
  templateUrl: './reset.component.html',
  styleUrls: ['./reset.component.scss']
})
export class ResetComponent implements OnInit {
  resetUser: FormGroup; 
  token=JSON.parse(localStorage.getItem('userData'));

  constructor(private userService : UserServiceService) { }

  ngOnInit() {
    this.resetUser = new FormGroup({ 
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
      confirm: new FormControl('', [Validators.required])});
  }
  onclick()
  {
    console.log("password-->",this.resetUser.controls.password.value);
    console.log("confirm password-->",this.resetUser.controls.confirm.value); 
    if(this.resetUser.controls.password.value === this.resetUser.controls.confirm.value)
    {
     
      const data = 
      {
        "Password" : this.resetUser.controls.password.value,
      }
      this.userService.reset(data,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);});
     
    }
  }

}

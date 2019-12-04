import { Component, OnInit } from '@angular/core';
import { NgForm, FormControl, FormGroup, Validators } from '@angular/forms';
import { UserServiceService } from 'src/app/user-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-forgot',
  templateUrl: './forgot.component.html',
  styleUrls: ['./forgot.component.scss']
})
export class ForgotComponent implements OnInit {
  forgotUser:FormGroup;
  form: NgForm;
  name = new FormControl('');

  constructor(private userService : UserServiceService, private router : Router) { }

  ngOnInit() {
    this.forgotUser = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
    })
  }
  onclick()
  {
    console.log('data',this.forgotUser.value);
    var d=this.forgotUser.value;
    this.userService.forgot(d).subscribe((data:any)=>{
    localStorage.setItem('userData', JSON.stringify(data));
    this.router.navigate(['/reset']);
    })
  }

}

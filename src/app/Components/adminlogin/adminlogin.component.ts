import { Component, OnInit } from '@angular/core';
import { FormGroup, NgForm, FormControl, Validators } from '@angular/forms';
import { AdminService } from 'src/app/services/admin.service';
import { MatSnackBar } from '@angular/material';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adminlogin',
  templateUrl: './adminlogin.component.html',
  styleUrls: ['./adminlogin.component.scss']
})
export class AdminloginComponent implements OnInit {
  loginUser:FormGroup;
  form: NgForm;
  name = new FormControl('');

  constructor(private adminservice : AdminService,public snackBar: MatSnackBar,  private router: Router) { }

  ngOnInit() {
    this.loginUser = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
  })
  }
  onSubmit()
  { 
    console.log('dataa',this.loginUser.value);
    // var d=this.loginUser.value;
    this.adminservice.login(this.loginUser.value).subscribe((data:any)=>{
    localStorage.setItem('userData', JSON.stringify(data));
    this.router.navigate(['/adminuserdetails']);
    })
  }


}

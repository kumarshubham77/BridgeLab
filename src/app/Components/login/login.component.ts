import { Component, OnInit } from '@angular/core';
import { UserServiceService } from 'src/app/user-service.service';
import { FormControl, FormGroup, Validators, NgForm } from '@angular/forms';
import { MatSnackBar } from '@angular/material';
import { Router } from '@angular/router';
import {AuthService,SocialUser,GoogleLoginProvider, FacebookLoginProvider}from 'angular-6-social-login';

@Component({
  
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  public user: any = SocialUser;
loginUser:FormGroup;
form: NgForm;
name = new FormControl('');
  constructor(private userService : UserServiceService ,public snackBar: MatSnackBar,  private router: Router,private socialAuthService : AuthService) { }

  ngOnInit() {
    this.loginUser = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
  })
  }
  onSubmit()
  { 
    console.log('dataa',this.loginUser.value);
    var d=this.loginUser.value;
    this.userService.login(d).subscribe((data:any)=>{
    localStorage.setItem('userData', JSON.stringify(data));
    this.router.navigate(['/dashboard']);
    })
  }
  onFacebook()
  {
    let socialPlatformProvider;
    socialPlatformProvider = FacebookLoginProvider.PROVIDER_ID;
    this.socialAuthService.signIn(socialPlatformProvider).then((userData) => {
      this.userService.facebook(userData.email).subscribe((data: any) => {
        localStorage.setItem('userData', JSON.stringify(data));
        this.router.navigate(['/dashboard']);
      })
    })
  }
  onGoogle()
  { 
    let socialPlatformProvider;
    socialPlatformProvider = GoogleLoginProvider.PROVIDER_ID;
    this.socialAuthService.signIn(socialPlatformProvider).then((userData) => {
      this.userService.google(userData.email).subscribe((data: any) => {
        localStorage.setItem('userData', JSON.stringify(data));
        this.router.navigate(['/dashboard']);
      });
    });
  }
} 

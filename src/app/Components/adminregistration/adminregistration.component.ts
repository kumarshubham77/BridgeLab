import { Component, OnInit } from '@angular/core';
import { FormGroup, NgForm, FormControl, Validators } from '@angular/forms';
import { AdminService } from 'src/app/services/admin.service';
import { MatSnackBar } from '@angular/material';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adminregistration',
  templateUrl: './adminregistration.component.html',
  styleUrls: ['./adminregistration.component.scss']
})
export class AdminregistrationComponent implements OnInit {
  register: FormGroup;
  service:string;  
  form: NgForm;

  constructor(private adminservice : AdminService,public snackBar:MatSnackBar,private route:Router) { }

  ngOnInit() {
    this.register = new FormGroup({
      firstName: new FormControl('', [Validators.pattern('^[a-zA-Z]{4,15}'), Validators.required]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{4,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
      
    });
  }
  onSubmit() {
    
      const data = {
        "FirstName":this.register.controls.firstName.value,
        "LastName": this.register.controls.lastName.value,
        "Email" : this.register.controls.email.value,
        // "service":"advance",
        "Password" : this.register.controls.password.value,
        
      }
      this.adminservice.registerUser(data).subscribe( response => {
        console.log('dataa from back end',response);
        this.route.navigateByUrl('/adminlogin');
        this.snackBar.open("Registration successfull....."," ",{duration : 2000});   

      },error => {
        console.log("error in register",error);  
        this.snackBar.open("Registration fail....."," ",{duration : 2000});   
      });
    }
    
  }




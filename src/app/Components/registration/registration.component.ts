import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { UserServiceService } from 'src/app/user-service.service';
import { Router } from '@angular/router';
import { MatSnackBar} from '@angular/material/snack-bar';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {

  register: FormGroup;
  service:string;  
  form: NgForm;
  cardtype=JSON.parse(localStorage.getItem('userData'));
  constructor(private userService : UserServiceService,public snackBar:MatSnackBar,private route:Router) { }

  ngOnInit() {
    this.service = localStorage.getItem('serviceName');
    console.log("service-->",this.service);   
    this.register = new FormGroup({
      firstName: new FormControl('', [Validators.pattern('^[a-zA-Z]{4,15}'), Validators.required]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{4,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
      confirmPassword: new FormControl('', [Validators.required])
    });
  }

  onSubmit() {
    try{
      console.log("Password--->",this.register.controls.password.value);
      console.log("Confirm Password--->",this.register.controls.confirmPassword.value);
      if(this.register.controls.password.value===this.register.controls.confirmPassword.value)
      {
      const data = {
        "FirstName":this.register.controls.firstName.value,
        "LastName": this.register.controls.lastName.value,
        "Email" : this.register.controls.email.value,
        // "service":"advance",
        "Password" : this.register.controls.password.value
      }
      this.userService.registerUser(data).subscribe( response => {
        console.log('dataa from back end',response);
        this.route.navigateByUrl('/login');
        this.snackBar.open("Registration successfull....."," ",{duration : 2000});   

      },error => {
        console.log("error in register",error);  
        this.snackBar.open("Registration fail....."," ",{duration : 2000});   
      });
    }
    else{
      console.log("error in register");      
      this.snackBar.open("password not matched"," ",{duration : 2000});   

    }
    }catch(err){
      console.log("error",err)
      this.snackBar.open("Registration fail....."," ",{duration : 2000});   
    }    
  }

  onService()
  {
    this.route.navigate(['/card']);    
  }
  
  // CardComponent(event) {
  //   this.card = event
  //   console.log("event",event);
    
  // }
}

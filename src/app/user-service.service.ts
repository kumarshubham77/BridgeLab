import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { ForgotComponent } from './Components/forgot/forgot.component';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {
  readonly rootUrl = 'https://localhost:44338/api/Account';

  constructor(private http: HttpClient) { }
  registerUser(userData)
  {
    const url = 'user/userSignUp';   // register url
    console.log('data userservice', userData)
    // return this.httpService.post('user/userSignUp', userData);
    return this.http.post(this.rootUrl + '/Add', userData);
  }
  login(userData)
  {
    return this.http.post(this.rootUrl + '/LogIn', userData);
  }
  google(user) {
    const body = {
      Email: user
    };
    console.log('data in user service', user);
    return this.http.post(this.rootUrl + '/LoginWithGoogle', body);
  }
  facebook(user) {
    const body = {
      Email: user
    };
    console.log('data in user service', user);
    return this.http.post(this.rootUrl + '/LoginWithFacebook', body);
  }
  forgot(userData)
  {
    console.log("Some message to Verify");
    return this.http.post(this.rootUrl + '/Forgot', userData);
  }
  reset(user,token)
  {
    const data = 
      {
        
        "NewPassword" : user.Password
      }
    return this.http.post(this.rootUrl + '/Reset',data,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) } );
  }
  card(user)
  {
    const data = 
      {  
        "CardType" : user.Card
      }
  }
  getUserdata(token)
  {
    return this.http.get(this.rootUrl + '/jwtgetToken',{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) } );
  }
}


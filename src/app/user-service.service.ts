import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {
  readonly rootUrl = 'https://localhost:44338/api/Account';

  constructor(private http: HttpClient) { }
  registerUser(userData){
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
}

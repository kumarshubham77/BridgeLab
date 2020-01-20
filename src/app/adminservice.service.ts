import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class AdminserviceService {
  // readonly rootUrl = 'https://localhost:44338/api/Account';
  // Give Your Backend Api here

  constructor(private http: HttpClient) { }
  registerClient(userData)
  {
    const url = 'user/userSignUp';   // register url
    console.log('data userservice', userData)
    // After connecting your API above Uncomment the below Section
    // return this.http.post(this.rootUrl + '/Add', userData);
  }
  
}

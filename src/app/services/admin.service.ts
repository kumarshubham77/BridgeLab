import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  baseUrl = environment.baseUrl4;

  constructor(private http: HttpClient) { }

  login(userData)
  {
    return this.http.post(this.baseUrl + '/Login?Email='+userData.email+'&Password='+userData.password,"");
  }
  registerUser(userData)
  {
       // register url
    
    // return this.httpService.post('user/userSignUp', userData);
    return this.http.post(this.baseUrl + '/AddAdmin', userData);
  }
  GetUserList()
  {
    return this.http.get(this.baseUrl + '/userdetails');
  }
  GetUserStatistic()
  {
    return this.http.get(this.baseUrl + '/userstatistic');
  }
}

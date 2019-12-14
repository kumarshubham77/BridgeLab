import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient, HttpHeaders  } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LabelService {
  baseUrl = environment.baseUrl3;

  constructor(private http: HttpClient) { }


  createLabel(data,token)
  {
   return this.http.post(this.baseUrl + '/AddLabel',data,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
}

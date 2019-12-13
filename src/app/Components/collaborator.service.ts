import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CollaboratorService {
  baseUrl = environment.baseUrl2;

  constructor(private http: HttpClient) { }

  addCollaborator(data,token)
  {
    console.log("data",token)
    return this.http.post(this.baseUrl + '/AddCollaborator',data,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  RemoveCollaborator(data,token)
  {
    console.log("data",token)
    return this.http.post(this.baseUrl + '/RemoveCollaborator',data,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
}

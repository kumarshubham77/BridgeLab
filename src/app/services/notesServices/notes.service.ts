import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { environment } from '../.././../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class NotesService {

  baseUrl = environment.baseUrl1;
  

  constructor(private http: HttpClient) { }

  createNote(data,token){
   
  return this.http.post(this.baseUrl + '/AddNote',data,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
    }
  displayNote(token)
  {
    return this.http.get(this.baseUrl + '/Show',{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  }

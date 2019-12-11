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
  notesUpdate(ID,title,description,token)
  {
    const data=
    {
      "ID":ID,
      "Title":title,
      "Description":description
    }
    console.log("data",token)
    return this.http.put(this.baseUrl + '/Update',data,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  notesTrash(ID,token)
  {
    console.log("data",token)
    return this.http.post(this.baseUrl + '/Trash?ID='+ID,"",{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  notesArchive(ID,token)
  {
    return this.http.post(this.baseUrl + '/Archive?ID='+ID,"",{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  notesReminder(time,ID,token)
  {
    return this.http.put(this.baseUrl + '/Reminder?ID='+ID+'&Reminder='+time,"",{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  notescolor(color,ID,token)
  {
    const data=
    {
      "Color":color,
      ID:ID
    }
    console.log("color",color)
    return this.http.post(this.baseUrl + '/Color',data,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  displayArchiveNotes(token)
  {
    return this.http.get(this.baseUrl + '/archivelist',{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  displayTrashNotes(token)
  {
    return this.http.get(this.baseUrl + '/trashlist',{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  displayrestoreNotes(token)
  {
    return this.http.get(this.baseUrl + '/restore',{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  deletetrash(ID,token)
  {
    return this.http.delete(this.baseUrl + '/DeleteElementByID?ID='+ID,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  restorenotes(ID,token)
  {
    return this.http.post(this.baseUrl + '/UnTrash?ID='+ID," ",{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  deleteNotePermanent(ID,token)
  {
    return this.http.delete(this.baseUrl + '/DeleteElementByID?='+ID,{ headers:new HttpHeaders().set('Authorization', 'Bearer ' + token)})
  }
  notesUnArchive(ID,token)
  {
    return this.http.post(this.baseUrl + '/UnArchive?ID='+ID,"",{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  removereminder(id,token)
  {
    return this.http.post(this.baseUrl + '/RemoveReminder?ID='+id,"",{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  // notesDelete(token)
  // {
  //   const data=
  //   {
  //     "Title":title
  //   }
  //   return this.http.delete(this.baseUrl + '/Delete',{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  // }

  
  }

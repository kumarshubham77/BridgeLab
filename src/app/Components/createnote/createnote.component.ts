import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';

@Component({
  selector: 'app-createnote',
  templateUrl: './createnote.component.html',
  styleUrls: ['./createnote.component.scss']
})
export class CreatenoteComponent implements OnInit {
  token=JSON.parse(localStorage.getItem('userData'));
  title:string;
  description:string;

  constructor(private notesService: NotesService) { }

  ngOnInit() {
  }

  createNote(){
    try{
      let data = {

        "Title": this.title,
        "Description" : this.description
      }
      console.log("data-->",data);

      this.notesService.createNote(data,this.token.result).subscribe( response => {
        console.log('dataa from back end',response);
       

      },error => {
        console.log("error in register",error);  
       
      });
      
      


      
    }catch(err){
      console.log("error in create note",err)
    }
  }

}

import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {

  token=JSON.parse(localStorage.getItem('userData'));

  allNotes=[];

  constructor(private notesService: NotesService) { }

  ngOnInit() {
   this.getAllNOtes();
  }

  /**
   * @description this method will get all notes data
   */
  getAllNOtes()
  {
    try{      
      this.notesService.displayNote(this.token.result).subscribe( (response:any) => {
        console.log('all notes data from back end',response); 
        this.allNotes = response;
      },error => {
        console.log("Error while Displaying Notes",error);  
       
      });
    }catch(err){
      console.log("Error while Displaying Notes",err)
    }
  }


}

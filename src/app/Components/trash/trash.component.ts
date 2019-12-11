import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';

@Component({
  selector: 'app-trash',
  templateUrl: './trash.component.html',
  styleUrls: ['./trash.component.scss']
})
export class TrashComponent implements OnInit {
  
  notes=[];
  trashNotes=[];
  token=JSON.parse(localStorage.getItem('userData'));
  constructor(private notesService: NotesService) { }

  ngOnInit() {
    this.getAllTrashNotes();
  }

  getAllTrashNotes(){
    try{
      this.notesService.displayNote(this.token.result).subscribe( (response:any) => {       
        this.notes = response;
        this.notes.forEach(element => {
          if(element.isTrash == true && element.isArchive == false){
            this.trashNotes.push(element);
          }
        })
        console.log('all trash notes data---->',this.trashNotes); 
      },error => {
        console.log("Error while get trash Notes",error);         
      });
    }catch(error){
      console.log("err in get all trash notes",error)
    }
  }

}

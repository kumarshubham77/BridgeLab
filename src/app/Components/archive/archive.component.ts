import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {

  token=JSON.parse(localStorage.getItem('userData'));
  notes=[];
  archiveNotes=[];
  
  constructor(private notesService: NotesService) { }

  ngOnInit() {
    this.getAllArchiveNotes()
  }

  getAllArchiveNotes(){
    try{
      this.notesService.displayNote(this.token.result).subscribe( (response:any) => {       
        this.notes = response;
        this.notes.forEach(element => {
          if(element.isTrash == false && element.isArchive == true ){
            this.archiveNotes.push(element);
          }
        })
        console.log('all trash notes data---->',this.archiveNotes); 
      },error => {
        console.log("Error while get trash Notes",error);         
      });
    }catch(error){
      console.log("err in get all trash notes",error)
    }
  }

  // onClickarchive()
  // {
  //  this.notesService.displayArchiveNotes(this.token.result).subscribe((response:any)=>
  //  { console.log('data from backend',response);
  //   this.allNotes=response;
  //   console.log("list",this.allNotes);
  //  },error => {
  //   console.log("Error while Displaying Notes",error); 
  //   });
  // }

}

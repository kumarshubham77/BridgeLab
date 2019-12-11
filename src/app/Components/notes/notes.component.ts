import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';
import { DataService } from 'src/app/services/dataService/data.service';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {

  token=JSON.parse(localStorage.getItem('userData'));

  allNotes=[];
  notes=[];

  constructor(private notesService: NotesService,
    private dataService: DataService) { }

  ngOnInit() {
    this.dataService.currentMessage.subscribe( data => {
      this.getAllNOtes();
    })
  //  this.getAllNOtes();
  }

  /**
   * @description this method will get all notes data
   */
  getAllNOtes(){
    try{      
      this.allNotes=[];
      this.notesService.displayNote(this.token.result).subscribe( (response:any) => {       
        this.notes = response;
        this.notes.forEach(element => {
          if(element.isTrash == false && element.isArchive == false){
            this.allNotes.push(element);
          }
        })
        console.log('all notes data---->',this.allNotes); 
      },error => {
        console.log("Error while Displaying Notes",error);         
      });
    }catch(err){
      console.log("Error while Displaying Notes",err)
    }
  }


}

import { Component, OnInit } from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';

@Component({
  selector: 'app-reminder',
  templateUrl: './reminder.component.html',
  styleUrls: ['./reminder.component.scss']
})
export class ReminderComponent implements OnInit {
  notes=[];
  reminderNotes=[];
  token=JSON.parse(localStorage.getItem('userData'));

  constructor(private notesService: NotesService) { }

  ngOnInit() {
    this.getAllTrashNotes();
  }
  getAllTrashNotes(){
    try{
      console.log("something is printed");
      
      this.notesService.displayNote(this.token.result).subscribe( (response:any) => {       
        this.notes = response;
        this.notes.forEach(element => {
          if(element.reminder != "" && element.reminder!=null){
            this.reminderNotes.push(element);
          }
        })
        console.log('all trash notes data---->',this.reminderNotes); 
      },error => {
        console.log("Error while get trash Notes",error);         
      });
    }catch(error){
      console.log("err in get all trash notes",error)
    }
  }

}

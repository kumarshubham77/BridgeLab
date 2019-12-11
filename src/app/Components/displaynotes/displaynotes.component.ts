import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { MatDialog } from '@angular/material';
import { EditComponent } from '../edit/edit.component';
import { NotesService } from 'src/app/services/notesServices/notes.service';
// import { EventEmitter } from 'events';

@Component({
  selector: 'app-displaynotes',
  templateUrl: './displaynotes.component.html',
  styleUrls: ['./displaynotes.component.scss']
})
export class DisplaynotesComponent implements OnInit {

  @Input() allNotesData: string;
  @Input() hiddenIcon : boolean;
  @Output() noteEvent = new EventEmitter()
  @Input() card;
  @Output() event = new EventEmitter();
  token=JSON.parse(localStorage.getItem('userData'));
  constructor(public dialog: MatDialog,private notesService: NotesService) { }

  ngOnInit() {
  }
  openDialog(note: any)
  {
    const dialogref=this.dialog.open(EditComponent, {
      panelClass: 'custom-dialog-container' ,
      width:'600px',
      data:{note}
    });
  }

  removeReminder(data){
    try{
    
      this.notesService.removereminder(data.id,this.token.result).subscribe( response => {
        console.log('Reminder Removed.',response);
        this.event.emit([]);
      })

    }catch(error){
      console.log(error);      
    }
  }

  listenEvent(){
    this.noteEvent.emit([]);
  }
}

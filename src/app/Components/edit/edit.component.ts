import { Component, OnInit, Inject} from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { DataService } from 'src/app/services/dataService/data.service';


@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {
  note;
  color:string;
  token=JSON.parse(localStorage.getItem('userData'));
  
  constructor(
    public dialogRef: MatDialogRef<EditComponent>,
    @Inject(MAT_DIALOG_DATA)public data,public dialogref:MatDialogRef<EditComponent>,
    private noteService: NotesService,
    private dataService: DataService) {
    this.note=this.data.note;
    this.color = this.data.note.color;
    console.log("dataNote in edit component-->",this.note)
  }

  ngOnInit() {
  }

  editNote(title, description)
  {
    console.log("data",this.token);
    console.log("note id",this.note.id);
    this.noteService.notesUpdate(this.note.id,title,description,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
     
      this.dialogRef.close();
    })
  }

}

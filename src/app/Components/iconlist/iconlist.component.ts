import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { NotesService } from 'src/app/services/notesServices/notes.service';
import { CollaboratorComponent } from '../collaborator/collaborator.component';
import { MatDialog } from '@angular/material';
import { ImageuploadComponent } from '../imageupload/imageupload.component';
// import { EventEmitter } from 'events';

@Component({
  selector: 'app-iconlist',
  templateUrl: './iconlist.component.html',
  styleUrls: ['./iconlist.component.scss']
})
export class IconlistComponent implements OnInit {
  @Input() card; 
  @Input() hiddenIcon:boolean
  url=localStorage.getItem('ProfileLink');
  email=localStorage.getItem('Email');
  Image=localStorage.getItem('ProfileLink');

  @Output() event = new EventEmitter();
  
  token=JSON.parse(localStorage.getItem('userData'));

  constructor(private notesService: NotesService,public dialog: MatDialog) { }

  ngOnInit() {    
  }


  onDelete()
  {
    console.log("data",this.token);
    console.log("note id",this.card.id);
    this.notesService.notesDelete(this.card.id,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }
  onArchive()
  {
    console.log("data",this.token);
    console.log("note id",this.card.id);
    this.notesService.notesArchive(this.card.id,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }
  onLater()
  {
    var d=new Date();
    d.setHours(20,0,0);
    this.notesService.notesReminder(d.toString(),this.card.id,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }
  onTommorow()
  {
    var d=new Date();
    d.setDate(d.getDate()+1);
    d.setHours(8,0,0);
    this.notesService.notesReminder(d.toString(),this.card.id,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }
 
  onNext()
  {
    var d=new Date();
    d.setDate(d.getDate()+7);
    d.setHours(8,0,0);
    this.notesService.notesReminder(d.toString(),this.card.id,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }
  colorsArr: any[] = [
    { color: "#d7aefb" },
    { color: "#fdcfe8" },
    { color: "#e6c9a8" },
    { color: "#e8eaed" },
    { color: "#ccff90" },
    { color: "#a7ffeb" },
    { color: "#cbf0f8" },
    { color: "#aecbfa" },
    { color: "#fff" },
    { color: "#f28b82" },
    { color: "#fbbc04" },
    { color: "#fff475" }
  ]
  onColor(color:string)
  {
     
    this.notesService.notescolor(color,this.card.id,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
      window.location.reload();
      this.event.emit([]);
    })
  }
  // deleteForever(){
  //   try{
  //     this.notesService.deletetrash(this.card.id,this.token.result).subscribe(response =>
  //     {
  //       console.log('Delted from Backend',response);
  //       this.event.emit([]);
  //     })

  //   }catch(error){
  //     console.log(error);
  //   }
  // }

  restore(){
    try{
      this.notesService.restorenotes(this.card.id,this.token.result).subscribe( response => {
        console.log('notes restore done.',response);
        this.event.emit([]);
      })


    }catch(error){
      console.log(error);
    }
  }
  deleteForever(){
    try{
      this.notesService.deleteNotePermanent(this.card.id,this.token.result).subscribe( response => {
        console.log('Note deleted Parmanently.',response);
        this.event.emit([]);
      })


    }catch(error){
      console.log(error);
    }
  }
  unArchive(){
    try{
      this.notesService.notesUnArchive(this.card.id,this.token.result).subscribe( response => {
        console.log('Note Unarchieved.',response);
        this.event.emit([]);
      })


    }catch(error){
      console.log(error);
    }
  }
  onCollaborator()
  {
    var note=this.card
    console.log("collablist",note)
    const dialogref=this.dialog.open(CollaboratorComponent, {
      data:{note}
      
    });
    this.event.emit([]);

  }
  onImage()
  {
    console.log("note id on Image",this.card.id);
    localStorage.setItem('NOTEIDFORIMG',this.card.id);
    const dialogref = this.dialog.open(ImageuploadComponent, {
    });
    console.log("hghdfkhgkdfhgkdfhgkdfghkdfhgkdh",Image)
  }
  
}
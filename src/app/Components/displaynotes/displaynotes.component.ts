import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { MatDialog } from '@angular/material';
import { EditComponent } from '../edit/edit.component';
import { NotesService } from 'src/app/services/notesServices/notes.service';
import { DataService } from 'src/app/services/dataService/data.service';
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
  @Input() allpinnotess:string;
  list=true;
  // DisplayNotesAllData = this.allNotesData;

  ckeckClicked: number;
  notes=[];
  pinNotes=[];
  unpinnedNotes=[];
  card1:boolean=true;
  view :string;
  pin= true;
  flag = true;
  @Output() event = new EventEmitter();
  token=JSON.parse(localStorage.getItem('userData'));
  imageUrl=localStorage.getItem('ImageLink');
  constructor(public dialog: MatDialog,private notesService: NotesService,private dataservice: DataService) { }

  ngOnInit() {
    this.dataservice.currentMessage.subscribe(data=>
      {
        this.view = data ? 'row wrap' : 'column';
        this.flag=data;
      });
      this.getAllPinNotes();
      this.getAllUnPinNotes();
      // console.log("shubham notes data",this.DisplayNotesAllData)

  }
  
  
  openDialog(note: any)
  {
    const dialogref=this.dialog.open(EditComponent, {
      panelClass: 'custom-dialog-container' ,
      width:'600px',
      data:{note}
    });
  }
  onClickofCHK(note)
  {
    if(this.ckeckClicked)
    console.log(note.id);
    console.log(this.ckeckClicked);
    
  }
  // onPin(data)
  // {
    
  //   try{
    
  //     this.notesService.getallpin(this.token.result).subscribe( response => {
  //       console.log('PINNNNNNED',response);
  //       this.noteEvent.emit([]);
  //     })

  //   }catch(error){
  //     console.log(error);      
  //   }
  // }
  getAllUnPinNotes()
  {
    try{
    
      // this.notesService.getallpin(this.token.result).subscribe( response => {
      //   console.log('all pinned notes are here',response);
      //   this.allpinnotess = response;
      //   this.list = true;
        

        this.notesService.getallunpin(this.token.result).subscribe( (response:any) => {       
          this.notes = response;
          this.notes.forEach(element => {
            if(element.isPin == false && element.isArchive == false && element.isTrash == false){
              this.unpinnedNotes.push(element);
            }
          })
          console.log('all trash notes data---->',this.unpinnedNotes); 
        
      })

    }catch(error){
      console.log(error);      
    }
  }
  getAllPinNotes()
  {
    try{
    
      // this.notesService.getallpin(this.token.result).subscribe( response => {
      //   console.log('all pinned notes are here',response);
      //   this.allpinnotess = response;
      //   this.list = true;
        

        this.notesService.getallpin(this.token.result).subscribe( (response:any) => {       
          this.notes = response;
          this.notes.forEach(element => {
            if(element.isPin == true && element.isArchive == false && element.isTrash == false){
              this.pinNotes.push(element);
            }
          })
          console.log('all trash notes data---->',this.pinNotes); 
        
      })

    }catch(error){
      console.log(error);      
    }
  }
  onPin(note)
  {
    try{
    console.log(note.id);
     
      this.notesService.makepin(note.id,this.token.result).subscribe( response => {
        console.log('PINNNNNNED',response);
        this.noteEvent.emit([]);
      })

    }catch(error){
      console.log(error);      
    }
  }
  onUnpin(note)
  {
    try{
    
      this.notesService.makeunpin(note.id,this.token.result).subscribe( response => {
        console.log('UNNNPINNNNNNED',response);
        this.noteEvent.emit([]);
      })

    }catch(error){
      console.log(error);      
    }
  }

  removeReminder(data){
    try{
    
      this.notesService.removereminder(data.id,this.token.result).subscribe( response => {
        console.log('Reminder Removed.',response);
        this.noteEvent.emit([]);
      })

    }catch(error){
      console.log(error);      
    }
  }

  listenEvent(){
    this.noteEvent.emit([]);
  }
}

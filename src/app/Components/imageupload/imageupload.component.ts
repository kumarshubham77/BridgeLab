import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { NotesService } from 'src/app/services/notesServices/notes.service';

@Component({
  selector: 'app-imageupload',
  templateUrl: './imageupload.component.html',
  styleUrls: ['./imageupload.component.scss']
})
export class ImageuploadComponent implements OnInit {
  token=JSON.parse(localStorage.getItem('userData'));
  token1=JSON.parse(localStorage.getItem('NOTEIDFORIMG'));
  selectedFile;
  imageSelect;
  
  constructor(public dialogRef: MatDialogRef<ImageuploadComponent>,
    @Inject(MAT_DIALOG_DATA)public data,private noteService: NotesService) { }

  ngOnInit() {
  }

  processFile(event: any) 
  {
    this.selectedFile=event.target.files[0];
   
  }
  onUpload()
  {
    var formData = new FormData();
    formData.append('file',this.selectedFile);
    console.log("DATA FOR NOTE asndal",this.token1);
    

    console.log(formData);
    this.noteService.ImageUpload(this.token1,formData,this.token.result).subscribe(
      (data:any) => {
        console.log(data);
        // var email = data.result.email;
        // console.log("qwertyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy",email);
        
        // localStorage.setItem('Email',email);
        // var username = data.result.firstName+data.result.lastName;
        // localStorage.setItem('UserName',username);
        var url = data.result.images;      
        localStorage.setItem('ImageLink',url);
        console.log("qwertyadata",url);
        
      },
      (err) => {
      
      })
  }

}

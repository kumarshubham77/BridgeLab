import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';
import { UserServiceService } from 'src/app/user-service.service';

@Component({
  selector: 'app-upload-image',
  templateUrl: './upload-image.component.html',
  styleUrls: ['./upload-image.component.scss']
})
export class UploadImageComponent implements OnInit {
imageSelect;
token=JSON.parse(localStorage.getItem('userData'));
selectedFile;

  constructor(public dialogRef: MatDialogRef<UploadImageComponent>,
    @Inject(MAT_DIALOG_DATA)public data,private userService: UserServiceService) { }

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

    console.log(formData);
    this.userService.ImageUpload(formData,this.token.result).subscribe(
      (data:any) => {
        console.log(data);
        var email = data.result.email;
        // console.log("qwertyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy",email);
        
        localStorage.setItem('Email',email);
        var username = data.result.firstName+data.result.lastName;
        localStorage.setItem('UserName',username);
        var url = data.result.profilePicture;      
        localStorage.setItem('ProfileLink',url);
      },
      (err) => {
      
      })
  }







  // filepath(event: any){
  //   this.imageSelect=event.target.files[0];
  //   console.log("fdgffg")
  //   console.log("sdhfjgsdf",this.imageSelect)
  // }
  // uploadImage(){
  //   var form=new FormData();
  //   form.append('file',this.imageSelect)
  //   this.userService.ImageUpload(form,this.token.result).subscribe( (response:any) => {       
  //    console.log(response);
  //   })
  //   console.log("upload Image TEXT",form)
  // }
}

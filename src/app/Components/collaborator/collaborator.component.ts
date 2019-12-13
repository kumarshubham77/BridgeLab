import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material';
import { UserServiceService } from 'src/app/user-service.service';
import { CollaboratorService } from '../collaborator.service';

@Component({
  selector: 'app-collaborator',
  templateUrl: './collaborator.component.html',
  styleUrls: ['./collaborator.component.scss']
})
export class CollaboratorComponent implements OnInit {
  note;
  token = JSON.parse(localStorage.getItem('userData'));
  collabArr

  constructor(@Inject(MAT_DIALOG_DATA)public data,
  private userService: UserServiceService,
  private collaboratorService: CollaboratorService)
  { 
    this.note=this.data.note 
    this.collabArr = data['note']['collaborators'];    
    console.log("data in collab array--->",this.collabArr);
  }
  userName:string;
  email:string;

  senderEmail:string;
  receiverEmail:string;

  ngOnInit() {
    this.userDetails();  
   console.log("in  collab");
  }
  userDetails()
  {
    this.userService.getUserdata(this.token.result).subscribe( response =>
    {
      console.log("data--->", response);
      this.userName = response['firstName'];
      this.email = response['email'];
    })
  }
  onAddCollab()
  { 
    const data = {
      "SenderEmail":this.email,
      "ReceiverEmail":this.receiverEmail,
      "Noteid":this.note.id
    }
    this.collaboratorService.addCollaborator(data,this.token.result).subscribe( response => {
      console.log('dataa from back end',response);
    })
  }
  removeCollaborator(receiverEmail)
  {
    const data = {
      "SenderEmail":this.email,
      "ReceiverEmail":receiverEmail,
      "Noteid":this.note.id      
    }
    console.log("this is another text",data);
    this.collaboratorService.RemoveCollaborator(data,this.token.result).subscribe( response => {
      console.log('Collaborator Gets Removed',response);
    })

  }

}

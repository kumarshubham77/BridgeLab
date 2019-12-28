import { NgModule } from '@angular/core';
import { RegistrationComponent } from './Components/registration/registration.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { CardComponent } from './Components/card/card.component';
import { DashboradComponent } from './Components/dashborad/dashborad.component';
import { ForgotComponent } from './Components/forgot/forgot.component';
import { ResetComponent } from './Components/reset/reset.component';
import { NotesComponent } from './Components/notes/notes.component';
import { CreatenoteComponent } from './Components/createnote/createnote.component';
import { ArchiveComponent } from './Components/archive/archive.component';
import { TrashComponent } from './Components/trash/trash.component';
import { ReminderComponent } from './Components/reminder/reminder.component';
import { CollaboratorComponent } from './Components/collaborator/collaborator.component';
import { LabelComponent } from './Components/label/label.component';
import { DragComponent } from './Components/drag/drag.component';
import { UploadImageComponent } from './Components/upload-image/upload-image.component';
import { ImageuploadComponent } from './Components/imageupload/imageupload.component';
import { AdminloginComponent } from './Components/adminlogin/adminlogin.component';
import { AdminregistrationComponent } from './Components/adminregistration/adminregistration.component';
import { AdminuserdetailsComponent } from './Components/adminuserdetails/adminuserdetails.component';
import { DisplayanothernotesComponent } from './Components/displayanothernotes/displayanothernotes.component';
const routes: Routes = [
  {
    path:'', 
    redirectTo:'/card',
    pathMatch:'full'
  },
  {
    path: 'card',
     component :CardComponent
    },
  { 
    path: 'register',
    component: RegistrationComponent 
  },  
  { 
    path:'login', 
    component: LoginComponent
  },  
  {
    path: 'forgot',
    component :ForgotComponent
  },
  {
    path: 'adminlogin',
    component :AdminloginComponent
  },
  {
    path: 'adminregistration',
    component :AdminregistrationComponent
  },
  {
    path: 'adminuserdetails',
    component :AdminuserdetailsComponent
  },
  {
    path: 'reset',
    component :ResetComponent
  },
  {
    path: 'dashboard', 
    component: DashboradComponent,
    children: [
      { 
        path:'', redirectTo:'notes', pathMatch:'full' 
      },
      { 
        path: 'notes', 
        component: NotesComponent 
      },
      { 
        path: 'displayanothernotes', 
        component: DisplayanothernotesComponent 
      },
      { 
        path: 'createNote', 
        component: CreatenoteComponent 
      },
      {
        path: 'archive',
        component : ArchiveComponent
      },
      {
        path: 'trash',
        component: TrashComponent
      },
      {
        path :'reminder',
        component: ReminderComponent
      },
      {
        path :'collaborator',
        component : CollaboratorComponent
      },
      {
        path :'label',
        component : LabelComponent
      },
      {
        path :'Drag',
        component : DragComponent
      },
      {
        path :'imageUpload',
        component : UploadImageComponent
      },
      {
        path :'ImageUPLOADCOMP',
        component : ImageuploadComponent
      }
      
    ]
    
  }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './Components/registration/registration.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCardModule} from '@angular/material/card';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { CardComponent } from './Components/card/card.component';
import {MatButtonModule} from '@angular/material/button';
import { LoginComponent } from './Components/login/login.component';
import { DashboradComponent } from './Components/dashborad/dashborad.component';
import {MatDividerModule} from '@angular/material/divider';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatIconModule} from '@angular/material/icon';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatMenuModule} from '@angular/material/menu';
import { FlexLayoutModule } from "@angular/flex-layout";
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatDialogModule} from '@angular/material/dialog';
import {MatTableModule} from '@angular/material/table';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatPaginatorModule} from '@angular/material/paginator';
// import {DragDropModule} from '@angular/cdk/drag-drop';
import {SocialLoginModule,
  AuthServiceConfig,
  GoogleLoginProvider,
  FacebookLoginProvider,} from "angular-6-social-login";
import { ForgotComponent } from './Components/forgot/forgot.component';
import { ResetComponent } from './Components/reset/reset.component';
import { NotesComponent } from './Components/notes/notes.component';
import { CreatenoteComponent } from './Components/createnote/createnote.component';
import { IconlistComponent } from './Components/iconlist/iconlist.component';
import { DisplaynotesComponent } from './Components/displaynotes/displaynotes.component';
import { EditComponent } from './Components/edit/edit.component';
import { ArchiveComponent } from './Components/archive/archive.component';
import { TrashComponent } from './Components/trash/trash.component';
import { ReminderComponent } from './Components/reminder/reminder.component';
import {MatChipsModule} from '@angular/material/chips';
import { CollaboratorComponent } from './Components/collaborator/collaborator.component';
import { LabelComponent } from './Components/label/label.component';
import { DragComponent } from './Components/drag/drag.component';
import { UploadImageComponent } from './Components/upload-image/upload-image.component';
import { ImageuploadComponent } from './Components/imageupload/imageupload.component';
import { AdminloginComponent } from './Components/adminlogin/adminlogin.component';
import { AdminregistrationComponent } from './Components/adminregistration/adminregistration.component';
import { AdminuserdetailsComponent } from './Components/adminuserdetails/adminuserdetails.component';
import { DisplayanothernotesComponent } from './Components/displayanothernotes/displayanothernotes.component';




  let config = new AuthServiceConfig([
    {
      id: GoogleLoginProvider.PROVIDER_ID,
      provider: new GoogleLoginProvider('898877816506-d7h1kvk1rkc7sqt9ldsvc3tgmii41k5k.apps.googleusercontent.com')
     },
    {
      id: FacebookLoginProvider.PROVIDER_ID,
      provider: new FacebookLoginProvider('2159434114363741')
    }
  ]);
   
  export function provideConfig() {
    return config;
  }
@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponent,
    CardComponent,
    LoginComponent,
    DashboradComponent,
    ForgotComponent,
    ResetComponent,
    NotesComponent,
    CreatenoteComponent,
    IconlistComponent,
    DisplaynotesComponent,
    EditComponent,
    ArchiveComponent,
    TrashComponent,
    ReminderComponent,
    CollaboratorComponent,
    LabelComponent,
    DragComponent,
    UploadImageComponent,
    ImageuploadComponent,
    AdminloginComponent,
    AdminregistrationComponent,
    AdminuserdetailsComponent,
    DisplayanothernotesComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    MatCardModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatSnackBarModule,
    MatButtonModule,
    SocialLoginModule,
    MatDividerModule,
    MatSidenavModule,
    MatIconModule,
    MatToolbarModule,
    MatMenuModule,
    FlexLayoutModule,
    MatTooltipModule,
    MatDialogModule,
    MatChipsModule,
    MatCheckboxModule,
    MatTableModule,
    MatPaginatorModule
    // DragDropModule
  ],
  entryComponents:[EditComponent],
  providers: [{
    provide: AuthServiceConfig,
    useFactory: provideConfig
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }

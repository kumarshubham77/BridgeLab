import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatFormFieldModule} from '@angular/material/form-field';

import { AdminloginComponent } from './adminlogin/adminlogin.component';
import { AdminopComponent } from './adminop/adminop.component';
import { AddclientComponent } from './addclient/addclient.component';
import { ClientloginComponent } from './clientlogin/clientlogin.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminloginComponent,
    AdminopComponent,
    AddclientComponent,
    ClientloginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    MatFormFieldModule,
    MatCardModule,
    MatInputModule,
    MatButtonModule,

    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

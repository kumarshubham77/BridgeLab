import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { MediaMatcher } from '@angular/cdk/layout';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material';
import { LabelComponent } from '../label/label.component';
import { DataService } from 'src/app/services/dataService/data.service';

@Component({
  selector: 'app-dashborad',
  templateUrl: './dashborad.component.html',
  styleUrls: ['./dashborad.component.scss']
})
export class DashboradComponent implements OnInit {
  mobileQuery: MediaQueryList;
  private _mobileQueryListener: () => void;
view:boolean;
  constructor(changeDetectorRef: ChangeDetectorRef, media: MediaMatcher ,private route: Router,public dialog: MatDialog,private dataservice:DataService) { 
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);
  }

  ngOnInit() {
  }
  
  ngOnDestroy(): void {
    this.mobileQuery.removeListener(this._mobileQueryListener);
  }
  onLabel()
  {
    // var note=this.card
    // console.log("collablist",note)
    const dialogref=this.dialog.open(LabelComponent, {
      
    });
    

  }
  onChangeview()
  {
    this.view=!this.view;
    this.dataservice.changeMessage(this.view);
  }

}

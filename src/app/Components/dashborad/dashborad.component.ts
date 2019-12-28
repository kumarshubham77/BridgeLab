import { Component, OnInit, ChangeDetectorRef, Input } from '@angular/core';
import { MediaMatcher } from '@angular/cdk/layout';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material';
import { LabelComponent } from '../label/label.component';
import { DataService } from 'src/app/services/dataService/data.service';
import { NotesService } from 'src/app/services/notesServices/notes.service';
import { UploadImageComponent } from '../upload-image/upload-image.component';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-dashborad',
  templateUrl: './dashborad.component.html',
  styleUrls: ['./dashborad.component.scss']
})
export class DashboradComponent implements OnInit {
  mobileQuery: MediaQueryList;
  private _mobileQueryListener: () => void;
  list = true;
  searchNotes=[];
  image: any;
  notes=[];
  token = JSON.parse(localStorage.getItem('userData'));

  @Input() allNotesData: string;
  view: boolean;
  searching: FormGroup;
  allpinnotess: any;
  selectedFile: File = null;
  constructor(changeDetectorRef: ChangeDetectorRef, media: MediaMatcher, private route: Router, private notesService: NotesService, public dialog: MatDialog, private dataservice: DataService) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);
  }

  ngOnInit() {
    this.getAllPinNotes();
    this.searching = new FormGroup({
      searchLetter: new FormControl('')
    })
    // console.log("Dashboard all Notes DATA here", this.allNotesData)
  }

  ngOnDestroy(): void {
    this.mobileQuery.removeListener(this._mobileQueryListener);
  }
  onLabel() {
    // var note=this.card
    // console.log("collablist",note)
    const dialogref = this.dialog.open(LabelComponent, {

    });


  }

  onChangeview() {
    this.view = !this.view;
    this.dataservice.changeMessage(this.view);
  }
  onRefresh()
  {
    window.location.reload();
  }


  onSignout() {
    localStorage.clear();
    this.route.navigate(['/login']);
  }
  getAllPinNotes() {
    try {

      this.notesService.getallpin(this.token.result).subscribe(response => {
        console.log('all pinned notes are here', response);
        this.allpinnotess = response;
        this.list = true;


      })

    } catch (error) {
      console.log(error);
    }
  }
  uploadProfilePic() {
    const dialogref = this.dialog.open(UploadImageComponent, {

    });
    console.log("hghdfkhgkdfhgkdfhgkdfghkdfhgkdh")
  }
  profile()
  {
    const dialogref=this.dialog.open(UploadImageComponent, 
    {
      data:{}
    });
  }
 email=localStorage.getItem('Email');
  username=localStorage.getItem('UserName');
  url=localStorage.getItem('ProfileLink');




  // Some approch to try Search box
  SearchNote()
  {
    console.log("Searching data is here", this.searching.controls.searchLetter.value)
    this.notesService.Search( this.searching.controls.searchLetter.value,this.token.result).subscribe((data) =>
    {
      console.log("searched notes",data);
    })
  }

}

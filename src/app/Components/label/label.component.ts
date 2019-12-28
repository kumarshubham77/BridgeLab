import { Component, OnInit, EventEmitter, Output, Input, Inject } from '@angular/core';
import { LabelService } from 'src/app/services/label.service';
import { MAT_DIALOG_DATA, MatDialog } from '@angular/material';

@Component({
  selector: 'app-label',
  templateUrl: './label.component.html',
  styleUrls: ['./label.component.scss']
})
export class LabelComponent implements OnInit {
  label: string;
  labelArr;
  note;
  yes:boolean=true;
  change :boolean;
  @Input() hide;
  
  @Output() eventL = new EventEmitter();
  
  

  token = JSON.parse(localStorage.getItem('userData'));
  @Output() labelEvent = new EventEmitter();

  constructor( @Inject(MAT_DIALOG_DATA)public data,private labelservice: LabelService,public dialog: MatDialog) 
  {
    this.note=this.data.note,
    //this.labelArr = data['note']['labels'];    
    console.log("data in label array--->",this.labelArr);
  }

  ngOnInit() {
    // this.labelservice.GetLabelList(this.token.result).subscribe( response =>
    //   {
    //     console.log("data from backend",response);
    //     this.labelArr=response;
    //   })
  }
  // onCreateLabel()
  // {
  //   const data=
  //       {
  //         "Label":this.label,
  //       }
  //       this.labelservice.createLabel(data,this.token.result).subscribe(response =>
  //       {
  //         console.log("data from label backend---->",response);  
  //       })
  //       this.eventL.emit();
  // }
  // onAddLabel()
  // {  
  //   this.dialog.closeAll();
  // }
  // onChangeSymbol()
  // {
  //   this.change=true;
  //   this.yes=!this.yes;
  // }
  // onUpdateLabel(updatelabel,singellabel)
  // {
  //   const data=
  //   {
  //     "LabelId":singellabel,
  //     "Label":updatelabel
  //   }
  //   this.labelservice.updateLabel(data,this.token.result).subscribe(response =>
  //   {
  //     console.log("data from label backend---->",response);  
  //   })
  //   this.eventL.emit();
  // }
  // onDeleteLabel(singellabel)
  // {
  //   const data=
  //   {
  //     "LabelId":singellabel,
  //   }
  //   this.labelservice.deleteLabel(data,this.token.result).subscribe(response =>
  //   {
  //     console.log("data from label backend---->",response);
  //     this.eventL.emit();
  //   })
    
  // }
  
}

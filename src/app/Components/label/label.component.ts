import { Component, OnInit, EventEmitter, Output, Input, Inject } from '@angular/core';
import { LabelService } from 'src/app/services/label.service';
import { MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-label',
  templateUrl: './label.component.html',
  styleUrls: ['./label.component.scss']
})
export class LabelComponent implements OnInit {
  label: string;
  labelArr;
  @Input() note;
  
  

  token = JSON.parse(localStorage.getItem('userData'));
  @Output() labelEvent = new EventEmitter();

  constructor( @Inject(MAT_DIALOG_DATA)public data,private labelservice: LabelService) { }

  ngOnInit() {
  }
  makeLabel()
  {
    var coin = this.note;
    console.log("Some text to show-----------------------> ",this.note);
    
    const data=
    {
      
      "Label":this.label,
      

    }
    this.labelservice.createLabel(data,this.token.result).subscribe(response =>
    {
      console.log("data from label backend---->",response);
      this.labelEvent.emit();
    })
  
  }

  

}

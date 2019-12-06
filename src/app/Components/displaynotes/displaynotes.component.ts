import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-displaynotes',
  templateUrl: './displaynotes.component.html',
  styleUrls: ['./displaynotes.component.scss']
})
export class DisplaynotesComponent implements OnInit {

  @Input() allNotesData: string;

  constructor() { }

  ngOnInit() {
  }
  

}

import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {
  head = true;
 cardone=false;
 cardtwo = false;
  @Output() messageEvent = new EventEmitter<string>();
  constructor() { }

  ngOnInit() {
  }
basic() {
  this.head = false;
  this.cardtwo = true;
  this.messageEvent.emit('Basic')
}
advance() {
  this.head = false;
  this.cardone=true;
 
  this.messageEvent.emit('Advance')
}
}

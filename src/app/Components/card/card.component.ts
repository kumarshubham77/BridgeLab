import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  button = "click here";
  button1 = "click here";
  @Output() messageEvent = new EventEmitter<string>();
  constructor(private router: Router) { }

  ngOnInit() {
  }
  basic() {
    this.button = "BASIC";
    localStorage.setItem('serviceName', (this.button));
    this.router.navigate(['/register']);
  }
  advance() {
    this.button1 = "ADVANCE";
    localStorage.setItem('serviceName', (this.button1));
    this.router.navigate(['/register']);
  }
}

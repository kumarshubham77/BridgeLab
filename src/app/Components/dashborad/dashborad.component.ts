import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashborad',
  templateUrl: './dashborad.component.html',
  styleUrls: ['./dashborad.component.scss']
})
export class DashboradComponent implements OnInit {
open = false;

  constructor() { }

  ngOnInit() {
  }
DrawerOpen()
{
  this.open =!this.open;
  console.log("gfjhgsdfj", this.open)
}
}

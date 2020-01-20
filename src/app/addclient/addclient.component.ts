import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-addclient',
  templateUrl: './addclient.component.html',
  styleUrls: ['./addclient.component.scss']
})
export class AddclientComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }
  home()
  {
    this.router.navigate(['/adminoperation']);
    // console.log("AFTER going from here");
    
  }

}

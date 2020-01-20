import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
// import { adminservice } from 'src/app/adminservice.service' 

@Component({
  selector: 'app-adminop',
  templateUrl: './adminop.component.html',
  styleUrls: ['./adminop.component.scss']
})
export class AdminopComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }
  addnewclient()
  {
    this.router.navigate(['/addclient']);
  }
 

}

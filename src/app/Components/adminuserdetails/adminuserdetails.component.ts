import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/services/admin.service';
import { MatTableDataSource } from '@angular/material';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adminuserdetails',
  templateUrl: './adminuserdetails.component.html',
  styleUrls: ['./adminuserdetails.component.scss']
})
export class AdminuserdetailsComponent implements OnInit {
  DetailsColumns: string[] = ['id','firstName', 'lastName', 'emailId','status', 'cardType','totalNotes'];
  StatisticColumns: string[] = ['sno', 'userEmailId', 'logInTime', 'services'];
  list = [];
  statistic=[];
  dataSource;
  user=true;

  constructor(private adminservice: AdminService, private route: Router) { }

  ngOnInit() {
    this.userList()
  }
  userList() {
    this.user=true;
    this.adminservice.GetUserList().subscribe((data: any) => {
      console.log("List from backend for user_list", data);
      this.list = data.result;
      this.dataSource=this.list;
      this.dataSource = new MatTableDataSource(this.list);
    })
  }
  userStatistic()
  {
    this.user=false;
    this.adminservice.GetUserStatistic().subscribe((data: any) => {
      console.log("Statistic from backend for user_statistics", data);
      this.statistic = data.result;
      this.dataSource=this.statistic;
      this.dataSource = new MatTableDataSource(this.statistic);
    })
  }
  onSignout()
  {
    // window.location.reload();
    localStorage.clear();
    
    this.route.navigate(['/adminlogin']);
  }

}

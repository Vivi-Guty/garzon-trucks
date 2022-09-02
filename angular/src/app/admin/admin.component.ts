import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  items: MenuItem[];

  constructor() { }

  ngOnInit(): void {
    this.items = [
      {label: 'Users', icon: 'pi pi-fw pi-users', routerLink: ['users']},
      {label: 'Insurances', icon: 'pi pi-fw pi-download', routerLink: ['insurances']}
    ];
  }

}

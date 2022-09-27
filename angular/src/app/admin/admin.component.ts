import { Component, OnInit } from '@angular/core';
import { TextService } from 'src/shared-services/text.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html'
})
export class AdminComponent implements OnInit {

  constructor(public txt: TextService) { }

  ngOnInit(): void {
    this.items = [
      {label: 'Users', icon: 'pi pi-fw pi-users', routerLink: ['users']},
      {label: 'Insurances', icon: 'pi pi-fw pi-download', routerLink: ['insurances']}
    ];
  }

}

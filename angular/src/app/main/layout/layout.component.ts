import { Component, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { User } from 'src/app/models/User';
import { AuthenticationService } from 'src/shared-services/authentication.service';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {

  loading = false;
  users: User[] = [];

  constructor(private authenticationService: AuthenticationService, private messageService: MessageService) { }

  ngOnInit() {
    this.authenticationService.getAll().then(response => {
      this.users = response;
    }).catch(error => {
      console.error(error);
      this.messageService.add({severity: 'error', summary: error.statusText, detail: error.error});
    });
  }

}

import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/User';
import { AuthenticationService } from 'src/shared-services/authentication.service';
import { ErrorService } from 'src/shared-services/error.service';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {

  loading = false;
  users: User[] = [];

  constructor(private authenticationService: AuthenticationService, private errorService: ErrorService) { }

  ngOnInit() {
    this.authenticationService.getAll().then(response => {
      this.users = response;
    }).catch(error => {
      console.error(error);
      this.errorService.show({ error: error, title: error.statusText});
    });
  }

}

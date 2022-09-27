import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/User';
import { AuthenticationService } from 'src/shared-services/authentication.service';
import { ErrorService } from 'src/shared-services/error.service';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html'
})
export class LayoutComponent implements OnInit {

  loading = false;
  users: User[] = [];

  constructor(private authenticationService: AuthenticationService, private errorService: ErrorService) { }

  ngOnInit() {

  }

}

import { Component, OnInit } from '@angular/core';
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

  constructor(private authenticationService: AuthenticationService) { }

  async ngOnInit() {
    this.users = await this.authenticationService.getAll();
  }

}

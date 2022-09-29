import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { MenuItem } from 'primeng/api';
import { User } from 'src/app/models/User';
import { AuthenticationService } from 'src/shared-services/authentication.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  languages = ['EN', 'ES'];
  currentUser: User;
  items: MenuItem[];

  constructor(
    private router: Router,
    private authenticationService: AuthenticationService,
    private translate: TranslateService) {
      this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
    }

  async ngOnInit(): Promise<void> {

    this.items = [
      {
        label: 'Nuevo episodio',
      },
      {
        label: 'Mis episodios'
      },
      {
        label: 'Buscador'
      },
      {
        label: 'Materiales'
      },
      {
        label: 'Dashboard'
      },
      {
        label: 'Gestor Documental'
      },
      {
        label: 'Procedimientos'
      },
      {
        label: await this.translate.get('HEADER.ADMINISTRATION').toPromise(),
        routerLink: '/admin'
      }
    ]
  }

  logout() {
    this.authenticationService.logout();
    this.router.navigate(['login']);
  }

}

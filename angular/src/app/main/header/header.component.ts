import { JsonPipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { PanelMenuModule } from 'primeng/panelmenu';
import { MenuItem } from 'primeng/api';
import { User } from 'src/app/models/User';
import { AuthenticationService } from 'src/shared-services/authentication.service';
import { TextService } from 'src/shared-services/text.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit {

  //languages = ['EN', 'ES'];
  currentUser: User;
  languages: MenuItem[];

  constructor(
    public router: Router,
    private authenticationService: AuthenticationService,
    public txt: TextService) {
      this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
      this.loadMenus();
    }

  async ngOnInit(): Promise<void> {
    this.loadMenus();
  }

  loadMenus(){

    this.languages =[{ label: 'language',
      items: [{
                label: 'es',
                command: (event) => { this.changeLanguage('es'); }
              },
              { label: 'en',
                command: (event) => { this.changeLanguage('en');}
              },
              { label: 'de',
                command: (event) => { this.changeLanguage('de');}
              }
            ]
      }];
  }

  async changeLanguage(lg: string){
      this.txt.texts = await this.txt.getTexts(lg);
  }

  logout() {
    this.authenticationService.logout();
    this.router.navigate(['login']);
  }
}

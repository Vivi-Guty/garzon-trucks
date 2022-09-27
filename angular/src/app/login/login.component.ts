import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageService } from 'primeng/api';
import { AuthenticationService } from 'src/shared-services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {

  domain: string = '';
  loginName: string = '';
  password: string = '';
  loading = false;
  submitted = false;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService,
    private messageService: MessageService) {
        // redirect to home if already logged in
        if (this.authenticationService.currentUserValue) {
          this.router.navigate(['/']);
      }
    }

  ngOnInit(): void {
    this.domain = "inercya-test";
    this.loginName = "david.garcia";
    this.password = "garcia";
  }

  async onSubmit() {
    this.submitted = true;

    this.loading = true;
    this.authenticationService.login(this.domain, this.loginName, this.password).then(response => {
      // get return url from route parameters or default to '/'
      const returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
      this.router.navigate([returnUrl]);
    }).catch(error => {
      this.loading = false;
      console.log(error);
      this.messageService.add({severity: 'error', summary: error.statusText, detail: error.error.message});
    });
}

}

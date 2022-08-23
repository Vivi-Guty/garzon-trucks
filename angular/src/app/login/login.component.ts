import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/shared-services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginName: string = '';
  password: string = '';
  loading = false;
  submitted = false;
  error = '';

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService) {
        // redirect to home if already logged in
        if (this.authenticationService.currentUserValue) {
          this.router.navigate(['/']);
      }
    }

  ngOnInit(): void {

  }

  async onSubmit() {
    this.submitted = true;

    this.loading = true;
    this.authenticationService.login(this.loginName, this.password).then(response => {
      // get return url from route parameters or default to '/'
      const returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
      this.router.navigate([returnUrl]);
    }).catch(error => {
      this.error = error;
      this.loading = false;
    });
}

}

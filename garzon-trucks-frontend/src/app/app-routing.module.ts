import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './helpers/auth.guard';
import { LoginComponent } from './login/login.component';
import { LayoutComponent } from './main/layout/layout.component';

const routes: Routes = [
  { path: '', component: LayoutComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent },
  { path: 'admin', canActivate: [AuthGuard],
    loadChildren: () => import('../app/admin/admin.module').then(m => m.AdminModule)
  },
  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

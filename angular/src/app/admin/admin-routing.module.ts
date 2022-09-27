import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin.component';
import { OrganizationalUnitsComponent } from './organizational-units/organizational-units.component';
import { UsersComponent } from './users/users.component';


const routes: Routes = [
  {
    path: '', component: AdminComponent, children: [
      { path: 'users', component: UsersComponent },
      { path: 'organizational-units', component: OrganizationalUnitsComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { UsersComponent } from './users/users.component';

import { TableModule } from 'primeng/table';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { FormsModule } from '@angular/forms';
import { MenubarModule } from 'primeng/menubar';
import { CalendarModule } from 'primeng/calendar';
import { RadioButtonModule } from 'primeng/radiobutton';
import { OverlayPanelModule } from 'primeng/overlaypanel';
import { DropdownModule } from 'primeng/dropdown';
import { ToolbarModule } from 'primeng/toolbar';
import { SidebarModule } from 'primeng/sidebar';
import { ConfirmPopupModule } from 'primeng/confirmpopup';
import { ConfirmationService } from 'primeng/api';
import { MenuModule} from 'primeng/menu';
import { SkeletonModule } from 'primeng/skeleton';

@NgModule({
  declarations: [
    UsersComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    TableModule,
    TableModule,
    ButtonModule,
    InputTextModule,
    FormsModule,
    MenubarModule,
    CalendarModule,
    RadioButtonModule,
    OverlayPanelModule,
    DropdownModule,
    ToolbarModule,
    SidebarModule,
    ConfirmPopupModule,
    MenuModule,
    SkeletonModule
  ]
})
export class AdminModule { }

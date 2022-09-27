import { Component, OnInit } from '@angular/core';
import { UserCriteria } from 'src/app/models/UserCriteria';
import { User } from 'src/app/models/User';
import { ErrorService } from 'src/shared-services/error.service';
import { UsersService } from './users.service';
import { SharedServicesService } from 'src/shared-services/shared-services.service';
import { Entity } from '../../models/Entity';
import { Role } from 'src/app/models/Role';
import { OrganizationalUnitTypeModel } from 'src/app/models/_models';

import { OrganizationalUnitType } from '../../models/OrganizationalUnitType';
import { ModuleTeardownOptions } from '@angular/core/testing';
@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',

})
export class UsersComponent implements OnInit {

  loading = true;
  users: User[] = [];
  userCriteria = {} as UserCriteria;
  roles: Role[] = [];


  constructor(private usersService: UsersService, private errorService: ErrorService, private sharedService: SharedServicesService) { }

  async ngOnInit(){
    await this.searchUsers();
  }

  async searchUsers(){
    try {
        this.users = await this.usersService.searchUsers(this.userCriteria);
    } catch (error) {
        this.errorService.show({ error: error, title: error.statusText });
    }
  }

  addUser(){
    /*this.user = {} as User;
    this.userRoles = [];
    this.userWalkingImplants = [];
    this.editUserService.display = true;*/
  }

/** Edicion de usuario
 * Recogemos el usuario selecionado y le pedimos a la API los roles
 * y los WalKingImplats de ese usuario
 */
async editUser(user: User){
    try {
        /*this.user = user;
        this.userRoles = await this.usersService.getUserRoles(this.user.userId);
        this.userWalkingImplants = await this.usersService.getWalkingImplantsByUser(this.user.userId);
        this.editUserService.display = true;*/
    } catch (error) {
        this.errorService.show({ error: error, title: "Error en la apliacion" });
    }
}

exportExcel() {
    /*const excelUser = this.users.map(x => {
        return {
            loginName: x.loginName,
            userName: x.userName,
            userMail: x.userMail,
            isActive: x.isActive,
        }
    });
    import("xlsx").then(xlsx => {
        const worksheet = xlsx.utils.json_to_sheet(excelUser);
        console.log(worksheet);
        const workbook = { Sheets: { 'data': worksheet }, SheetNames: ['data'] };
        const excelBuffer: any = xlsx.write(workbook, { bookType: 'xlsx', type: 'array' });
        this.sharedService.saveAsExcelFile(excelBuffer, "users");
    });*/
  }
}

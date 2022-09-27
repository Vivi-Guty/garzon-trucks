import { Component, OnInit } from '@angular/core';
import { ErrorService } from 'src/shared-services/error.service';
import { OrganizationalUnitsService } from './organizational-units.service';
import { SharedServicesService } from 'src/shared-services/shared-services.service';
@Component({
  selector: 'app-organizational-units',
  templateUrl: './organizational-units.component.html',

})
export class OrganizationalUnitsComponent implements OnInit {

  constructor(private organizationalUnitsService: OrganizationalUnitsService, private errorService: ErrorService, private sharedService: SharedServicesService) { }

  async ngOnInit(){

  }

}

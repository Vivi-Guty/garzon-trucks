import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from 'src/app/models/User';
import { ApiService } from '../../../shared-services/api.service';

@Injectable({
  providedIn: 'root'
})
export class OrganizationalUnitsService {

  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;

  constructor(private apiService: ApiService) {

  }

}

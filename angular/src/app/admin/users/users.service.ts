import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { UserCriteria } from 'src/app/models/UserCriteria';
import { User } from 'src/app/models/User';
import { ApiService } from '../../../shared-services/api.service';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;

  constructor(private apiService: ApiService) {

    /*var currentUser = localStorage.getItem('currentUser');
    var user = JSON.parse(currentUser!); // ! esto quita el null
    this.currentUserSubject = new BehaviorSubject<User>(user);
    this.currentUser = this.currentUserSubject.asObservable();*/

  }

  searchUsers(userCriteria: UserCriteria): Promise<User[]>{
    return this.apiService.post<User[]>('admin/search-users', userCriteria);
  }

}

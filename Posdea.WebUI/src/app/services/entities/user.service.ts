import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, Observable } from 'rxjs';
import { adaptUser } from 'src/app/adapters/user.adapter';
import { parseApplicationError } from 'src/app/helpers/httpHelper';
import { UserInternal } from 'src/app/interfaces/models/user.internal';
import { User } from 'src/app/models/user.model';
import { environment } from 'src/environments/environment';
import { AuthService } from '../auth/auth.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http : HttpClient, 
    private authService : AuthService) { }

  public getActiveUser(): Observable<User> {
    return this.http.get<User>(`${environment.baseUrl}/User/active`, {
      headers : { 'Authorization' : `bearer ${this.authService.getAuthToken()}` }
    })
    .pipe(
      map( (user : UserInternal) => {
        return adaptUser(user)
      }),
      catchError( err => { throw parseApplicationError(err)})
    );
  }
}

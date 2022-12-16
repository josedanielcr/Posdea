import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, Observable } from 'rxjs';
import { adaptUser } from 'src/app/adapters/user.adapter';
import { parseApplicationError } from 'src/app/helpers/httpHelper';
import { UserInternal } from 'src/app/interfaces/models/user.internal';
import { ApplicationError } from 'src/app/models/http/applicationError';
import { User } from 'src/app/models/user.model';
import { UserRegister } from 'src/app/models/userRegister.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http : HttpClient) { }

  public signUp(user : User): Observable<User> {
    return this.http.post<UserInternal>(`${environment.baseUrl}/Auth/SignUp`, user)
    .pipe(
        map( (user : UserInternal) => {
          return adaptUser(user);
        }),
        catchError( err => { throw parseApplicationError(err)})
      )
  }

  public login(userRegister : UserRegister) : Observable<any> {
    return this.http.post(`${environment.baseUrl}/Auth/Login`, userRegister)
      .pipe(
        map((userResponse : any) => {
          this.setAuthToken(userResponse['token']);
          return adaptUser(userResponse['user']);
        }),
        catchError( err => { throw parseApplicationError(err)})
      )
  }

  public setAuthToken(token : string){
    localStorage.setItem('token', token);
  }

  public getAuthToken(): string {
    return localStorage.getItem('token') || '';
  }
  
}
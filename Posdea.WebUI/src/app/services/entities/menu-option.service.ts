import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, Observable } from 'rxjs';
import { adaptMenuOption } from 'src/app/adapters/menuOption.adapter';
import { parseApplicationError } from 'src/app/helpers/httpHelper';
import { MenuOptionInternal } from 'src/app/interfaces/models/menuOption.internal';
import { MenuOption } from 'src/app/models/menuOption.model';
import { environment } from 'src/environments/environment';
import { AuthService } from '../auth/auth.service';

@Injectable({
  providedIn: 'root'
})
export class MenuOptionService {

  constructor(private http : HttpClient,
    private authService : AuthService) { }

  public getMenuOptions(roleId : number): Observable<MenuOption[]>{
    return this.http.get<MenuOptionInternal[]>(`${environment.baseUrl}/MenuOption/role/${roleId}`, 
    { headers : { 'Authorization' : `bearer ${this.authService.getAuthToken()}` }
    }).pipe(
      map((menuOptions : MenuOptionInternal[]) => {
        return menuOptions.map(menuOption => adaptMenuOption(menuOption));
      }),
      catchError( err => { throw parseApplicationError(err)})
    )
  }
}

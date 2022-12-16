import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Country } from 'src/app/interfaces/external/country';

@Injectable({
  providedIn: 'root'
})
export class CountriesService {

  readonly countriesBaseUrl : string = 'https://restcountries.com/v3.1';

  constructor(private http : HttpClient) { }

  public getAllCountries() : Observable<Country[]>{
    let response : Country[] = [];
    return this.http.get<Country[]>(`${this.countriesBaseUrl}/all`)
      .pipe(
        map( (countries : Country[]) => {
          countries.map( (apiCountry : Country ) => {
            const country : Country = {name: apiCountry.name, flags: apiCountry.flags, postalCode : apiCountry.postalCode, ccn3 : apiCountry.ccn3};
            response.push(country);
          } )
          return response;
        } )
      );
  }

}
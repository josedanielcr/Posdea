import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { validateForm } from 'src/app/helpers/formHelper';
import { Country } from 'src/app/interfaces/external/country';
import { selectOption } from 'src/app/interfaces/internal/selectOption';
import { Address } from 'src/app/models/address.model';
import { ApplicationError } from 'src/app/models/http/applicationError';
import { User } from 'src/app/models/user.model';
import { AuthService } from 'src/app/services/auth/auth.service';
import { CountriesService } from 'src/app/services/external/countries.service';
import { NotificationsService } from 'src/app/services/util/notifications.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  public signUpForm! : FormGroup;
  public selectData : selectOption[] = [];
  public isLoading : boolean = false;

  constructor(private fb : FormBuilder, 
    private countriesService : CountriesService,
    private authService : AuthService,
    private notificationService : NotificationsService,
    private router : Router) { 
  }

  ngOnInit(): void {
    this.createSignUpForm();
    this.getSelectData();
  }

  private createSignUpForm(): void {
    this.signUpForm = this.fb.group({
      name : ['',[ Validators.required]],
      email : ['',[ Validators.required, Validators.pattern( '[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$' ) ]],
      phoneNumber : ['',[ Validators.required ]],
      country : [[ Validators.required ]],
      password : ['',[ Validators.required, Validators.pattern('(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&].{8,}') ]]
    });
  }

  private getSelectData(): void {
    this.countriesService.getAllCountries().subscribe({
      next : ( countries : Country[] ) => this.selectDataToOptions(countries)
    });
  }
  
  public submitSignUp(): void {
    this.isLoading = true;

    if(!validateForm(this.signUpForm)){
      this.isLoading = false;
      return
    }

    this.signUp(this.parseFormDataToUser());
    this.isLoading = false;
  }

  private selectDataToOptions(countries : Country[]): void {
    countries.forEach(( country : Country ) => {
      let selectOption : selectOption = {
        text : country.name.common,
        value : country.ccn3
      }
      this.selectData.push(selectOption);
    })
  }

  private parseFormDataToUser(): User {
    let user = new User();
    user.name = this.signUpForm.controls['name'].value;
    user.email = this.signUpForm.controls['email'].value;
    user.phoneNumber =this.signUpForm.controls['phoneNumber'].value;
    user.password = this.signUpForm.controls['password'].value;
    let address = new Address();
    address.country = this.signUpForm.controls['country'].value
    user.address = address;
    return user;
  }

  private signUp(user : User): void {
    this.authService.signUp(user).subscribe({
      next : (userResponse : User) => {
        this.notificationService.showNotification(`Welcome to Posdea ${userResponse.name}`,'success');
        this.navigateToLogin();
      },
      error : (error : ApplicationError) => {
        this.notificationService.showNotification(error.title,'error');
      }
    });
  }

  private navigateToLogin(): void {
    setTimeout( () => {
      this.router.navigateByUrl('/login');
    },2000);
  }

}
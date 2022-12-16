import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { validateForm } from 'src/app/helpers/formHelper';
import { ApplicationError } from 'src/app/models/http/applicationError';
import { User } from 'src/app/models/user.model';
import { UserRegister } from 'src/app/models/userRegister.model';
import { AuthService } from 'src/app/services/auth/auth.service';
import { NotificationsService } from 'src/app/services/util/notifications.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public loginForm! : FormGroup;
  public isLoading : boolean = false;

  constructor(private fb : FormBuilder,
              private authService : AuthService,
              private notificationService : NotificationsService,
              private router : Router) {}

  ngOnInit(): void {
    this.createLoginForm();
  }

  private createLoginForm(): void {
    this.loginForm = this.fb.group({
      email    : ['',[ Validators.required, Validators.pattern( '[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$' ) ]],
      password : ['',[ Validators.required, Validators.pattern('(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&].{8,}') ]]
    });
  }

  public submitLogin(): void {
    this.isLoading = true;

    if(!validateForm(this.loginForm)){
      this.isLoading = false;
      return
    }

    this.login(this.parseFormToUserRegister());
    this.isLoading = false;
  }

  private parseFormToUserRegister(): UserRegister {
    return new UserRegister(
      this.loginForm.controls['email'].value,
      this.loginForm.controls['password'].value
    );
  }

  private login(userRegister : UserRegister): void {
    this.authService.login(userRegister).subscribe({
      next : (user : User) => {
        this.router.navigateByUrl('/home');
      },
      error : (error : ApplicationError) => {
        this.notificationService.showNotification(error.title, 'error');
      }
    })
  }
}
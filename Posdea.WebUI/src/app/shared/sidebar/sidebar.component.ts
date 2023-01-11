import { Component, HostListener, Input, OnInit } from '@angular/core';
import { MatDrawerMode } from '@angular/material/sidenav';
import { Router } from '@angular/router';
import { ApplicationError } from 'src/app/models/http/applicationError';
import { MenuOption } from 'src/app/models/menuOption.model';
import { User } from 'src/app/models/user.model';
import { AuthService } from 'src/app/services/auth/auth.service';
import { MenuOptionService } from 'src/app/services/entities/menu-option.service';
import { UserService } from 'src/app/services/entities/user.service';
import { NotificationsService } from 'src/app/services/util/notifications.service';

@Component({
  selector: 'shared-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  public user! : User;
  public isOpen : boolean = true;
  public isButtonVisible : boolean = true;
  public type : MatDrawerMode = 'side';
  public menuOptions : MenuOption[] = [];

  @HostListener('window:resize', ['$event'])
  onResize(event : Event) {
    this.windowResize();
  }

  constructor(private userService : UserService,
    private router : Router,
    private notificationService : NotificationsService,
    private menuOptionService : MenuOptionService) { }

  public change(){
    this.isOpen = !this.isOpen;
  }

  ngOnInit(): void {
    this.getActiveUser();
    this.windowResize();
  }

  private getActiveUser(): void {
    this.userService.getActiveUser().subscribe({
      next: (user : User) => {
        this.user = user;
        console.log(this.user);
        
        this.getMenuOptions();
      },
      error : (error : ApplicationError) => {
        this.notificationService.showNotification('Internal error','error');
        setTimeout(() => {
          this.router.navigateByUrl('/login');
        }, 1500);
      }
    })
  }

  private getMenuOptions(): void {
    this.menuOptionService.getMenuOptions(this.user.roleId).subscribe({
      next : (menuOptions : MenuOption[]) => {
        this.menuOptions = menuOptions;
        console.log(this.menuOptions);
      },
      error : (err : ApplicationError) => {
        this.notificationService.showNotification('Internal error','error');
        setTimeout(() => {
          this.router.navigateByUrl('/login');
        }, 1500);
      }
    })
  }

  private windowResize(): void {
    if(window.innerWidth <= 768){
      this.isOpen = false;
      this.isButtonVisible = true;
      this.type = 'over';
    } else {
      this.isOpen = true;
      this.isButtonVisible = false;
      this.type = 'side';
    } 
  }

}

import { Component, Input, OnInit } from '@angular/core';
import { MenuOption } from 'src/app/models/menuOption.model';
import { User } from 'src/app/models/user.model';

@Component({
  selector: 'shared-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  public isOpen : boolean = true;
  @Input() menuOptions! : MenuOption[];
  @Input() user! : User;

  constructor() { }

  ngOnInit(): void {
  }

  public change(){
    this.isOpen = !this.isOpen;
  }

}

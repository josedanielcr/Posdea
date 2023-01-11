import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app.routing.module';

//internal
import { SidebarComponent } from './sidebar/sidebar.component';

//angular material
import {MatSidenavModule} from '@angular/material/sidenav';


@NgModule({
  declarations: [
    SidebarComponent
  ],
  imports: [
    CommonModule,
    MatSidenavModule,
    AppRoutingModule
  ],
  exports : [
    SidebarComponent
  ]
})
export class SharedModule { }

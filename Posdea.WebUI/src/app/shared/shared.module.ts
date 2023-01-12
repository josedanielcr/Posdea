import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app.routing.module';

//internal
import { SidebarComponent } from './sidebar/sidebar.component';

//angular material
import {MatSidenavModule} from '@angular/material/sidenav';
import { PipesModule } from '../pipes/pipes.module';
import { MatIconModule } from '@angular/material/icon';


@NgModule({
  declarations: [
    SidebarComponent
  ],
  imports: [
    CommonModule,
    MatSidenavModule,
    AppRoutingModule,
    PipesModule,
    MatIconModule
  ],
  exports : [
    SidebarComponent
  ]
})
export class SharedModule { }

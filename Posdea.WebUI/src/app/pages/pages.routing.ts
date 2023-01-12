//angular components
import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { PagesComponent } from './pages.component';
import { HomeComponent } from './home/home.component';
import { ProjectsComponent } from './projects/projects.component';

const routes: Routes = [
  {
      path      : 'home',
      component : PagesComponent,
      //canActivate: [AuthGuard],
      children  : [
       { path: '',component: HomeComponent }, 
       { path: 'projects',component: ProjectsComponent }, 
      ]
  }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class PagesRoutingModule {}
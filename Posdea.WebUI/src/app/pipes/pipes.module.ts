import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DefaultAvatarPipe } from './default-avatar.pipe';



@NgModule({
  declarations: [
    DefaultAvatarPipe
  ],
  exports : [
    DefaultAvatarPipe
  ],
  imports: [
    CommonModule
  ]
})
export class PipesModule { }

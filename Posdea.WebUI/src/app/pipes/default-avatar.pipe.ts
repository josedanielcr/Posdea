import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'defaultAvatar'
})
export class DefaultAvatarPipe implements PipeTransform {

  transform(avatar : string): string {
    if(avatar === '' || avatar == null) return '../../assets/images/pug-default-avatar.jpg';
    else return avatar;
  }

}

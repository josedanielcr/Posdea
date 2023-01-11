import { Injectable } from '@angular/core';
import { Notify } from 'notiflix/build/notiflix-notify-aio';
 
@Injectable({
  providedIn: 'root'
})
export class NotificationsService {

  constructor() { }

  public showNotification(title : string, type : string): void {
    switch(type){
      case 'success':
        Notify.success(title);
        break;
      case 'warning':
        Notify.warning(title);
        break;
      case 'error':
        Notify.failure(title);
        break;
      default:
        Notify.info(title);
    }
  }
}
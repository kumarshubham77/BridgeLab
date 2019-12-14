import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor() { }

  private messageSource = new BehaviorSubject(true);
  currentMessage = this.messageSource.asObservable();

  changeMessage(message: boolean) {
    this.messageSource.next(message)
  }

}

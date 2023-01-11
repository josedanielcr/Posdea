import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'component-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {

  @Input() size : number = 100;
  @Input() label! : string;
  @Input() type! : string;
  @Input() disabled : boolean = false;

  constructor() { }

  ngOnInit(): void {
  }

}

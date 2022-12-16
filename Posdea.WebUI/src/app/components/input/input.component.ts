import { Component, Input } from '@angular/core';
import { AbstractControl, ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';

@Component({
  selector: 'component-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.css'],
  providers : [
    { provide: NG_VALUE_ACCESSOR, useExisting : InputComponent, multi : true }
  ]
})
export class InputComponent implements ControlValueAccessor {

  @Input() inputFormControl! : AbstractControl;
  @Input() size : number = 100;
  @Input() type! : string;
  @Input() disabled! : boolean;
  @Input() label! : string;
  @Input() placeholder! : string;
  @Input() icon! : string;
  @Input() hint! : string;
  @Input() isPassword : boolean = false;
  @Input() errorMessage : string = '';
  public value : any;
  public isHidden : boolean = false;
  public visibilityType : string = 'password';
  
  onChange! : (value : any) => void;
  onTouched! : () => void;

  constructor() { 
  }

  writeValue(obj: any): void {
    this.value = obj;
  }

  registerOnChange(fn: any): void {
    this.onChange = fn;
  }

  registerOnTouched(fn: any): void {
    this.onTouched = fn;
  }

  public changeVisibility() : boolean {
    this.isHidden = !this.isHidden;
    this.isHidden === false ? this.visibilityType = 'password' : this.visibilityType = 'text';
    return this.isHidden
  }

}
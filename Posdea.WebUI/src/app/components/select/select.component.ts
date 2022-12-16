import { Component, Input, OnInit } from '@angular/core';
import { AnyForUntypedForms, ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';
import { selectOption } from 'src/app/interfaces/internal/selectOption';

@Component({
  selector: 'component-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.css'],
  providers : [
    { provide: NG_VALUE_ACCESSOR, useExisting : SelectComponent, multi : true }
  ]
})
export class SelectComponent implements OnInit, ControlValueAccessor{

  @Input() selectData! : selectOption[];
  @Input() isDisabled : boolean = false;
  @Input() label! : string;
  @Input() areMultiple : boolean = false;
  @Input() default! : selectOption;
  @Input() size : number = 100;
  public value! : string;

  onChange! : (value : any) => void;
  onTouched! : () => void;

  constructor() { }

  ngOnInit(): void {
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

}

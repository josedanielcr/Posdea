import { FormGroup } from "@angular/forms";

export const validateForm = (form : FormGroup) => {
  if(form.invalid){
    Object.values( form.controls ).forEach( control => {
      if( control instanceof FormGroup ){
        Object.values( control.controls ).forEach( control => control.markAsTouched() );
      } else{
        control.markAsTouched();
      }
    })
    return false;
  }
  return true;
}
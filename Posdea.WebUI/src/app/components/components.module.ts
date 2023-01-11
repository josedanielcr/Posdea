import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

//internal
import { ButtonComponent } from './button/button.component';
import { InputComponent } from './input/input.component';

//Angular material
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { SelectComponent } from './select/select.component';
import { MatSelectModule } from '@angular/material/select';
import { MatSliderModule } from '@angular/material/slider';
import { MatTooltipModule } from '@angular/material/tooltip';

@NgModule({
  declarations: [
    ButtonComponent,
    InputComponent,
    SelectComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule,
    MatSelectModule,
    MatSliderModule,
    MatTooltipModule
  ],
  exports : [
    InputComponent,
    ButtonComponent,
    SelectComponent
  ]
})
export class ComponentsModule { }

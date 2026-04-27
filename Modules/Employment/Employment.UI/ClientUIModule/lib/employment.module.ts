import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WelcomingComponent } from './components/welcoming/welcoming.component';
import { EmploymentRoutingModule } from './employment-routing.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
      EmploymentRoutingModule,
      WelcomingComponent
  ]
})
export class EmploymentModule { }

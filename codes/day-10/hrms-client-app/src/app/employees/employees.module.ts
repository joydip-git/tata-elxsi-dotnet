import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { AddEmployeeComponent } from './components/add-employee/add-employee.component';
import { EmployeeService } from './services/employee.service';



@NgModule({
  declarations: [
    EmployeeListComponent,
    AddEmployeeComponent
  ],
  exports: [EmployeeListComponent],
  imports: [
    CommonModule
  ],
  providers:[EmployeeService]
})
export class EmployeesModule { }

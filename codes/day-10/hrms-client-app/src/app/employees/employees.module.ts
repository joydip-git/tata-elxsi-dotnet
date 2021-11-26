import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { AddEmployeeComponent } from './components/add-employee/add-employee.component';
import { EmployeeService } from './services/employee.service';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    EmployeeListComponent,
    AddEmployeeComponent
  ],
  exports: [EmployeeListComponent],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  providers:[EmployeeService]
})
export class EmployeesModule { }

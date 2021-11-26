import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { AddEmployeeComponent } from './components/add-employee/add-employee.component';
import { EmployeeService } from './services/employee.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { EmployeesPipe } from './pipes/employees.pipe';



@NgModule({
  declarations: [
    EmployeeListComponent,
    AddEmployeeComponent,
    EmployeesPipe
  ],
  exports: [EmployeeListComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [EmployeeService]
})
export class EmployeesModule { }

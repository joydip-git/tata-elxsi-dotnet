import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { AddEmployeeComponent } from './components/add-employee/add-employee.component';
import { EmployeeService } from './services/employee.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { EmployeesPipe } from './pipes/employees.pipe';
import { EmployeesRoutingModule } from './employees-routing.module';
import { ViewEmployeeComponent } from './components/view-employee/view-employee.component';
import { UpdateEmployeeComponent } from './components/update-employee/update-employee.component';



@NgModule({
  declarations: [
    EmployeeListComponent,
    AddEmployeeComponent,
    EmployeesPipe,
    ViewEmployeeComponent,
    UpdateEmployeeComponent
  ],
  exports: [EmployeeListComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule,
    EmployeesRoutingModule
  ],
  providers: [EmployeeService]
})
export class EmployeesModule { }

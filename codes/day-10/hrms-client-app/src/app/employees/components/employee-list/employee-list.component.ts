import { Component } from '@angular/core';
import { Employee } from '../../models/employee.model';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css'],
  //providers: [EmployeeService]
})
export class EmployeeListComponent {

  employees: Employee[] = [];
  constructor(private empSvc: EmployeeService) {
    // (document.getElementsByName('button')[0]).addEventListener("click", this.getEmployees)
  }
  getEmployees() {
    this.empSvc
      .fetcAllEmployee()
      .subscribe(
        (data: Employee[]) => {
          this.employees = data
        }
      )
  }
}

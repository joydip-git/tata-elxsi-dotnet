import { Component } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css'],
  //providers: [EmployeeService]
})
export class EmployeeListComponent {

  constructor(private empSvc: EmployeeService) {

  }
}

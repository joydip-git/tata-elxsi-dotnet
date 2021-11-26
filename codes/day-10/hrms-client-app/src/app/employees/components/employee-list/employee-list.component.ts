import { Component, OnInit } from '@angular/core';
import { Employee } from '../../models/employee.model';
import { ResponseMessage } from '../../models/responsemessage.model';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css'],
  //providers: [EmployeeService]
})
export class EmployeeListComponent implements OnInit {

  employees?: Employee[];
  filterText = ''
  responseResult?: ResponseMessage;
  constructor(private empSvc: EmployeeService) {
    // (document.getElementsByName('button')[0]).addEventListener("click", this.getEmployees)
  }
  ngOnInit(): void {
    this.getDataFromServer()
  }

  // updateFilterText(newText: string) {
  //   console.log(newText)
  //   this.filterText = newText
  // }

  private getDataFromServer() {
    this.empSvc
      .fetcAllEmployee()
      .subscribe(
        (data: Employee[]) => {
          this.employees = data
          setTimeout(() => {
            this.responseResult = undefined
          }, 1000)
        }
      )
  }

  deleteRecord(id: number) {
    this.empSvc
      .deleteEmployee(id)
      .subscribe(
        (result) => {
          this.responseResult = result
          this.getDataFromServer()
        }
      )
  }
}

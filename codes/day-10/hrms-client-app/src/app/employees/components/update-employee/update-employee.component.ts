import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from '../../models/employee.model';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-update-employee',
  templateUrl: './update-employee.component.html',
  styleUrls: ['./update-employee.component.css']
})
export class UpdateEmployeeComponent implements OnInit {

  employeeInfo?:Employee;
  constructor(private route: ActivatedRoute, private router: Router, private empSvc: EmployeeService) { }

  ngOnInit(): void {
    const allParams = this.route.params
    allParams
      .subscribe(
        parameters =>
          this.empSvc
            .fetchEmployee(parseInt(parameters["id"]))
            .subscribe(e => this.employeeInfo = e)
      )    
  }

  submitData(obj: Employee) {
    this.empSvc
      .updateEmployee(obj)
      .subscribe(resp => {
        alert(resp.message)
        this.router.navigate(['/employees'])
      }
      )
  }

}

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../../models/employee.model';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  constructor(private empSvc: EmployeeService, private router: Router) { }

  ngOnInit(): void {
  }

  submitData(obj: Employee) {
    this.empSvc
      .addEmployee(obj)
      .subscribe(resp => {
        alert(resp.message)
        this.router.navigate(['/employees'])
      }
      )
  }
}

import { Component, OnInit, OnDestroy, OnChanges, SimpleChanges } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../../models/employee.model';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-view-employee',
  templateUrl: './view-employee.component.html',
  styleUrls: ['./view-employee.component.css']
})
export class ViewEmployeeComponent implements OnInit, OnDestroy, OnChanges {

  emoloyeeInfo?: Employee;
  constructor(private route: ActivatedRoute, private empSvc: EmployeeService) {

  }
  ngOnChanges(changes: SimpleChanges): void {

  }
  ngOnDestroy(): void {

  }

  ngOnInit(): void {
    const allParams = this.route.params
    allParams
      .subscribe(
        parameters =>
          this.empSvc
            .fetchEmployee(parseInt(parameters["id"]))
            .subscribe(e => this.emoloyeeInfo = e)
      )
  }



}

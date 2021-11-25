import { Component } from "@angular/core";
import { Employee } from "../../models/employee.model";

@Component({
    selector: 'app-employees',
    templateUrl: './employee-list.component.html'
})
export class EmployeeListComponent {
    employees: Employee[] = [{
        Employeeid: 1,
        Employeename: 'joydip',
        Employeesalary: 2000,
        Location: 'Bangalore'
    }];
}
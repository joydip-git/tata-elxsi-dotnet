import { Pipe, PipeTransform } from "@angular/core";
import { Employee } from "../models/employee.model";
import { EmployeeService } from "../services/employee.service";

@Pipe({
    name: 'employeefilter'
})
export class EmployeesPipe implements PipeTransform {
    constructor(private empSvcRef: EmployeeService) {

    }
    transform(value: Employee[], ...args: string[]) {
        return (value && value.length > 0 && args && args[0] && args[0] !== '') ? this.empSvcRef.searchEmployees(value, args[0]) : value;
    }
}
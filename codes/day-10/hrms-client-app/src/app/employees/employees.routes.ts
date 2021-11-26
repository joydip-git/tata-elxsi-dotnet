import { Routes } from "@angular/router";
import { AddEmployeeComponent } from "./components/add-employee/add-employee.component";
import { EmployeeListComponent } from "./components/employee-list/employee-list.component";
import { UpdateEmployeeComponent } from "./components/update-employee/update-employee.component";
import { ViewEmployeeComponent } from "./components/view-employee/view-employee.component";

export const employeeRoutes: Routes = [
    {
        path: 'employees',
        component: EmployeeListComponent
    },
    {
        path: 'employees/add',
        component: AddEmployeeComponent
    },
    {
        path: 'employees/view/:id',
        component: ViewEmployeeComponent
    },
    {
        path: 'employees/update/:id',
        component: UpdateEmployeeComponent
    }
]
import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { employeeRoutes } from "./employees.routes";

@NgModule({
    imports: [RouterModule.forRoot(employeeRoutes)],
    exports: [RouterModule]
})
export class EmployeesRoutingModule {

}
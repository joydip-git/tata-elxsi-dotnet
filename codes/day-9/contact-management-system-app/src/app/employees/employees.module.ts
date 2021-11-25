import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { EmployeeListComponent } from "./components/employee-list/employee-list.component";

@NgModule({
    declarations: [EmployeeListComponent],
    imports: [CommonModule],
    exports: [EmployeeListComponent],
    providers: [],
    bootstrap: [EmployeeListComponent]
})
export class EmployeesModule {

}
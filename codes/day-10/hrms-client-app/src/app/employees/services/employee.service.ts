import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http'
import { environment } from "../../../environments/environment";

//@Injectable({ providedIn: "root" })

@Injectable()
export class EmployeeService {

    constructor(private http: HttpClient) {

    }

    addEmployee(obj: any) {
        this.http.post(`${environment.employeeBaseUrl}\add`, obj)
    }

    fetcAllEmployee() {
        this.http.get(`${environment.employeeBaseUrl}\fetchall`)
    }
}
import { Injectable } from "@angular/core";
import { HttpClient, HttpResponse } from '@angular/common/http'
import { environment } from "../../../environments/environment";
import { Employee } from "../models/employee.model";
import { map, Observable } from "rxjs";

//@Injectable({ providedIn: "root" })

@Injectable()
export class EmployeeService {

    constructor(private http: HttpClient) {

    }

    addEmployee(obj: any) {
        this.http.post(`${environment.employeeBaseUrl}/add`, obj)
    }

    fetcAllEmployee(): Observable<Employee[]> {
        const data: Observable<object>
            = this.http
                .get(`${environment.employeeBaseUrl}/fetchall`)
        return data.pipe(
            map(d => <Employee[]>d)
        )
    }
}
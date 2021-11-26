import { Injectable } from "@angular/core";
import { HttpClient, HttpResponse } from '@angular/common/http'
import { environment } from "../../../environments/environment";
import { Employee } from "../models/employee.model";
import { map, Observable } from "rxjs";
import { ResponseMessage } from "../models/responsemessage.model";

//@Injectable({ providedIn: "root" })

@Injectable()
export class EmployeeService {

    constructor(private http: HttpClient) {

    }

    addEmployee(obj: Employee): Observable<ResponseMessage> {
        return this.http.post(`${environment.employeeBaseUrl}/add`, obj).pipe(
            map(resp => <ResponseMessage>resp)
        );
    }

    fetcAllEmployee(): Observable<Employee[]> {
        const data: Observable<object>
            = this.http
                .get(`${environment.employeeBaseUrl}/fetchall`)
        return data.pipe(
            map(d => <Employee[]>d)
        )
    }

    deleteEmployee(id: number): Observable<ResponseMessage> {
        return this.http.delete(`${environment.employeeBaseUrl}/delete/${id}`).pipe(
            map(resp => <ResponseMessage>resp)
        );
    }
    searchEmployees(employees: Employee[], searchText: string): Employee[] {
        return employees.filter(e => e.employeename.toLocaleLowerCase().indexOf(searchText.toLocaleLowerCase()) !== -1);
    }
}
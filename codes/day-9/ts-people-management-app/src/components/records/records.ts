import { PeopleManager } from "../../manager/peoplemanager";
import { Person } from "../../models/person";

function getData() {
    const manager = new PeopleManager();
    const data:Person[] = manager.fetch();
    const tbl = document.getElementById("tbl1")
    for (let index = 0; index < data.length; index++) {
        const p = data[index];
        const tr = document.createElement('tr')

        const tdName = document.createElement('td')
        tdName.innerText = p.name

        const tdSalary = document.createElement('td')
        tdSalary.innerText = p.salary.toString()

        tr.appendChild(tdName)
        tr.appendChild(tdSalary)
        tbl?.appendChild(tr)
    }
}
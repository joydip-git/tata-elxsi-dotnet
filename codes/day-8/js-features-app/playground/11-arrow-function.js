class Person {
    constructor(name, id, salary) {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    print = () => {
        return `${this.name}, ${this.salary}`
    }
}

const people = [
    new Person("joy", 1, 3000),
    new Person("anil", 3, 2000),
    new Person("sunil", 2, 1000)
]

function printSalary(printFn) {
    console.log(printFn())
}
for (let index = 0; index < people.length; index++) {
    const p = people[index];
    //p.print()
    //printFn is unbound
    let printFn = p.print;
    //now printFn is bound function
    //printFn = printFn.bind(p);
    printSalary(printFn)
}

function add(a, b) { return a + b }
const subtract = function (a, b) { return a - b }
const multiply = (a, b) => a + b
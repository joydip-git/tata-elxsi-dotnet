export class Person {
    constructor(name, id, salary) {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    print() {
        return `${this.name}, ${this.salary}`
    }
}
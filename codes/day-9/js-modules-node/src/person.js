class Person {
    constructor(name, id, salary) {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    print() {
        return `${this.name}, ${this.salary}`
    }
}
// const x = 13;
//common js format to export members of a file (module)
module.exports = {
    Person
    // Person: Person,
    // xValue: x
}
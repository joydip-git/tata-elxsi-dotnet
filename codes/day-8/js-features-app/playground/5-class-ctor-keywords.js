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
console.log(Person.prototype)
var joydipObj = new Person("joydip", 1, 1000);
var anilObj = new Person("anil", 2, 2000);
console.log(joydipObj.print())
console.log(anilObj.print())
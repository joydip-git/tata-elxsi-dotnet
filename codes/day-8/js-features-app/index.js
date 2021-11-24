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
class Trainer extends Person {
    constructor(name, id, salary, domain) {
        super(name, id, salary)
        this.domain = domain
    }
    print() {
        const partial = super.print()
        return `${partial}, ${this.domain}`
    }
}

const joydipObj = new Trainer("joy", 1, 1000, "JS frameworks")
console.log(joydipObj.print())
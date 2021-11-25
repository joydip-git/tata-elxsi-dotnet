//common js format to import types from other files(modules)
// const personExportsObject = require('./person')
const { Person } = require('./person')

// class Trainer extends personExportsObject.Person {
class Trainer extends Person {
    constructor(name, id, salary, domain) {
        super(name, id, salary)
        this.domain = domain;
    }
    print() {
        return `${super.print()}, ${this.domain}`
    }
}
const numbers = [1, 2, 3, 4]
module.exports = {
    Trainer //Trainer:Trainer
}
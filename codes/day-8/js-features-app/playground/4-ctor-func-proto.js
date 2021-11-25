//2. constructor function
function person(name, id, salary) {
    this.name = name;
    this.id = id;
    this.salary = salary;
}
person.prototype.print = function () {
    return `${this.name}, ${this.salary}`
}
var joydipObj = new person("joydip", 1, 1000);
var anilObj = new person("anil", 2, 2000);
console.log(joydipObj.print())
console.log(anilObj.print())
//console.log(joydipObj.__proto__)
//console.log(person.prototype === joydipObj.__proto__)

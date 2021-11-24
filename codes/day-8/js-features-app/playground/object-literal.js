//1. object-literal syntax
var anilObj = {
    //data/value properties
    name: "anil",
    id: 1,
    salary: 2000,

    //functional property
    print: function () {
        return `${this.name}, ${this.id}, ${this.salary}`
    }
}

// var sunilObj = {
//     //data/value properties
//     name: "sunil",
//     id: 2,
//     salary: 3000,

//     //functional property
//     print: function () {
//         return `${this.name}, ${this.id}, ${this.salary}`
//     }
// }
anilObj.location = "bengaluru"
anilObj.getLocation = function () {
    return this.location;
}
console.log(anilObj.print())
console.log(anilObj.getLocation())

anilObj.__proto__.sayHi = function () {
    console.log('hello')
}
//console.log(anilObj.__proto__)

console.log(anilObj.hasOwnProperty("sayHi"))
console.log(anilObj.__proto__.hasOwnProperty("sayHi"))
anilObj.sayHi()
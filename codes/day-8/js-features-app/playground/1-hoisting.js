//console.log(x) //undefined
let x
x = 10
console.log(x) //10

//show()
//function declaration: hoisted
function show() {
    var x = 30;
    console.log(x)
    console.log('show')
}
console.log(x)
show()
console.log(x)

for (var i = 0; i < 2; i++) {
    let x
    x = 20
    console.log(x)//20
}

console.log(x)//20

var call

console.log(call)
//call()
//function expression
call = function () {
    console.log('call')
}
call()
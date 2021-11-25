const numbers = [1, 2, 3, 4]
// const copyNumbers = [];
// for (let index = 0; index < numbers.length; index++) {
//     const num = numbers[index];
//     copyNumbers.push(num)
// }

//spread operator
const another = [10, 20, 80, 90]
// const copyNumbers = [10, 20, ...numbers, 90, 80]
const copyNumbers = [...numbers, ...another]
console.log(numbers)
console.log(copyNumbers)

const anilObj = {
    name: 'anil',
    id: 1
}
// console.log(anilObj.name)
// console.log(anilObj['id'])


// const copyAnilObj = {};
// for (const propName in anilObj) {
//     const propValue = anilObj[propName]
//     //console.log(`${propName}:${propValue}`)
//     copyAnilObj[propName] = propValue
// }

const copyAnilObj = { ...anilObj };

console.log(anilObj)
console.log(copyAnilObj)
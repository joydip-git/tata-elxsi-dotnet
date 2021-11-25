const anilObj = {
    name: 'anil',
    id: 1,
    salary: 1000,
    location: 'bangalore',
    subject: 'JS'
}

// const nameValue = anilObj.name
// const locValue = anilObj['location']

const { name: nameValue, location: locValue } = anilObj;

console.log(nameValue)
console.log(locValue)

const numbers = [1, 2, 3, 4]
const [x, y] = numbers;
console.log(x)
console.log(y)
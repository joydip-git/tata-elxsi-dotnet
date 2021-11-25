function isEven(num) {
    return num % 2 == 0
}
function isOdd(num) {
    return num % 2 != 0
}

const isGreaterThanFive = function (num) {
    return num > 5
}

function filter(input, fnLogic) {
    const result = []

    for (let index = 0; index < input.length; index++) {
        const value = input[index];
        if (fnLogic(value)) {
            result.push(value)
        }
    }
    return result
}

const numbers = [1, 4, 2, 6, 3, 7, 0, 8, 5, 9]
const resultArray = filter(numbers, isGreaterThanFive)

for (let index = 0; index < resultArray.length; index++) {
    console.log(resultArray[index])
}
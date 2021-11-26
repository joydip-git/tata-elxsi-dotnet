async function divide(a, b) {
    // const promiseObj = new Promise(
    //     //executor function
    //     (resolveFn, rejectFn) => {
    //         //code
    //         const res = a / b;
    //         if (res === Infinity) {
    //             // throw new Error("denominator should not be zero")
    //             rejectFn("denominator should not be zero")
    //         }
    //         resolveFn(res)
    //     }
    // );
    // return promiseObj;

    const res = a / b;
    if (res === Infinity)
        throw new Error("denominator should not be zero");

    return res;
}


function getData() {
    return new Promise(
        (resolveFnRef, rejectFnRef) => {
            fetch('http://localhost:41723/api/Employees/fetchall')
                .then(
                    (data) => {
                        data
                            .json()
                            .then(
                                (d) => {
                                    resolveFnRef(d)
                                },
                                (e) => {
                                    rejectFnRef(e)
                                })
                    },
                    (er) => {
                        rejectFnRef(er)
                    }
                )
        }
    )
}
function add(a, b) {
    return (a + b)
}

// const divPromise = divide(12, 0)
// divPromise
//     .then(
//         (data) => {
//             console.log(data)
//         },
//         (err) => {
//             console.log(err)
//         }
//     )
//     .catch(
//         (e) => {
//             console.log(e)
//         }
//     )

//Immediately Invocable Function Expression (IIFE)
(async function () {
    const data = await divide(12, 3)
    console.log(data)
})();

getData()
    .then(
        (employees) => console.log(employees),
        (er) => console.log(er)
    )
const addRes = add(12, 3)
console.log(addRes)
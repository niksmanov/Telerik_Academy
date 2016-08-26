function solve(input) {
    "use strict";

    let firstCheck = input[0].split('(').length - 1;
    let secondCheck = input[0].split(')').length - 1;

    if (firstCheck === secondCheck) {
        console.log('Correct');
    }
    else {
        console.log('Incorrect');
    }
}
// solve(['((a+b)/5-d)']);
// solve([')(a+b))']);
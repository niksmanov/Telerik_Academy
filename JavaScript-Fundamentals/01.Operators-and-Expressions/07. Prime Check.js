function primeCheck(input) {
    "use strict";

    var num = Number(input[0]);

    if (num <= 1) {
        console.log('false');
    }
    else if (num > 1 && num <= 100) {
        if (num === 2 || num === 3 || num === 5 || num === 7) {
            console.log('true');
        }
        else {
            if (num % 2 !== 0 || num % 3 !== 0 || num % 5 !== 0 || num % 7 !== 0) {
                console.log('true');
            }
            else {
                console.log('false');
            }
        }
    }
}

// primeCheck([2]);
// primeCheck([23]);
// primeCheck([-3]);
// primeCheck([0]);
// primeCheck([1]);

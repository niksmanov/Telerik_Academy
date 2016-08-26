function thirdDigit(input) {
    "use strict";

    var number = Number(input[0]);
    var newNumber = Math.floor(number / 100) % 10; //((number / 100) | 0) remove floating 12.3 -> 12
    if (newNumber === 7) {
        console.log('true');
    }
    else {
        console.log('false ' + newNumber);
    }
}

// thirdDigit([5]);
// thirdDigit([701]);
// thirdDigit([9999799]);

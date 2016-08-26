function oddOrEven(input) {
    'use strict';

    var number = Number(input[0]);
    if (number % 2 === 0) {
        console.log('even ' + number);
    }
    else {
        console.log('odd ' + number);
    }
}

//oddOrEven([2]);
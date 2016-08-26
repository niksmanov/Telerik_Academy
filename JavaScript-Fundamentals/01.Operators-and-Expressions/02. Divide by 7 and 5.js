function devide(input) {
    'use strict';

    var number = Number(input[0]);

    if (number % 5 === 0 && number % 7 === 0) {
        console.log('true ' + number);
    }
    else {
        console.log('false ' + number);
    }
}

//devide([3]);

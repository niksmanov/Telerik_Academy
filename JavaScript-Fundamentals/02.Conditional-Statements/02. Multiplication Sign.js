function multiplication(input) {
    "use strict";

    var a = Number(input[0]);
    var b = Number(input[1]);
    var c = Number(input[2]);

    if (a * b * c > 0) {
        console.log('+');
    }
    else if (a * b * c < 0) {
        console.log('-');
    }
    else {
        console.log('0');
    }
}

// multiplication([5, 2, 2]);
// multiplication([-2, 4, 3]);
// multiplication([0, -2.5, 4]);


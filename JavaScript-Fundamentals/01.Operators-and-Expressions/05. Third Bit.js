function thirdBit(input) {
    "use strict";

    var number = Number(input[0]);
    var mask = number >> 3;
    var check = mask & 1;

    console.log(check);
}

// thirdBit([15]);
// thirdBit([1024]);
function sorting(input) {
    "use strict";

    var arrLength = input[0];
    var arr = input[1].split(' ').map(Number);

    var sorted = arr.sort(function (a, b) {
        return a - b});

    console.log(sorted.join(' '));
}

// sorting(['6', '3 4 1 5 2 6']);
// sorting(['10', '36 10 1 34 28 38 31 27 30 20']);
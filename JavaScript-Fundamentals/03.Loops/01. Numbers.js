function numbers(input) {
    "use strict";

    var number = Number(input[0]);
    var line = '';

    for (var i = 1; i <= number; i += 1) {
        line += ' ' + i;
    }
    console.log(line);
}

// numbers([5]);
// numbers([1]);

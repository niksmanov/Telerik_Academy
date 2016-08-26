function biggest(input) {
    "use strict";
    var a = Number(input[0]);
    var b = Number(input[1]);
    var c = Number(input[2]);

    var max = Math.max(a, b, c);
    console.log(max);
}

// biggest([5, 2, 2]);
// biggest([-2, -2, 1]);
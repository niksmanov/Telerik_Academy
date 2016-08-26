function biggest(input) {
    "use strict";
    var a = Number(input[0]);
    var b = Number(input[1]);
    var c = Number(input[2]);
    var d = Number(input[3]);
    var e = Number(input[4]);

    var max = Math.max(a, b, c, d, e);
    console.log(max);
}

// biggest([5, 2, 2, 4, 1]);
// biggest([-2, -22, 1, 0, 0]);

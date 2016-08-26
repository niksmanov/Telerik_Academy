function sort(input) {
    "use strict";

    var a = Number(input[0]);
    var b = Number(input[1]);
    var c = Number(input[2]);

    var numArray = [a, b, c].sort(function(a,b) { return b-a; });
    console.log(numArray.join(' '));

}

// sort([5, 1, 2]);
// sort([-2, -2, 1]);
// sort([10, 20, 30]);

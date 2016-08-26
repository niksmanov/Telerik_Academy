function exchange(input) {
    "use strict";

    var a = Number(input[0]);
    var b = Number(input[1]);

    if (a > b) {
        console.log(b, a);
    }
    else {
        console.log(a, b);
    }
}

// exchange([5, 2]);
// exchange([3,4]);
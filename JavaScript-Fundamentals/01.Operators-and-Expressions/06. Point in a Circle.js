function pointInCircle(input) {
    "use strict";

    var x = Number(input[0]);
    var y = Number(input[1]);

    var distance = Math.sqrt(Math.pow(0 - x, 2) + Math.pow(0 - y, 2));

    if (Math.pow((x - 0), 2) + Math.pow((y - 0), 2) <= Math.pow(2, 2)) {
        console.log('yes ' + distance.toFixed(2));
    }
    else {
        console.log('no ' + distance.toFixed(2));
    }
}

// pointInCircle([-2, 0]);
// pointInCircle([-1, 2]);
// pointInCircle([1.5, -1]);

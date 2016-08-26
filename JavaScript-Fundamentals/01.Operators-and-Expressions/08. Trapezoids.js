function trapezoids(input) {
    "use strict";

    var a = Number(input[0]);
    var b = Number(input[1]);
    var h = Number(input[2]);

    var area = ((a + b) * h) / 2;
    console.log(area.toFixed(7));
}

// trapezoids([5, 7, 12]);
// trapezoids([2, 1, 33]);
// trapezoids([8.5, 4.3, 2.7]);
// trapezoids([100, 200, 300]);
// trapezoids([0.222, 0.333, 0.555]);

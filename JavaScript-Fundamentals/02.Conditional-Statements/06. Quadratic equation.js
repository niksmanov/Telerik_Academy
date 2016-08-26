function quadratic(input) {
    "use strict";

    var a = Number(input[0]);
    var b = Number(input[1]);
    var c = Number(input[2]);


    var d = (b * b) - (4 * a * c);

    var x1 = (((-b - Math.sqrt(d)) / (2 * a)).toFixed(2));
    var x2 = (((-b + Math.sqrt(d)) / (2 * a)).toFixed(2));

    if (d < 0) {
        console.log('no real roots');
    }
    else if (d === 0) {
        console.log('x1=x2=' + ((-b / (2 * a)).toFixed(2)));
    }

    else {
        console.log('x1=' + x1 + '; x2=' + x2);
    }
}

// quadratic([2, 5, -3]);
// quadratic([-1, 3, 0]);
// quadratic([-0.5, 4, -8]);
// quadratic([5, 2, 8]);
// quadratic([0.2, 9.572, 0.2]);


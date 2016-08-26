function mmsa(input) {
    "use strict";

    var min = +input[0];
    var max = +input[0];
    var sum = +input[0];
    var avg = 0;

    for (var i = 1; i < input.length; i += 1) {
        if (min > +input[i]) {
            min = +input[i];
        }
        if (max < +input[i]) {
            max = +input[i];
        }
        sum += +input[i];
    }
    avg = sum / input.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}

// mmsa([2, 5, 1]);
// mmsa([2, -1, 4]);
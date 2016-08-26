function largestNumber(input) {
    "use strict";

    var arr = input[0].split(' ').map(Number);
    var max = Math.max.apply(null, arr);

    console.log(max);

}

//largestNumber(['8 3 6']);
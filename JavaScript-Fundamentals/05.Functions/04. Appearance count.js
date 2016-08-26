function count(input) {
    "use strict";

    var arrLength = input[0];
    var arr = input[1].split(' ');

    var count = 0;
    for (var i = 0; i < arr.length; i += 1) {
        if (arr[i] === input[2]) {
            count += 1;
        }
    }
    console.log(count);
}

//count(['8', '28 6 21 6 -7856 73 73 -56', '73']);
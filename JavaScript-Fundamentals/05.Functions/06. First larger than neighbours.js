function larger(input) {
    "use strict";

    var arrLength = input[0];
    var arr = input[1].split(' ').map(Number);

    var count = 0;
    for (var i = 1; i < arr.length - 1; i += 1) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            count = arr.indexOf(arr[i]);
            break;
        }
    }
    console.log(count);
}

//larger(['6', '-26 -25 -28 31 2 27']);
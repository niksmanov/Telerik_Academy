function binarySearch(numbers) {
    "use strict";

    var array = numbers.split('\n').map(Number);
    var n = +array[0];
    var wantedNum = +array[array.length - 1];

    array.shift();
    array.pop();

    var low = 0;
    var high = n - 1;
    var mid = ((high + low) / 2) | 0;
    var wantedNumberIsFound = false;

    while (low <= high) {
        if (wantedNum === +array[mid]) {
            wantedNumberIsFound = true;
            console.log(mid);
            return;
        }
        else if (wantedNum < +array[mid]) {
            high = mid - 1;
            mid = ((high + low) / 2) | 0;
        }
        else if (wantedNum > +array[mid]) {
            low = mid + 1;
            mid = ((high + low) / 2) | 0;
        }
    }
    console.log('-1');
}

//binarySearch(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32'])
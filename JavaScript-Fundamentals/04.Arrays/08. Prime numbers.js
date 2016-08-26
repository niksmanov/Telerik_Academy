function primeNums(input) {
    "use strict";

    var number = (input[0]);

    for (var i = number; i >= 0; i -= 1) {
        var isPrime = true;

        for (var j = 2; j < i; j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            console.log(i);
            break;
        }
    }
}

// primeNums([13]);
// primeNums([126]);
// primeNums([26]);
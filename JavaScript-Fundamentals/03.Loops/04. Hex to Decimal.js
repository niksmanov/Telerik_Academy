function hexToDec(input) {
    "use strict";

    var input = String(input);

    var hexDigits = '0123456789ABCDEF';
    var decNumber = 0;

    for (var i = 0; i < input.length; i += 1) {
        var digit = hexDigits.indexOf(input[i]);

        decNumber = digit + decNumber* 16;
    }
    console.log(decNumber);
}

// hexToDec(['FE']);
// hexToDec(['1AE3']);
// hexToDec(['4ED528CBB4']);


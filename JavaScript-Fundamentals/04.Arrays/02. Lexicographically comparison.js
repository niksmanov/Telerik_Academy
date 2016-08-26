function lexComparison(args) {
    "use strict";

    var input = args[0].split('\n');
    var first = input[0];
    var second = input[1];
    var length = 0;
    var found = false;

    if (first.length >= second.length) {
        length = second.length;
    }
    else {
        length = first.length;
    }

    for (var i = 0; i < length; i += 1) {
        if (first[i] < second[i]) {
            console.log('<');
            found = true;
            break;
        }
        else if (first[i] > second[i]) {
            console.log('>');
            found = true;
            break;
        }
    }
    if (!found) {
        if (first.length > second.length) {
            console.log('>');
        }
        else if (first.length === second.length) {
            console.log('=');
        }
        else {
            console.log('<');
        }
    }
}

// lexComparison(['hello\nhalo']);
// lexComparison(['food\nfood']);
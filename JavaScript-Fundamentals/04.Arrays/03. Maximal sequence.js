function maxSeq(input) {
    "use strict";

    var arr = input[0].split('\n');
    var currSeq = 0;
    var maxSeq = 0;

    for (var i = 0; i < arr.length - 1; i += 1) {
        if (arr[i] === arr[i + 1]) {
            currSeq += 1;
        }
        else {
            currSeq = 1;
        }
        if (currSeq > maxSeq) {
            maxSeq = currSeq;
        }
    }
    console.log(maxSeq);
}

//maxSeq(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);
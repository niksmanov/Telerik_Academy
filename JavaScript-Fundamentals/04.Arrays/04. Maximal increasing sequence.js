function incrSeq(input) {
    "use strict";

    var arr = input[0].split('\n');

    var maxIncrSeq = 1;

    for (var i = 1; i < arr.length; i += 1) {
        var incrSeq = 1;
        for (var j = i + 1; j < arr.length; j += 1) {
            if (arr[j] > arr[j-1]) {
                incrSeq+=1;
            }
            else {
                if (incrSeq > maxIncrSeq) {
                    maxIncrSeq = incrSeq;
                }
                break;
            }
        }
    }
    console.log(maxIncrSeq);
}
//incrSeq(['8\n7\n3\n2\n3\n4\n2\n2\n4']);

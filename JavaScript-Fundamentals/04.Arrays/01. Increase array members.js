function incrArr(input) {
    "use strict";

    var arr = input.map(Number);

    for (var i = 0; i < arr; i += 1) {
     console.log(i * 5);
    }
}

//incrArr([5]);
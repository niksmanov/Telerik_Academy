function freqNumber(input) {
    "use strict";

    var arr = input[0].split('\n');
    arr.shift();

    arr.sort(function(a, b) {
    return a - b});
	
    var counter = 1;
    var maxCounter = 0;
    var number = 0;


    for (var i = 0; i < arr.length; i += 1) {
        if (arr[i] === arr[i + 1]) {
            counter += 1;
        }
        else {
            counter = 1;
        }
        if (counter > maxCounter) {
            maxCounter = counter;
            number = arr[i];
        }
    }
    console.log(number + ' (' + maxCounter + ' times)');
}

//freqNumber(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);
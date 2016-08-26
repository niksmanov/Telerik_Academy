function sort(input) {
    "use strict";

    var arr = input[0].split('\n');
    arr.shift();

    arr.sort(function(a, b) {
    return a - b});
	
    for (var i = 0; i < arr.length; i += 1) {
        console.log(arr[i]);
    }
}

//sort(['6\n3\n4\n1\n5\n2\n6']);
//sort(['10\n36\n10\n1\n34\n28\n38\n31\n27\n30\n20']);
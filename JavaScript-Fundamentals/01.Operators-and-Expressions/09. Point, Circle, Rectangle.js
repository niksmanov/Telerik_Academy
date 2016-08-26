function pcr(input) {
    "use strict";

    var x = Number(input[0]);
    var y = Number(input[1]);

    var circle = Math.pow((x - 1), 2) + Math.pow((y - 1), 2) <= Math.pow(1.5, 2);
    var rectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

    if (circle && !rectangle) {
        console.log("inside circle outside rectangle");
    }
    else if (!circle && rectangle) {
        console.log("outside circle inside rectangle");
    }
    else if (circle && rectangle) {
        console.log("inside circle inside rectangle");
    }
    else {
        console.log("outside circle outside rectangle");
    }
}

// pcr([2.5, 2]);
// pcr([0, 1]);
// pcr([2.5, 1]);
// pcr([1, 2]);
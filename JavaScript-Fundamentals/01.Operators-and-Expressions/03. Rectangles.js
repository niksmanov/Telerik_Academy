function rectangles(input) {
    'use strict';

    var width = Number(input[0]);
    var heigh = Number(input[1]);

    var area = width * heigh;
    var perimeter = (width * 2) + (heigh * 2);

    console.log(area.toFixed(2), perimeter.toFixed(2));

}

//rectangles(['2.5', '3']);
(function () {
    "use strict";

    const mapPromise = new Promise((resolve, reject) => {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(resolve);
        }
        else {
            reject();
        }
    });

    function parsePosition(pos) {
        return {
            lat: pos.coords.latitude,
            long: pos.coords.longitude
        };
    }

    function displayMap(pos) {
        let map = {
            source: document.getElementById('map'),
            zoom: 18,
            height: 1024,
            width: 1024
        };

        let src = `http://maps.googleapis.com/maps/api/staticmap?center=${pos.lat},${pos.long}&zoom=${map.zoom}&size=${map.width}x${map.height}`;

        map.source.setAttribute('src', src);
    }

    mapPromise
        .then(parsePosition)
        .then(displayMap);
}());

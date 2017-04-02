(function () {
    "use strict";

    let div = document.createElement('div');
    div.innerText = 'Redirecting to Google main page...';
    document.body.appendChild(div);

    const redirectPromise = new Promise((resolve, reject) => {
        setTimeout(function () {
            resolve("https://www.google.bg/")
        }, 2000)
    });

    redirectPromise
        .then((address) => window.location = address);
}());
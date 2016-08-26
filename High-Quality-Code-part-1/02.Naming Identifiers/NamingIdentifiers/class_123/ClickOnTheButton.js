function buttonClick(event, args) {

    var newWindow = window;
    var browser = newWindow.navigator.appCodeName;
    var message = browser === "Mozilla";

    if (message) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
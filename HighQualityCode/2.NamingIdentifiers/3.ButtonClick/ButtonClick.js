function onButtonClick(caller, args) {
    var browser = window.navigator.appCodeName,
        isBrowserMozilla;
    if (browser === "Mozilla") {
        isBrowserMozilla = true;
    }

    if (isBrowserMozilla) {
        alert("Browser is Mozilla");
    }
    else {
        alert("Browser isn't Mozilla");
    }
}

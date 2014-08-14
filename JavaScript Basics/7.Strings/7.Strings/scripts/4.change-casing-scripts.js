function changeCasing(text) {
    text = text.split(/[<>]+/);
    var replacedString = "";

    debugger;
    for (var i = 0; i < text.length; i++) {
        if (text[i] === "mixcase") {
            if (i + 1 < text.length) {
                for (var j = 0; j < text[i + 1].length; j++) {
                    if (Math.random() > 0.4) {
                        replacedString += text[i + 1][j];
                    }
                    else {
                        replacedString += text[i + 1][j].toUpperCase();
                    }
                }
                i += 2;
            }
        }
        else if (text[i] === "upcase") {
            if (i + 1 < text.length) {
                replacedString += text[i + 1].toUpperCase();
                i += 2;
            }
        }
        else if (text[i] === "lowcase") {
            if (i + 1 < text.length) {
                replacedString += text[i + 1].toLowerCase();
                i += 2;
            }
        }
        else {
            replacedString += text[i];
        }
    }

    return replacedString;

}

console.log(changeCasing('text<upcase>yellow</upcase>.<upcase>black</upcase><mixcase>green</mixcase>'))
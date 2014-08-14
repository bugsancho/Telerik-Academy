function getNestedDivsQuerySelector() {
    var divs = document.body.querySelectorAll('div > div');
    for (var i = 0; i < divs.length; i++) {
        console.log(divs[i].outerHTML)
    }
}

function getNestedDivsTagName() {
    var allDivs = document.body.getElementsByTagName('div'),
        nestedDivs = [],
        i;

    for (i = 0; i < allDivs.length; i++) {
        if (allDivs[i].parentNode.nodeName === "DIV") {
            nestedDivs.push(allDivs[i]);
        }
    }

    for (i = 0; i < nestedDivs.length; i++) {
        console.log(nestedDivs[i].outerHTML);
    }
}
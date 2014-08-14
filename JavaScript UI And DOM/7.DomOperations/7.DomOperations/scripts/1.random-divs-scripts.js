window.onload = function () {
    var generatorBtn = document.getElementById('divs-generator');
    generatorBtn.addEventListener('click', generateRandomDiv);
    var clearBtn = document.getElementById('divs-exterminator');
    clearBtn.addEventListener('click', clearDivs);    
}

function generateRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1) + min)
}

function generateRandomColor() {
    var red = generateRandomNumber(0, 255);
    var green = generateRandomNumber(0, 255);
    var blue = generateRandomNumber(0, 255);
    return 'rgb(' + red + ',' + green + ',' + blue + ')';
}

function generateRandomDiv() {
    var div = document.createElement('div');
    var strong = document.createElement('strong');
    strong.innerHTML = 'div';
    div.appendChild(strong);
    //size
    div.style.width = generateRandomNumber(20, 100) + 'px';
    //color
    div.style.height = generateRandomNumber(20, 100) + 'px';
    div.style.backgroundColor = generateRandomColor();
    div.style.color = generateRandomColor();
    // border
    div.style.borderColor = generateRandomColor();
    div.style.borderWidth = generateRandomNumber(1, 20) + 'px';
    div.style.borderRadius = generateRandomNumber(1, 100) + 'px';
    div.style.borderStyle = 'solid';
    //position
    div.style.position = 'absolute';
    div.style.top = generateRandomNumber(20, window.innerHeight) + 'px';
    div.style.left = generateRandomNumber(20, window.innerWidth) + 'px';
    div.style.textAlign = 'center';

    var container = document.getElementById('divs-container');
    container.appendChild(div);
}

function clearDivs() {
    var container = document.getElementById('divs-container');
    while (container.firstChild) {
        container.removeChild(container.firstChild);
    }
}
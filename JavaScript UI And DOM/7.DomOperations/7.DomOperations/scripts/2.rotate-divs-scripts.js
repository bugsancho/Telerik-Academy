function generateDiv() {
    var div = document.createElement('div');
    div.style.width = '30px';
    div.style.height = '30px';
    div.style.backgroundColor = 'red';
    div.style.position = 'absolute';
    div.style.borderRadius = '50px';
    return div;
}

window.onload = function () {
    var center = {
        x: 200,
        y: 200,
        radius: 100
    },
    divs = [],
    numberOfDivs = 2,
    degreeFraction = 360 / numberOfDivs;
    // initalize divs
    for (var i = 0; i < numberOfDivs; i++) {
        var currentDiv = generateDiv();

        currentDiv.style.left = Math.floor(center.x + (center.radius * Math.cos((degreeFraction * i) * (Math.PI / 180)))) + 'px';
        currentDiv.style.top = Math.floor(center.x + (center.radius * Math.sin((degreeFraction * i) * (Math.PI / 180)))) + 'px';
        divs.push(currentDiv);
        document.body.appendChild(currentDiv);
    }
    console.log(divs[0].style.left);
    function rotateDivs(time, div) {
        time = time + 0.1; // "time"       
        x = Math.floor(center.x + (center.radius * Math.cos(time))), //circles parametric function
        y = Math.floor(center.y + (center.radius * Math.sin(time))); //circles parametric function
        div.style.top = x + "px"; //set divs new coordinates
        div.style.left = y + "px"; //set divs new coordinates

        setTimeout(function () { //make sure the animation keeps going
            rotateDivs(time, div);
        }, 1000);
    }


    var angle = 0, width = 150, height = 150;
    var step = 2 * Math.PI / ballContainer.children.length;

    setNewCoords();

    function setNewCoords() {
        for (var i = 0; i < ballContainer.children.length; i++) {
            var x = Math.cos(angle + (i * step)) * width;
            var y = Math.sin(angle + (i * step)) * height;

            ballContainer.children[i].style.left = (x + 420) + 'px';
            ballContainer.children[i].style.top = (y + 300) + 'px';
        }

        angle = (angle + 0.02) % (2 * Math.PI);

        setTimeout(setNewCoords, 7);
    }


    rotateDivs(1, divs[1]);
}

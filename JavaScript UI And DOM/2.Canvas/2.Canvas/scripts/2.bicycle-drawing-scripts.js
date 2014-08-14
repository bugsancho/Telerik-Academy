window.onload = function () {
    var canvas = document.getElementById('bike-canvas'),
        context = canvas.getContext('2d');

    // rear tyre
    context.beginPath();
    context.arc(250, 250, 65, 0, 2 * Math.PI);
    context.fillStyle = 'lightblue';
    context.fill();
    context.stroke();

    // front tyre
    context.beginPath();
    context.arc(500, 250, 65, 0, 2 * Math.PI);
    context.fillStyle = 'lightblue';
    context.fill();
    context.stroke();

    // frame
    context.beginPath();
    context.moveTo(250, 250);
    context.lineTo(325, 175);
    context.lineTo(470, 175);
    context.lineTo(360, 250);
    context.lineTo(250, 250);
    // seat
    context.moveTo(360, 250);
    context.lineTo(312, 150);
    context.moveTo(285, 150);
    context.lineTo(335, 150);
    // handles
    context.moveTo(500, 250);
    context.lineTo(452, 130);
    context.lineTo(400, 150);
    context.moveTo(452, 130);
    context.lineTo(490, 90);
    context.stroke();

    // pedals
    context.beginPath();
    context.arc(360, 250, 15, 0, 2 * Math.PI);    
    context.moveTo(347, 240);
    context.lineTo(337, 230);
    context.moveTo(370, 260);
    context.lineTo(380, 270);
    context.stroke();
}
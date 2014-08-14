window.onload = function () {
    var canvas = document.getElementById('house-canvas'),
       context = canvas.getContext('2d');

    // draw main block
    context.rect(200, 200, 290, 215);
    context.fillStyle = 'rgb(151,91,91)';
    context.fill();
    context.lineWidth = 3;
    context.stroke();
    // windows
    context.beginPath();
    context.fillStyle = '000';
    context.rect(225, 225, 100, 70);
    context.rect(365, 225, 100, 70);
    context.rect(365, 320, 100, 70);
    context.fill();
    context.stroke();

    context.beginPath();
    context.strokeStyle = 'rgb(151,91,91)';
    context.lineWidth = 3;
    // horizontal window lines
    context.moveTo(220, 260);
    context.lineTo(330, 260);
    context.moveTo(360, 260);
    context.lineTo(470, 260);
    context.moveTo(360, 355);
    context.lineTo(470, 355);
    // vertical window lines
    context.moveTo(275, 220);
    context.lineTo(275, 300);
    context.moveTo(415, 220);
    context.lineTo(415, 300);
    context.moveTo(415, 315);
    context.lineTo(415, 395);
    context.stroke();

    // door
    context.beginPath();
    context.moveTo(230, 415);
    context.strokeStyle = '000';
    context.lineTo(230, 340);
    context.quadraticCurveTo(230, 320, 270, 315);
    context.moveTo(310, 415);
    context.lineTo(310, 340);
    context.quadraticCurveTo(310, 320, 270, 315);
    context.lineTo(270, 415);
    context.stroke();

    // door handles
    context.beginPath();
    context.arc(255, 385, 5, 0, 2 * Math.PI);
    context.stroke();
    context.beginPath();
    context.arc(285, 385, 5, 0, 2 * Math.PI);
    context.stroke();

    // roof
    context.beginPath();
    context.moveTo(200, 200);
    context.lineTo(345, 35);
    context.lineTo(490, 200);
    context.closePath();
    context.fillStyle = 'rgb(151,91,91)';
    context.fill();
    context.stroke();

    // chimnea
    context.beginPath();
    context.rect(405, 80, 30, 80);
    context.fill();
    context.stroke();
    // chimnea top
    context.beginPath();
    context.save();
    context.scale(3, 1);
    context.lineWidth = 1;
    context.arc(140, 80, 5, 0, 2 * Math.PI);
    context.fill();
    context.stroke();
    context.restore();
    // chimnea bottom line
    context.beginPath();
    context.lineWidth = 5;
    context.strokeStyle = 'rgb(151,91,91)';
    context.moveTo(400, 160);
    context.lineTo(440, 160);
    context.stroke();
}
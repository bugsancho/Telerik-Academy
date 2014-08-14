window.onload = function () {
    var canvas = document.getElementById('meme-canvas'),
        context = canvas.getContext('2d');

    // face
    context.beginPath();
    context.save();
    context.arc(150, 150, 50, 0, 2 * Math.PI);
    context.fillStyle = 'lightblue';
    context.fill();
    context.stroke();
    context.restore();

    // mouth
    context.beginPath();
    context.save();
    context.rotate(10 * Math.PI / 180);
    context.scale(3, 1);
    context.arc(55, 150, 7, 0, 2 * Math.PI);
    context.stroke();
    context.restore();

    // eyes
    context.beginPath();
    context.save();
    context.scale(1.8, 1);
    context.arc(65, 135, 5, 0, 2 * Math.PI);
    context.stroke();
    context.beginPath();
    context.arc(90, 135, 5, 0, 2 * Math.PI);
    context.stroke();
    context.restore();

    // nose
    context.beginPath();
    context.save();
    context.moveTo(140, 135);
    context.lineTo(130, 160);
    context.lineTo(140, 160);
    context.stroke();
    context.restore();

    // pupils
    context.beginPath();
    context.save();
    context.scale(1, 2);
    context.arc(113, 67.5, 2, 0, 2 * Math.PI);
    context.fillStyle = '666';
    context.fill();
    context.stroke();
    context.beginPath();
    context.arc(158, 67.5, 2, 0, 2 * Math.PI);
    context.fillStyle = '666';
    context.fill();
    context.stroke();
    context.restore();

    // hat
    context.beginPath();
    context.save();
    context.scale(5, 1);
    context.arc(30, 105, 12, 0, 2 * Math.PI);
    context.fillStyle = '#aa44aa';
    context.fill();
    context.stroke();
    context.restore();

    // lower base of cylinder
    context.beginPath();
    context.save();
    context.scale(3, 1);
    context.arc(50, 97, 12, 0, 2 * Math.PI);
    context.fillStyle = '#aa44aa';
    context.fill();
    context.stroke();
    context.restore();

    // cylinder body
    context.beginPath();
    context.save();
    context.rect(114, 27,72, 70);
    context.fillStyle = '#aa44aa';
    context.strokeStyle = '#aa44aa';
    context.fill();    
    context.stroke();
    context.restore();

    // cylinder outline
    context.beginPath();
    context.save();
    context.moveTo(113, 27);
    context.lineTo(113, 97);
    context.moveTo(185, 27);
    context.lineTo(185, 97);
    context.lineWidth = 2;
    context.strokeStyle = 'black';
    context.stroke();
    context.restore();
    
    // upper base of cylinder
    context.beginPath();
    context.save();
    context.scale(3, 1);
    context.arc(50, 27, 12, 0, 2 * Math.PI);
    context.fillStyle = '#aa44aa';
    context.fill();
    context.stroke();
    context.restore();

  
}
window.onload = function()  {
    var canvas = document.getElementById('circle-canvas'),
        context = canvas.getContext('2d'),
        x = 20,
        y = 30,
        radius = 10,
        updateInterval = 10
        update = {
            x: +updateInterval,
            y: +updateInterval
        };

    function animate() {
        context.clearRect(0, 0, canvas.width, canvas.height);
        context.beginPath();       
        context.arc(x, y, radius, 0, 2 * Math.PI);
        context.fillStyle = 'red';
        context.fill();
        context.stroke();
        if (x === canvas.width - radius) {
            update.x = -updateInterval;
        }
        else if (x === 0 + radius) {
            update.x = +updateInterval;
        }
        if (y === canvas.height - radius) {
            update.y = -updateInterval;
        }
        else if (y === 0 + radius) {
            update.y = +updateInterval;
        }
        x += update.x;
        y += update.y;

        window.requestAnimationFrame(animate);
    }

    window.requestAnimationFrame(animate);
}
var canvasDrawer = (function () {
    var DEFAULT_COLOR = 'red';

    function Rect(x,y,width,height,color) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.color = color || DEFAULT_COLOR;
    }

    return {
        Rect : Rect

    }

}());

var rect = new canvasDrawer.Rect(5, 10, 5, 5,'blue');
console.dir(rect)
/// <reference path="_reference.js" />
var snake = (function () {
    var DEFAULT_SNAKE_PART_SIZE = 5;
    function SnakePart(x, y) {
        this.x = x;
        this.y = y;
    }
    function Snake(x, y, piecesCount) {
        var part,
            i;

        this.x = x;
        this.y = y;
        this.piecesCount = piecesCount;
        this.parts = [];
        if (typeof this.x === 'number') {
            console.log(5)
        }
        for (i = 1; i <= this.piecesCount; i++) {
            part = new SnakePart(this.x - i * DEFAULT_SNAKE_PART_SIZE, this.y)
            this.parts.push(part)
        }
    }

    return {
        getSnake: function (x,y,piecesCount) {
            return new Snake(x, y, piecesCount);
        }
    }
}())
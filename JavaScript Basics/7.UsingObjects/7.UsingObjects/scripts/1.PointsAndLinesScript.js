function Point(xCoord, yCoord) {
    'use strict';
    if (typeof xCoord !== 'number' || typeof yCoord !== 'number') {
        throw new TypeError('Invalid input! Required input is two numbers!');
    }

    this.xCoord = xCoord;
    this.yCoord = yCoord;
}

function Line(firstPoint, secondPoint) {
    'use strict';
    if (!firstPoint instanceof Point || !secondPoint instanceof Point) {
        throw new TypeError('Invalid input! Required input is two points!');
    }

    this.startPoint = firstPoint;
    this.endPoint = secondPoint;
}

function calculateDistanceBetweenPoints(firstPoint, secondPoint) {
    'use strict';
    if (!firstPoint instanceof Point || !secondPoint instanceof Point) {
        throw new TypeError('Invalid input!');
    }

    var distance = Math.sqrt((firstPoint.xCoord - secondPoint.xCoord) * (firstPoint.xCoord - secondPoint.xCoord) +
        (firstPoint.yCoord - secondPoint.yCoord) * (firstPoint.yCoord - secondPoint.yCoord));

    return distance;
}

function canTriangleBeFormed(firstLine, secondLine, thirdLine) {
    'use strict';
    if (!firstLine instanceof Line || !secondLine instanceof Line || !thirdLine instanceof Line) {
        throw new TypeError('Invalid input!');
    }

    var firstLineLength = calculateDistanceBetweenPoints(firstLine.firstPoint, firstLine.secondPoint),
        secondLineLength = calculateDistanceBetweenPoints(secondLine.firstPoint, secondLine.secondPoint),
        thirdLineLength = calculateDistanceBetweenPoints(thirdLine.firstPoint, thirdLine.secondPoint);

    if (firstLineLength + secondLineLength > thirdLineLength &&
            firstLineLength + thirdLineLength > secondLineLength &&
            secondLineLength + thirdLineLength > firstLineLength) {
        return true;
    }

    return false;
}
function solve(args) {
    var dimensions = args[0].split(' '),
        rows = parseInt(dimensions[0]),
        cols = parseInt(dimensions[1]),
        currentRow = rows - 1,
        currentCol = cols - 1,
        labyrinth = args.slice(1),
        sum = 0,
        isVisited = new Array(rows),
        i,
        numberOfVisitedCells = 0;

    for (i = 0; i < isVisited.length; i++) {
        isVisited[i] = new Array(cols);
    }

    while (true) {

        isVisited[currentRow][currentCol] = 1;


        sum += Math.pow(2, currentRow) - currentCol;
        numberOfVisitedCells += 1;


        if (labyrinth[currentRow][currentCol] === '1') {

            currentRow += 2;
            currentCol += 1;

        }
        else if (labyrinth[currentRow][currentCol] === '2') {

            currentRow -= 1;
            currentCol += 2;

        }
        else if (labyrinth[currentRow][currentCol] === '3') {

            currentRow += 2;
            currentCol += 2;

        }
        else if (labyrinth[currentRow][currentCol] === '4') {

            currentRow += 1;
            currentCol += 1;

        }
        else if (labyrinth[currentRow][currentCol] === '5') {

            currentRow += 2;
            currentCol -= 1;

        }
        else if (labyrinth[currentRow][currentCol] === '6') {

            currentRow += 1;
            currentCol -= 2;

        }
        else if (labyrinth[currentRow][currentCol] === '7') {

            currentRow -= 1;
            currentCol -= 2;

        }
        else if (labyrinth[currentRow][currentCol] === '8') {

            currentRow -= 2;
            currentCol -= 1;

        }

        if (currentRow === rows || currentCol === cols || currentCol < 0 || currentRow < 0) {
            return 'Go go Horsy! Collected ' + sum +' weeds';
        }
        else if (isVisited[currentRow][currentCol]) {
            return 'Go go Horsy! Collected ' + numberOfVisitedCells + ' weeds';
        }
    }

}

console.log(solve( [
  '3 5',
  '54561',
  '43328',
  '52388']
))
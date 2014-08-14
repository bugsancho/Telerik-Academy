function solve(args) {
    var dimensions = args[0].split(' '),
        rows = parseInt(dimensions[0]),
        cols = parseInt(dimensions[1]),
        startPosition = args[1].split(' '),
        currentRow = parseInt(startPosition[0]),
        currentCol = parseInt(startPosition[1]),
        labyrinth = args.slice(2),
        sum = 0,
        isVisited = new Array(rows),
        i,
        numberOfVisitedCells = 0;

    for (i = 0; i < isVisited.length; i++) {
        isVisited[i] = new Array(cols);
    }
    
    while (true) {

        isVisited[currentRow][currentCol] = 1;
        sum += currentRow * cols + currentCol + 1;
        numberOfVisitedCells += 1;
        if (labyrinth[currentRow][currentCol] === 'd') {
           
                currentRow++;
            
        }
        else if (labyrinth[currentRow][currentCol] === 'l') {
           
                currentCol--;
            
        }
       else if (labyrinth[currentRow][currentCol] === 'u') {
            
                currentRow--;
            
        }
        else if (labyrinth[currentRow][currentCol] === 'r') {
           
                currentCol++;
           
        }

        if (currentRow === rows || currentCol === cols|| currentCol < 0 || currentRow < 0) {
            return 'out ' + sum;
        }
        else if (isVisited[currentRow][currentCol]) {
            return 'lost ' + numberOfVisitedCells;
        }
    }

}

console.log(solve([
 "3 4",
 "1 3",
 "lrrd",
 "dlll",
 "rddd"]));
console.log(solve([
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "durlddud",
 "urrrldud",
 "ulllllll"
]));

console.log(solve([
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "lurlddud",
 "urrrldud",
 "ulllllll"])
);

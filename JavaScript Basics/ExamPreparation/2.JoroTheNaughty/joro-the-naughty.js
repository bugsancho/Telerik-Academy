function solve(input) {
    var dimensions = input[0].split(' '),
        startPositon = input[1].split(' '),
        commands = input.slice(2),
        rows = parseInt(dimensions[0]),
        cols = parseInt(dimensions[1]),
        currentRow = parseInt(startPositon[0]),
        currentCol = parseInt(startPositon[1]),
        sum = 0,
        numberOfJumps = 0,
        i,
        isVisited = {},
        currentCommands,
        currentNumber;

    for (i = 0; i < commands.length; i++) {
        currentCommands = commands[i].split(' ');
        currentNumber = currentRow * cols + currentCol + 1;
        sum += currentNumber;
        numberOfJumps += 1;
        isVisited[currentNumber] = true;

        currentRow += parseInt(currentCommands[0]);
        currentCol += parseInt(currentCommands[1]);
        console.log(' current row + col :  ' + currentRow + " " + currentCol + ' score ' + sum)
        
        if (i === commands.length -1) {
            i = 0;
        }
        currentNumber = currentRow * cols + currentCol + 1;
        if (isVisited[currentNumber]) {
            return 'caught ' + numberOfJumps;
        }

        if (currentRow < 0 || currentCol < 0 || currentRow >= rows || currentCol >= cols) {
            return 'escaped' + sum;
        }

    }

}

console.log(solve(["6 7 3",
"0 0",
"2 2",
"-2 2",
"3 -1"]));
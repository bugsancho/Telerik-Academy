function solve(input) {
    var n = parseInt(input[0]),
        numbers = new Array(n),
        i,
        sequencesCount = 1;

    for (i = 0; i < input.length -1; i++) {
        numbers[i] = parseInt(input[i + 1]);
    }

    for (i = 0; i < numbers.length - 1; i++) {

        if (numbers[i] > numbers[i+1]) {
            sequencesCount += 1;
        }
    }
    return sequencesCount;
        
}
solve([7, 1, 2, -3, 4, 4, 0, 1])
solve([6, 1, 3, -5, 8, 7, -6])
solve([9,1,8,8,7,6,5,7,7,6])
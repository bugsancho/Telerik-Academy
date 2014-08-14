function Solve(params) {
    var n = parseInt(params[0]),
        maxSum,
        currentSum,
        i,
        j;

    maxSum = parseInt(params[1]);

    for (i = 1; i < n; i++) {

        currentSum = 0;

        for (j = i; j < n; j++) {

            currentSum += parseInt(params[j]);
            if (currentSum > maxSum) {
                maxSum = currentSum;
            }

        }
        if (currentSum > maxSum) {
            maxSum = currentSum;
        }
    }
    return maxSum;
}

console.log(Solve([8, 1, 6, -9, 4, 4, -2, 10, -1]));
console.log(Solve([6, 1, 3, -5, 8, 7, -6]));
console.log(Solve([9, -9, -8, -8 - 7, -6, -5, -1, -7, -6]))
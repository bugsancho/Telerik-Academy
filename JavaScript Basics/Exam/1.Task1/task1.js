function solve(input) {
    var sum = parseInt(input[0]),
        firstPrice = parseInt(input[1]),
        secondPrice = parseInt(input[2]),
        thirdPrice = parseInt(input[3]),
        currentMaxSum = 0,
        currentSum = 0;

    for (var i = Math.floor(sum / firstPrice) ; i >= 0; i--) {

        currentSum = i * firstPrice

        for (var j = Math.floor((sum - currentSum) / secondPrice); j >= 0; j-- ) {

            currentSum = i * firstPrice;

            currentSum += j * secondPrice;
            

            if (sum - currentSum - thirdPrice > 0) {
                currentSum += Math.floor((sum - currentSum) / thirdPrice) * thirdPrice;
            }


            if (currentSum > currentMaxSum) {
                currentMaxSum = currentSum;
            }
        }

    }
    return currentMaxSum;
}


console.log(solve(['110', '19', '29', '39']));

//console.log(solve(['20', '11', '200', '300']));
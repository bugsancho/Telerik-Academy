function solve(input) {
    var sum = parseInt(input[0]),
        firstPrice = parseInt(input[1]),
        secondPrice = parseInt(input[2]),
        thirdPrice = parseInt(input[3]),
        currentMaxSum = 0,
        remainingSum = 0;

    for (var i = Math.floor(sum / firstPrice) ; i >= 0; i--) {

        remainingSum = sum - i * firstPrice;
        
        for (var j = Math.floor(remainingSum / secondPrice) ; j >= 0; j--) {


            console.log(' before' + remainingSum);

            remainingSum -= j * secondPrice;


            console.log(remainingSum);
            

        }
    }
}

solve(['110', '13', '15', '17']);


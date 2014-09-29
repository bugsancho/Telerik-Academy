app.filter('passangerNamesFilter', function () {
    return function (input) {
        var output = '';
        if (!input || !input.length) {
            return output;
        }
        console.log(input.length)
        var initialLength = input.length;

        for (var i = 0; i < initialLength; i += 1) {
            output += input[i];
            console.log(input)
            console.log(i);
            console.log(output)
            if (i != input.length - 1) {
                input += ', ';
            }
        }
        return output;

    }
})
;
function reverseString(stringInput) {

    if (typeof stringInput !== 'string') {
        throw new TypeError('Invalid input! Input text should be of type String!');
    }

    var reversedString = "";

    for (var i = stringInput.length - 1; i >= 0; i--) {
        reversedString += stringInput[i];
    }

    return reversedString;
}

function processInput() {
    var inputText = jsConsole.read('#input-text');
    var reversed = reverseString(inputText);
    jsConsole.writeLine(reversed);
}
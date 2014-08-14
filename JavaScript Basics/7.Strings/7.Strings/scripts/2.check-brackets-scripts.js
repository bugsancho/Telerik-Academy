function processInput() {
    var inputExpression = jsConsole.read('#input-text');

    if (isBracketingValid(inputExpression)) {
        jsConsole.writeLine('The bracketing is correct!');
    }
    else {
        jsConsole.writeLine('The bracketing is incorrect!');
    }
}

function isBracketingValid(expression) {

    if (typeof expression !== 'string') {
        throw new TypeError('Invalid input! Input expression should be of type String!');
    }

    var openedBrackets = 0;
    for (var i = 0; i < expression.length; i++) {
        if (expression[i] === '(') {
            openedBrackets++;
        }
        else if (expression[i] === ')') {
            if (openedBrackets > 0) {
                openedBrackets--;
            }
            else {
                return false;
            }
        }
    }

    if (openedBrackets !== 0) {
        return false;
    }

    return true;
}

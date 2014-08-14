function processInput() {
    var inputText = jsConsole.read('#input-text'),
        emails = extractEmails(inputText);
    jsConsole.writeLine(emails);

}

function extractEmails(inputText) {
    var regex = /([a-z0-9._-]+@[a-z0-9._-]+\.[a-z0-9._-]+)/gi;

    return inputText.match(regex);
}

console.log(extractEmails('   emMail@gmail.com f more@g.co'))
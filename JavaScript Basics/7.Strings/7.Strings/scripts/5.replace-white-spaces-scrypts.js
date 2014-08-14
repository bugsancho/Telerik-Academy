function processInput() {
    var inputText = jsConsole.read('#input-text');
    jsConsole.writeLine(replaceWhiteSpaces(inputText));
}
function replaceWhiteSpaces(text) {    
    text = text.replace(/\s/g, '&nbsp');
    return text;
}

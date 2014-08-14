function processInput() {
    var inputText = jsConsole.read('#input-text'),
        extractedText = extractTextFromHtml(inputText);
    jsConsole.writeLine(extractedText);
}

function extractTextFromHtml(htmlCode) {
    var regex = /(<.*?>)/g
    return htmlCode.replace(regex, '');
}

console.log(extractTextFromHtml('<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>'))
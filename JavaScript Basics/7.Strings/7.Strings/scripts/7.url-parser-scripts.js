function processInput() {
    var inputText = jsConsole.read('#input-text'),
        parsedUrl = parseUrl(inputText);
    jsConsole.writeLine(JSON.stringify(parsedUrl));
}
function parseUrl(urlAddress) {
    var regex = /^(.+):\/\/(.+?)(\/.+)/,
        matches = regex.exec(urlAddress),
        urlObject = {
            protocol: matches[1],
            server: matches[2],
            resource: matches[3]
        };
    return urlObject;
}


console.log(parseUrl('http://telerikacademy.com/Couses/Courses/Details/173'));
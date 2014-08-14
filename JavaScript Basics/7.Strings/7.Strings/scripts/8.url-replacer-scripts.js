function processInput() {
    var inputText = jsConsole.read('#input-text');
    replaced = replaceLinks(inputText);
    jsConsole.writeLine(replaced);
}

function replaceLinks(htmlCode) {
    var regex = /<a href="(.+?)">(.+?)<\/a>/g,
        replaced = htmlCode.replace(regex, '[URL=$1]$2[\/URL]');

    return replaced;
}

console.log(replaceLinks('<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>'))
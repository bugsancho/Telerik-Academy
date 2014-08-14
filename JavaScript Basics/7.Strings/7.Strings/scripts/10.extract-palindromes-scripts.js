function processInput() {
    var inputText = jsConsole.read('#input-text'),
        words = extractWordsFromText(inputText),
        palindromes = [],
        i;

    for (i = 0; i < words.length; i += 1) {
        if (isPalindrome(words[i])) {
            palindromes.push(words[i]);
        }
    }

    // print result
    jsConsole.write('Palindromes: ');
    for (i = 0; i < palindromes.length; i += 1) {
        jsConsole.write(palindromes[i] + ' ');
    }
    jsConsole.writeLine();
}

function extractWordsFromText(text) {
    var regex = /[\s,.?!'"()/\\]/g;
    return text.split(regex);
}

function isPalindrome(word) {
    var startIndex = 0,
        endIndex = word.length - 1;

    while (startIndex < endIndex) {

        if (word[startIndex] !== word[endIndex]) {
            return false;
        }
        startIndex += 1;
        endIndex -= 1;
    }
    return true;
}

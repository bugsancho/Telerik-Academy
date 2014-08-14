function processInput() {
    var inputText = jsConsole.read('#input-text'),
        searchedWord = jsConsole.read('#searched-word');

    var numberOfOccurances = findSubstringOccurancesCount(inputText, searchedWord);


    jsConsole.writeLine('Number of occurances: ' + numberOfOccurances);
}

function findSubstringOccurancesCount(inputText, searchedWord) {
    var occurancesCount = 0,
        currentIndex = 0;
    inputText = inputText.toLowerCase();
    searchedWord = searchedWord.toLowerCase();

    while (inputText.indexOf(searchedWord, currentIndex) !== -1) {
        occurancesCount++;
        currentIndex = inputText.indexOf(searchedWord, currentIndex) + searchedWord.length;
    }

    return occurancesCount;
}
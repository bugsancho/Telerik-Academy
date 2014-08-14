function solve(args) {
    var variables = {},
    i,
    initialCommands,
    currentArray,
    firstCommand,
    secondCommand,
    thirdCommand,
    parsedCommands = [];


    for (i = 0; i < args.length; i++) {
        initialCommands = args[i].substring(0, args[i].indexOf('[')).trim();
        currentArray = args[i].substring(args[i].indexOf('[') + 1, args[i].length - 1);
        firstCommand = initialCommands.substr(0, initialCommands.indexOf(' '));
        secondCommand = initialCommands.substr(firstCommand.length).trim();
        thirdCommand = secondCommand.substr(secondCommand.indexOf(' ')).trim();
        secondCommand = secondCommand.substr(0, secondCommand.indexOf(' '));

        parsedCommands[i] = {
            initial: firstCommand,
            name: secondCommand,
            operation : thirdCommand
        }
    }

    return parsedCommands

}

console.log(solve(['   def     func     sum  [1,   2, 3,    -6]',
    'def func [5,3,1]'
]));


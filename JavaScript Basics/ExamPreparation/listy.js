function solve(args) {
    var variables = {},
    i,
    initialCommand,
    currentArray;


    for (i = 0; i < args.length; i++) {
        initialCommands = args[i].substring(0, args[i].indexOf('['));
        currentArray = args[i].substr(args[i].indexOf('[') + 1);
        return currentArray;
    }

}

console.log(solve(['def func sum[1, 2, 3, -6]']));
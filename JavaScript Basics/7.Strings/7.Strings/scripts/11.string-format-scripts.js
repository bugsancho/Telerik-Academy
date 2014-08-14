
function stringFormat() {
    var args = Array.prototype.slice.call(arguments),
        template = args[0];
    for (var i = 1; i < args.length; i++) {
        
        template = template.split('{' + (i - 1) + '}').join(args[i]);
    }
    return template;

}

console.log(stringFormat('Name {0}, Age {1}', 'gosho', 16));

function generateList(people, template) {
    var outputList = '<ul>',
        currentTemplate = '',
        i;
    for (i = 0; i < people.length; i++) {
        currentTemplate = template;
        outputList += '<li>';

        for (var prop in people[i]) {
            currentTemplate = currentTemplate.replace('-{' + prop + '}-', people[i][prop]);
        }
        outputList += currentTemplate;
        outputList += '</li>';
    }
    outputList += '</ul>';
    return outputList;
}

var people = [{ name: 'pepi', age: 20 }, { name: 'gogo', age: 30 }];
var template = '<span>-{name}-</span><span>-{age}-</span>'
console.log(generateList(people, template));
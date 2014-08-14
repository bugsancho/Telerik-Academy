function solve(input) {
    var variables = [],
        numberOfVariables = parseInt(input[0]),
        numberOfLines = parseInt(input[numberOfVariables + 1]),
        viewCode = input.slice(numberOfVariables + 2),
        concatenatedInput = '',
        output = [],
        index = 0;



    for (var i = 1; i <= numberOfVariables; i++) {

        variables.push(parseVariable(input[i]))

    }

    for (var i = 0; i < viewCode.length; i++) {
        concatenatedInput += viewCode[i] + '\n'
    }

    while ((index = concatenatedInput.indexOf('\n')) !== -1) {

        output.push(concatenatedInput.substr(index));
        concatenatedInput = concatenatedInput.substr(index);
        

    }

    
    console.log(output)





    function parseVariable(keyValuePair) {
        var splitted = keyValuePair.trim().split('-');
        var arrayValue = [];
        var variable = {
            key: splitted[0],
            value: splitted[1]
        };

        if (variable.value.indexOf(';') !== -1) {
            variable.value = variable.value.trim().split(';');
        }
        return variable;


    }
}

console.log(solve(
    [
     '6',
     'title-Telerik Academy',
     'showSubtitle-true',
     'subTitle-Free training',
     'showMarks-false',
     'marks-3;4;5;6',
     'students-Ivan;Gosho;Pesho',
'     42',
'<nk-template name="menu">',
'    <ul id="menu">',
'        <li>Home</li>',
'        <li>About us</li>',
'    </ul>',
'</nk-template>',
'<nk-template name="footer">',
'    <footer>',
'        Copyright Telerik Academy 2014',
'    </footer>',
'</nk-template>',
'<!DOCTYPE html>',
'<html>',
'<head>',
'    <title>Telerik Academy</title>',
'</head>',
'<body>',
'    <nk-template render="menu" />',
'',
'    <h1><nk-model>title</nk-model></h1>',
'    <nk-if condition="showSubtitle">',
'        <h2><nk-model>subTitle</nk-model></h2>',
'        <div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
'    </nk-if>',
'',
'    <ul>',
'        <nk-repeat for="student in students">',
'            <li>',
'                <nk-model>student</nk-model>',
'            </li>',
'            <li>Multiline <nk-model>title</nk-model></li>',
'        </nk-repeat>',
'    </ul>',
'    <nk-if condition="showMarks">',
'        <div>',
'            <nk-model>marks</nk-model> ',
'        </div>',
'    </nk-if>',
'',
'    <nk-template render="footer" />',
'</body>',
'</html>',
    ]
    ))
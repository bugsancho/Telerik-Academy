function solve(input) {
    var variables = {},
        numberOfVariables = parseInt(input[0]),
        numberOfLines = parseInt(input[numberOfVariables + 1]),
        viewCode = input.slice(numberOfVariables + 2),
        concatenatedInput = '',
        parsedVarable,
        output = [],
        index = 0,
        emptyLineIndexes = {},
        lineCounter = 0,
        models = {},
        modelIndex = 0,
        modelTitle,
        modelTitleStart,
        templates = {},
        templateInitialIndex;



    for (var i = 1; i <= numberOfVariables; i++) {
        parsedVarable = parseVariable(input[i]);
        variables[parsedVarable.key] = parsedVarable.value;
    }

    //change models
    for (var i = 0; i < viewCode.length; i++) {
        modelIndex = viewCode[i].indexOf('<nk-model>');
        if (modelIndex !== -1 && viewCode[i].indexOf('{{') === -1) {
            modelTitleStart = viewCode[i].substr(modelIndex + 10);
            modelTitle = modelTitleStart.substring(0, modelTitleStart.indexOf('<'));
            viewCode[i] = viewCode[i].replace(('<nk-model>' + modelTitle.toString() + '</nk-model>'), variables[modelTitle]);            
        }

    }

    //extract templates
    for (var i = 0; i < viewCode.length; i++) {
        modelIndex = viewCode[i].indexOf('nk-template name="');

        if (modelIndex !== -1) {
            templateInitialIndex = i;

            modelTitleStart = viewCode[i].substr(modelIndex + 'nk-template name="'.length);
            modelTitle = modelTitleStart.substring(0, modelTitleStart.indexOf('"'));
            templates[modelTitle] = [];

            while (viewCode[i].indexOf('</nk-template>') === -1) {
                templates[modelTitle].push(viewCode[i]);
                i++;
            }
            templates[modelTitle] = templates[modelTitle].splice(1);
            viewCode.splice(templateInitialIndex, i - templateInitialIndex + 1);
            i = templateInitialIndex -1;
        }        
    }
        

    for (var template in templates) {

        for (var j = 0; j < viewCode.length; j++) {
            if (viewCode[j].indexOf('<nk-template render="' + template+'" />') !== -1) {

                viewCode.splice(j, 1);

                for (var k = templates[template].length - 1; k >= 0; k--) {
                    viewCode.splice(j, 0, templates[template][k]);
                }
            }
        }


    }

    //concatenate input
    for (var i = 0; i < viewCode.length; i++) {
        concatenatedInput += viewCode[i] + '\n'
        if (viewCode[i] === '') {
            emptyLineIndexes[i] = true;
        }
    }
   
    //print output
    //while ((index = concatenatedInput.indexOf('\n')) !== -1) {
    //    if (emptyLineIndexes[lineCounter]) {
    //        output.push('');
    //        lineCounter++;
    //        continue;
    //    }
    //    output.push(concatenatedInput.substr(0, index));
    //    concatenatedInput = concatenatedInput.substr(index).trim();
    //    lineCounter++;
    //}
    //output.push(concatenatedInput);


    //parse variables
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

    return concatenatedInput;
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
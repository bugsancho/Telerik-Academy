/// <reference path="G:\Code\JavaScript_UI_And_DOM\9.JQueryOverview\9.JQueryOverview\libs/jquery-2.1.1.min.js" />
window.onload = function () {
    var newEl = $('<li>').text('inserted before element');
    insertElementBefore($('#item3'), newEl);
    insertElementAfter($('#item5'),$('<li>').text('Inserted after element'))
}
function insertElementAfter(element, insertedElement) {
    console.log(element);
    console.log(insertedElement);
    $(element).after($(insertedElement));
}
function insertElementBefore(element, insertedElement) {
    console.log(element);
    console.log(insertedElement);
    $(element).before($(insertedElement));
}
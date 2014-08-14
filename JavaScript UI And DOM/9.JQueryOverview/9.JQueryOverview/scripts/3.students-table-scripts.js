/// <reference path="G:\Code\JavaScript_UI_And_DOM\9.JQueryOverview\9.JQueryOverview\libs/jquery-2.1.1.min.js" />
window.onload = function () {
    var students = [{ firstname: 'Georgi', lastname: 'Ivanov', grade: 5 },
    { firstname: 'Peter', lastname: 'Petrov', grade: 2 },
    { firstname: 'Ivan', lastname: 'Tonkov', grade: 3 },
    { firstname: 'Martin', lastname: 'Todorov', grade: 6 },
    { firstname: 'Penko', lastname: 'Stefanov', grade: 3 }]

    var $table = $('<table>').addClass('students-table').appendTo('#container');
    var $head = $table.append('<thead>');
    $head.append($('<th>').text('First name'));
    $head.append($('<th>').text('Last name'));
    $head.append($('<th>').text('Grade'));

    $.each(students, function () {
        var $row = $('<tr>');
        $row.append($('<td>').text(this.firstname));
        $row.append($('<td>').text(this.lastname));
        $row.append($('<td>').text(this.grade));
        $row.appendTo($table)
    })

    $table.css({
        'border': '1px solid black',
        'border-collapse':'collapse'
    });
    $('td, th').css('border', '1px solid black');
    $('td, th').css('padding', '5px');
}
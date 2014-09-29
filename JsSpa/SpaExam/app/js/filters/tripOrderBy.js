app.filter('tripOrderBy', function () {
    return function (input) {
        var orderBy;

        switch (input) {
            case "None":
                orderBy = 'null';
                break;
            case "To":
                orderBy = 'to';
                break;
            case "From":
                orderBy = 'from';
                break;
            case "Departure time":
                orderBy = 'date';
                break;
        }
        return orderBy;

    }
})
;
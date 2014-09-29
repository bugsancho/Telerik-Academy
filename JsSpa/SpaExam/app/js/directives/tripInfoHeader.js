app.directive('tripInfoHeader', function () {
    return {
        scope: {
            isInDetails: '=inDetails'
        },
        templateUrl: 'views/directives/trip-info-header.html'
    };
});
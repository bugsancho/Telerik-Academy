app.directive('tripInfo', function () {
    return {
        scope: {
            trip: '=trip',
            isInDetails: '=inDetails'
        },
        templateUrl: 'views/directives/trip-info.html'
    };
});
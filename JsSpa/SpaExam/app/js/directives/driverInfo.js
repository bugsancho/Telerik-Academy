app.directive('driverInfo', function () {
    return {
        scope: {
            driver: '=driver'
        },
        templateUrl: 'views/directives/driver-info.html'
    };
});
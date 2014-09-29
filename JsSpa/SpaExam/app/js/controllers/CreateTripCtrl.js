'use strict';

app.controller('CreateTripCtrl', ['$scope', '$location', 'auth', 'notifier', 'cities', 'trips', function ($scope, $location, auth, notifier, cities, trips) {

    $scope.cities = cities.getAll();
    $scope.create = create;
    function create(trip) {
        trips.create(trip).$promise.then(function (data) {
            notifier.success('Trip Succesfully created!');
            $location.path('#/trips');
        }, function (error) {

            notifier.error(error);
        })
    }

}]);
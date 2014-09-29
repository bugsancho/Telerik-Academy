'use strict';

app.controller('DriverDetailsCtrl', ['$scope', 'notifier', 'trips', 'stats', 'drivers', '$cacheFactory', '$routeParams', function ($scope, notifier, trips, stats, drivers, $cacheFactory, $routeParams) {


    getDriverById($routeParams.id);

    $scope.getDriverById = getDriverById;
    $scope.getTripById = getTripById;
    $scope.filterTrips = filterTrips;

    $scope.ascendingFilter = true;

    $scope.toggleAscending = function () {
        $scope.ascendingFilter = !$scope.ascendingFilter;
    };

    function filterTrips() {
        console.log(params);
        trips.getAll(params).$promise.then(function (data) {
            $scope.trips = data;
        }, function (error) {
            notifier.error(error);
        })
    }

    function getDriverById(id) {
        drivers.getById({id: id}).$promise.then(function (data) {
            $scope.driver = data;
            $scope.trips = data.trips;
        }, function (error) {
            notifier.error(error);
        })
    }

    function getTripById(id) {
        trips.getById({id: id}).$promise.then(function (data) {
        }, function (error) {
            notifier.error(error);
        })
    }

}]);
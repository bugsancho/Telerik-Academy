'use strict';

app.controller('TripDetailsCtrl', ['$scope', 'notifier', 'trips', 'stats', 'drivers', '$cacheFactory', '$routeParams', function ($scope, notifier, trips, stats, drivers, $cacheFactory, $routeParams) {


    getTripById($routeParams.id);

    $scope.getDriverById = getDriverById;
    $scope.getTripById = getTripById;
    $scope.filterTrips = filterTrips;
    $scope.join = joinTrip;

    $scope.ascendingFilter = true;

    $scope.toggleAscending = function () {
        $scope.ascendingFilter = !$scope.ascendingFilter;
    };

    function joinTrip(id) {
        trips.join({id: id}).$promise.then(function (data) {
                notifier.success('Trip joined!');
            },
            function (error) {
                notifier.error(error);
            })
    }

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
            $scope.trip = data;
        }, function (error) {
            notifier.error(error);
        })
    }

}]);
'use strict';

app.controller('HomeCtrl', ['$scope', 'notifier', 'trips', 'stats', 'drivers', '$cacheFactory', function ($scope, notifier, trips, stats, drivers, $cacheFactory) {

    $scope.trips = trips.getAll();
    var statistics  = stats.get();
    $scope.drivers = drivers.getAll();

    $scope.stats = statistics;

    $scope.getDriverById = getDriverById;
    $scope.getTripById = getTripById;

    function getDriverById(id) {
        drivers.getById({id: id}).$promise.then(function (data) {
        }, function (error) {
            notifier.error(error);
        })
    }
    function getTripById(id) {
        console.log(5);
        trips.getById({id: id}).$promise.then(function (data) {
        }, function (error) {
            notifier.error(error);
        })
    }

}]);
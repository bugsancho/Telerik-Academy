'use strict';

app.controller('DriversCtrl', ['$scope', 'notifier', 'trips', 'stats', 'drivers', '$cacheFactory', 'identity', function ($scope, notifier, trips, stats, drivers, $cacheFactory, identity) {

    $scope.isAuthenticated = identity.isAuthenticated();
    $scope.drivers = drivers.getAll();
    $scope.page = 1;
    $scope.increasePage = function () {
        $scope.page++;
    };
    $scope.decreasePage = function () {
        $scope.page--;
    };

    $scope.getDriverById = getDriverById;
    $scope.getTripById = getTripById;
    $scope.filterDrivers = filterDrivers;


    function filterDrivers(params) {
        drivers.getAll(params).$promise.then(function (data) {
            $scope.drivers = data;
        }, function (error) {
            notifier.error(error);
        })
    }

    function getDriverById(id) {
        drivers.getById({id: id}).$promise.then(function (data) {
            console.log(data);
        }, function (error) {
            notifier.error(error);
        })
    }

    function getTripById(id) {
        console.log(5);
        trips.getById({id: id}).$promise.then(function (data) {
            console.log(data);
        }, function (error) {
            notifier.error(error);
        })
    }

}]);
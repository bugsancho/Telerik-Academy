'use strict';

app.controller('TripsCtrl', ['$scope', 'notifier', 'trips', 'stats', 'drivers', '$cacheFactory', 'identity', 'cities', 'auth',
    function ($scope, notifier, trips, stats, drivers, $cacheFactory, identity, cities, auth) {
        if (identity.isAuthenticated()) {
            $scope.isAuthenticated = true;

            getUserInfo();
        }
        $scope.trips = trips.getAll();
        $scope.cities = cities.getAll();
        $scope.filters = {};
        $scope.filters.page = 1;
        $scope.getDriverById = getDriverById;
        $scope.getTripById = getTripById;

        $scope.increasePage = function () {
            $scope.filters.page++;
        };
        $scope.decreasePage = function () {
            $scope.filters.page--;
        };

        $scope.getTrips = getTrips;

        function getUserInfo() {
            auth.userInfo().then(function (data) {
                $scope.userInfo = data;
            }, function (error) {
                notifier.error(error);
            })
        }
        function getTrips(filters) {
            trips.getAll(filters).$promise.then(function (data) {
                $scope.trips = data;
            })
        }

        function getDriverById(id) {
            drivers.getById({id: id}).$promise.then(function (data) {
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
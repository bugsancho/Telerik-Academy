'use strict';

var app = angular.module('myApp', ['ngRoute', 'ngResource', 'ngCookies']).
    config(['$routeProvider', function ($routeProvider) {

        function validateAuthentication($location, identity, notifier) {
            if (!identity.isAuthenticated()) {
                $location.path('#/unauthorized');
                notifier.error('You need to be logged in to do that!')
            }
        }

        $routeProvider
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpCtrl'
            })
            .when('/', {
                templateUrl: 'views/partials/home.html',
                controller: 'HomeCtrl'
            })
            .when('/unauthorized', {
                templateUrl: 'views/partials/unauthorized.html'
            })
            .when('/trips/create', {
                templateUrl: 'views/partials/create-trip.html',
                controller: 'CreateTripCtrl',
                resolve: {authentication: validateAuthentication}
            })
            .when('/trips', {
                templateUrl: 'views/partials/trips.html',
                controller: 'TripsCtrl'
            })
            .when('/trips/:id', {
                templateUrl: 'views/partials/trip-details.html',
                controller: 'TripDetailsCtrl',
                resolve: {authentication: validateAuthentication}
            })
            .when('/drivers', {
                templateUrl: 'views/partials/drivers.html',
                controller: 'DriversCtrl'
            })
            .when('/drivers/:id', {
                templateUrl: 'views/partials/driver-details.html',
                controller: 'DriverDetailsCtrl',
                resolve: {authentication: validateAuthentication}
            })
            .otherwise({ redirectTo: '/' });
    }])
    .value('toastr', toastr)
    .constant('baseServiceUrl', 'http://spa2014.bgcoder.com');
//.constant('baseServiceUrl', 'http://localhost:1337');
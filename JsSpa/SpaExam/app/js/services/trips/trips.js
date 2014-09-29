'use strict';

app.factory('trips', ['$http', '$resource', 'baseServiceUrl', 'authorization', 'identity', function ($http, $resource, baseServiceUrl, authorization, identity) {

    var authHeader;
    if (identity.isAuthenticated()) {
        authHeader = authorization.getAuthorizationHeader();
    }
    var tripsUrl = baseServiceUrl + '/api/trips';
    var Trips = $resource(tripsUrl + '/:id', {id: '@id'}, {
        getAll: {method: 'GET', isArray: true, headers: authHeader},
        getById: {method: 'GET', isArray: false, headers: authHeader},
        join: {method: 'PUT', isArray: false, headers: authHeader},
        create: {method: 'POST', isArray: false, headers: authHeader}
    });

    return {
        getAll: Trips.getAll,
        getById: Trips.getById,
        join: Trips.join,
        create: Trips.create
    }
}]);
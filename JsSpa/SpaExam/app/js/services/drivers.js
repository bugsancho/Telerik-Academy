'use strict';

app.factory('drivers', ['$http', '$resource', 'baseServiceUrl','authorization','identity', function ($http, $resource, baseServiceUrl,authorization,identity) {
    var authHeader;
    if (identity.isAuthenticated()) {
        authHeader = authorization.getAuthorizationHeader();
    }


    var driversUrl = baseServiceUrl + '/api/drivers';
    var Drivers = $resource(driversUrl + '/:id', {id: '@id'}, {
        get: {method: 'GET', isArray: true, headers : authHeader},
        getById: {method: 'GET', isArray: false, headers : authHeader}
    });

    return {
        getAll: Drivers.get,
        getById: Drivers.getById
    }
}]);
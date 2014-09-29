'use strict';

app.factory('cities', ['$http', '$resource', 'baseServiceUrl', function ($http, $resource, baseServiceUrl) {
    var cititesUrl = baseServiceUrl + '/api/cities';
    var Cities = $resource(cititesUrl, {},{
        get: {method: 'GET', isArray : true}
    });

    return {
        getAll: Cities.get
    }
}]);
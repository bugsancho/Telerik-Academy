'use strict';

app.factory('stats', ['$http', '$resource', 'baseServiceUrl', function ($http, $resource, baseServiceUrl) {
    var statsUrl = baseServiceUrl + '/api/stats';
    var Stats = $resource(statsUrl, {},{
        get: {method: 'GET', isArray : false}
    });

    return {
        get: Stats.get
    }
}]);
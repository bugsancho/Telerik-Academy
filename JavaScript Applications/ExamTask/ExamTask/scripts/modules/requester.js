/*globals define*/
define(['jquery', 'q'], function ($, Q) {
    'use strict';
    var requester;
    requester = (function () {
        var getJSON,
            postJSON,
            putJSON;

            getJSON = function getJSON(resourceURL) {
            var deferred = Q.defer();

            deferred.resolve(
                $.ajax({
                    url: resourceURL,
                    type: 'GET',
                    contentType: 'application/json',
//                    timeout: 5000,
                    success: function(data) {
                        deferred.resolve(data);
                    },
                    error: function(err) {
                        deferred.reject(err);
                    }
                })
            );

            return deferred.promise;
        };

         postJSON = function postJSON(resourceURL, data,headers) {
            var deferred = Q.defer();

            deferred.resolve(
                $.ajax({
                    url: resourceURL,
                    type: 'POST',
                    data: JSON.stringify(data),
                    contentType: 'application/json',
                    headers: headers,
                    success: function(data) {
                        deferred.resolve(data);
                    },
                    error: function(err) {
                        deferred.reject(err);
                    }
                })
            );

            return deferred.promise;
         };

         putJSON = function putJSON(resourseURL,data,headers) {
             var deferred = Q.defer();
             deferred.resolve(
                 $.ajax({
                     url: resourseURL,
                     type: 'PUT',
                     contentType: 'application/json',
                     headers: headers,
                     success: function (data) {
                         deferred.resolve(data);
                     },
                     error: function (err) {
                         deferred.reject(err);
                     }
                 })
             );

             return deferred.promise;
         }

        return {
            getJSON: getJSON,
            postJSON: postJSON,
            putJSON: putJSON
        };
    }());
    return requester;
});
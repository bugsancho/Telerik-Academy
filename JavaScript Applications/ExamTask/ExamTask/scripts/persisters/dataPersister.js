/*globals define*/
define(['requester'], function (requester) {
    'use strict';
    var DataPersister;
    DataPersister = (function () {
        function DataPersister(resourceURL) {
            this.resourceURL = resourceURL;
        }

        DataPersister.prototype.getAllPosts = function () {
            var postsUrl = this.resourceURL + 'post';
            return requester.getJSON(postsUrl);
        };

        DataPersister.prototype.getPostByUser = function (user) {
            var postsUrl = this.resourceURL + 'post?user=' + user;
            return requester.getJSON(postsUrl);
        };
        DataPersister.prototype.getPostByContent = function (content) {
            var encoded = encodeURI(content);
            console.log(encoded)
            var postsUrl = this.resourceURL + 'post?pattern=' + encoded;
            return requester.getJSON(postsUrl);
        };
        return DataPersister;
    }());
    return DataPersister;
});

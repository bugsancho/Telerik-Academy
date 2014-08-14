/*globals require, alert, console*/
(function () {
    'use strict';
    require.config({
        paths: {
            jquery: 'libs/jquery-2.1.1',
            mustache: 'libs/mustache',
            q: 'libs/q',
            sammy: 'libs/sammy',
            requester: 'modules/requester',
            basePersister: 'persisters/basePersister',
            dataPersister: 'persisters/dataPersister',
            userPersister: 'persisters/userPersister',
            chatController: 'controllers/chatController',
            ui: 'ui/ui',
            'crypto-sha1': 'libs/sha1',
            'crypto-core': 'libs/core',
            'underscore' : 'libs/underscore'
        },
        shim: {
            'crypto-core': {
                exports: "CryptoJS"
            },
            'crypto-sha1': {
                deps: ['crypto-core'],
                exports: "CryptoJS" //You can also use "CryptoJS.MD5"
            },
            "underscore": {
                exports: "_"
            }
        }

    });

    require(['sammy', 'jquery', 'chatController'], function (Sammy, $, ChatController) {
        var resourceURL = 'http://jsapps.bgcoder.com/';
        //var resourceURL = 'http://localhost:3000/';
        var chatApp = new ChatController('#main-content', resourceURL);

        chatApp.addEvents();       

        var app = Sammy('#main-content', function () {
            this.get('#/', function () {
                chatApp.loadHome();
            });
            this.get('#/login', function () {
                chatApp.loadLogin();
            });
            this.get('#/posts', function () {
                chatApp.loadPosts();
            });
            this.get('#/logout', function () {
                chatApp.loadLogout();
            });
            this.get('#/register', function () {
                chatApp.loadRegister();
            });
            this.get('#/create', function () {
                chatApp.createPost();
            });
            this.get('#/search', function () {
                chatApp.searchPosts();
            });
        });

        $(function () {
            app.run('#/');
        });
    });
}());

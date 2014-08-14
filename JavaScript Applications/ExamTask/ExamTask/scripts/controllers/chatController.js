/*globals define, console*/
define(['basePersister', 'ui', 'jquery'], function (basePersister, UI, $) {
    'use strict';
    var ChatController;
    ChatController = (function () {
        function ChatController(selector, resourceURL) {
            this.selector = selector;
            this.resourceURL = resourceURL;
            this.persister = basePersister.get(resourceURL);
            this.ui = new UI(selector);
        }

        ChatController.prototype.loadHome = function () {
            this.ui.renderHome();
        };

        ChatController.prototype.loadRegister = function () {
            var self = this;
            if (this.persister.user.isLoggedIn()) {
                self.ui.renderLoginDone();
            }
            else {
                this.ui.renderRegister();
            }
        };

        ChatController.prototype.loadLogin = function () {
            if (this.persister.user.isLoggedIn()) {
                this.ui.renderLoginDone();
            } else {
                this.ui.renderLogin();
            }
        };

        ChatController.prototype.loadLogout = function () {
            var self = this;
            if (!this.persister.user.isLoggedIn()) {
                self.ui.renderLogoutDone();
            }
            else {
                this.persister.user.logout().then(function (success) {
                    self.ui.renderLogout();
                    self.persister.user.clearSession();
                }, function (error) {
                    var errorMsg = JSON.parse(error.responseText);
                    alert(errorMsg.message);
                })
            }

        };

        ChatController.prototype.loadPosts = function () {
            var self = this;
            this.persister.data.getAllPosts().then(function (messages) {

                self.ui.renderMessages(messages,'#main-content')
                
            }, function (error) {
                var errorMsg = JSON.parse(error.responseText);
                alert(errorMsg.message);
            });
        };
        ChatController.prototype.searchPosts = function () {
            var self = this;
            self.ui.renderPostSearch();
        };



        ChatController.prototype.createPost = function () {
            

            if (this.persister.user.isLoggedIn()) {
                console.log(this.persister.user.isLoggedIn());
                this.ui.renderCreatePost();
            }
            else {
                this.ui.notLogged();
            }
        };

        ChatController.prototype.addEvents = function () {

            
            var self = this;
            $(this.selector).on('click', '#register-btn', function () {
                var username,
                    password;

                username = $('#register-username').val();
                password = $('#register-password').val();
                self.persister.user.register(username, password).then(function (success) {
                    self.ui.renderRegisterSuccess();
                },
                function (error) {
                    var errorMsg = JSON.parse(error.responseText);
                    alert(errorMsg.message);
                })

            });

            $(this.selector).on('click', '#login-btn', function () {
                var username,
                    password;

                username = $('#login-username').val();
                password = $('#login-password').val();
                self.persister.user.login(username, password).then(function (success) {
                    self.ui.renderLoginSuccess();
                },
                function (error) {
                    var errorMsg = JSON.parse(error.responseText);
                    alert(errorMsg.message);
                });

            });

            $(this.selector).on('click', '#post-create-btn', function () {
                var postTitle,
                    postBody,
                    messageObject;

                postTitle = $('#post-title').val();
                postBody = $('#post-content').val();
                messageObject = {
                    title: postTitle,
                    body: postBody
                };
                self.persister.user.postMessage(messageObject).then(function (success) {
                    self.ui.renderPostCreated();
                },
                 function (error) {
                     var errorMsg = JSON.parse(error.responseText);
                     alert(errorMsg.message);
                 });

            });

            $(this.selector).on('click', '#search-btn', function () {
                var searchedContent,
                    searchedUser;

                searchedContent = $('#search-content').val();
                searchedUser = $('#search-user').val();

                if (searchedUser !== '') {
                    self.persister.data.getPostByUser(searchedUser).then(function (messages) {
                        self.ui.renderMessages(messages, '#main-content')
                    },
                    function (error) {
                        var errorMsg = JSON.parse(error.responseText);
                        alert(errorMsg.message);
                    });
                }
                 if (searchedContent !== '') {
                     self.persister.data.getPostByContent(searchedUser).then(function (messages) {
                        self.ui.renderMessages(messages, '#main-content')
                    },
                    function (error) {
                        var errorMsg = JSON.parse(error.responseText);
                        alert(errorMsg.message);
                    });
                }
              
            });



          
        };



        return ChatController;
    }());
    return ChatController;
});
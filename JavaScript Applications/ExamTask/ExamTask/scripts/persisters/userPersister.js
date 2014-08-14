/*globals define*/
define(['requester', 'crypto-sha1','q'], function(requester,crypto, Q){
    var UserPersister;
    UserPersister = (function(){
        var LOCAL_STORAGE_SESSION_KEY = 'sessionKey';
        function UserPersister(resourceURL){
            this.resourceURL = resourceURL;
        }

        function getSessionKey() {
            return localStorage.getItem(LOCAL_STORAGE_SESSION_KEY);
        }
        function getSessionKeyHeader() {
            return { 'X-SessionKey': getSessionKey() };
        }
        function saveSessionKey(key) {
            localStorage.setItem(LOCAL_STORAGE_SESSION_KEY, key);
        }

        UserPersister.prototype.isLoggedIn = function () {
            if (getSessionKey()) {
                return true;
            }
            return false;
        };

        UserPersister.prototype.clearSession = function () {
            localStorage.clear();
        };

        UserPersister.prototype.login = function (username, password) {
            var loginUrl,
          authCode,
          requestBody;
            var deferred = Q.defer();


            loginUrl = this.resourceURL + 'auth';
            authCode = crypto.SHA1(username + password).toString();
            requestBody = {
                username: username,
                authCode: authCode
            }
            console.log(requestBody);
            //handle response
            requester.postJSON(loginUrl, requestBody).then(function (success) {
                saveSessionKey(success.sessionKey);
                deferred.resolve(success);
                //user view
            },
            function (error) {
                deferred.reject(error);
            });
            return deferred.promise;
        };
        UserPersister.prototype.register = function (username, password) {
            var registerUrl,
            authCode,
            requestBody;
            var deferred = Q.defer();

            registerUrl = this.resourceURL + 'user';
            authCode = crypto.SHA1(username + password).toString();
            requestBody = {
                username: username,
                authCode: authCode
            }
            //handle response
            requester.postJSON(registerUrl, requestBody).then(function (success) {
                deferred.resolve(success);
                //user view
            },
            function (error) {
                deferred.reject(error);
            });
            return deferred.promise;
        };

        UserPersister.prototype.logout = function () {
            var logoutURL,
                requestBody,
                headers;

            logoutURL = this.resourceURL + 'user';
            requestBody = true;
            headers = getSessionKeyHeader();

            //handle response
            return requester.putJSON(logoutURL, requestBody, headers);
        };

        UserPersister.prototype.postMessage = function (message) {
            var postMessageUrl,
                headers;

            postMessageUrl = this.resourceURL + 'post';
            headers = getSessionKeyHeader();
            requester.postJSON(postMessageUrl, message, headers);
        };
        return UserPersister;
    }());
    return UserPersister;
});

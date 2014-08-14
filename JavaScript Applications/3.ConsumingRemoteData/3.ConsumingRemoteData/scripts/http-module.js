var module =(function () {
    function getJson(options) {
        
        var xhrFactory,
            request;

        xhrFactory = getHttpRequest = (function () {
            var xmlHttpFactories;
            xmlHttpFactories = [
                function () {
                    return new XMLHttpRequest();
                }, function () {
                    return new ActiveXObject("Msxml3.XMLHTTP");
                }, function () {
                    return new ActiveXObject("Msxml2.XMLHTTP.6.0");
                }, function () {
                    return new ActiveXObject("Msxml2.XMLHTTP.3.0");
                }, function () {
                    return new ActiveXObject("Msxml2.XMLHTTP");
                }, function () {
                    return new ActiveXObject("Microsoft.XMLHTTP");
                }
            ];
            return function () {
                var xmlFactory, i, len;
                for (i = 0, len = xmlHttpFactories.length; i < len; i++) {
                    xmlFactory = xmlHttpFactories[i];
                    try {
                        return xmlFactory();
                    } catch (error) {
                    }
                }
                return null;
            };
        })();

        request = xhrFactory();
        console.log(request)
    }


    return {
        getJson : getJson
    }
})();

module.getJson()

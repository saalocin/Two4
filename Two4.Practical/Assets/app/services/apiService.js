(function () {

    var app = angular.module("home");

    app.service("apiService", [
        "$http",
        apiService]);

    function apiService($http) {
        var service = {};

        service.getTweetsUrl = "/api/SocialMediaApi/GetTweetsForScreenName";

        service.methods = {
            post: "POST",
            get: "GET"
        };

        var post = function(data, url, success, error) {
            $http({
                    method: service.methods.post,
                    url: url,
                    data: data
                })
                .success(function(result) {
                    success(result);
                })
                .error(function(ex) {
                    error(ex);
                });
        };

        service.getTweetsForScreenName = function(request, success, error) {
            var url = service.getTweetsUrl;
            var data = request;

            post(data, url, success, error);
        };

        return service;
    }
})();
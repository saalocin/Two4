(function() {

    var app = angular.module("home");

    app.factory("twitterModel", [twitterModel]);

    function twitterModel() {
        var model = {};

        model.tweets = [];

        model.screenOptions = {
            screenName: "news24"
        };


        return model;
    }
})();
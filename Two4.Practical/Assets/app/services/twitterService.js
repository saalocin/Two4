(function () {

    var app = angular.module("home");

    app.service("twitterService", [
        "twitterModel",
        "apiService",
        twitterService
    ]);

    function twitterService(twitterModel, apiService) {
        var service = {};

        service.model = twitterModel;

        service.getTweetsForScreenName = function (screenName) {
            service.model.tweets.length = 0;

            var request = {
                ScreenName: screenName
            }

            apiService.getTweetsForScreenName(request, getTweetsForScreenNameOnSuccess, getTweetsForScreenNameOnError);
        };

        function getTweetsForScreenNameOnSuccess(result) {
            

            _.each(result.Tweets, function(tweet) {
                service.model.tweets.push(
                {
                    textAsHtml: tweet.TextAsHtml
                });
            });

            console.log(result);
        }

        function getTweetsForScreenNameOnError(ex) {
        }

        return service;
    }
})();
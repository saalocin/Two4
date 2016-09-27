(function () {
    var app = angular.module("home", []);

    app.controller("homeController", [
            "$scope",
            "twitterService",
            homeController
    ]);

    function homeController(
        $scope,
        twitterService) {

        $scope.tweets = twitterService.model.tweets;

        $scope.screenName = twitterService.model.screenOptions.screenName;

        $scope.refresh = function() {
            twitterService.getTweetsForScreenName($scope.screenName);
        };

        function init() {
            twitterService.getTweetsForScreenName($scope.screenName);
        };

        init();
    };
})();





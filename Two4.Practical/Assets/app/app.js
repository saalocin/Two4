(function () {

    angular.module("app", [
            "ngRoute",
            "ngSanitize",
            "home"
    ])

        // Routes
        .config([
            '$routeProvider', function ($routeProvider) {

                $routeProvider.when('/home', {
                    templateUrl: '/Assets/app/templates/home.html',
                    controller: 'homeController'
                });

                $routeProvider.otherwise({
                    redirectTo: '/home'
                });
            }
        ]);
})();
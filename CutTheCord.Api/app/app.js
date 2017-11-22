

var app = angular.module('todo', ['ngRoute']);

app
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
        .when("/",
        {
            templateUrl: "app/partials/Login.html",
            controller: "loginController"
        })
        .when("/home",
        {
            templateUrl: "app/partials/Home.html",
            controller: "homeController"
        })
        .when("/signup",
        {
            templateUrl: "app/partials/SignUp.html",
            controller: "signupController"
        })
        .when("/search",
        {
            templateUrl: "app/partials/Search.html",
            controller: "searchController"
        })
        .when("/calendar",
        {
            templateUrl: "app/partials/Calendar.html",
            controller: "calendarController"
        });

    }]);

app.run(["$http", function ($http) {

    var token = sessionStorage.getItem('token');

    if (token)
        $http.defaults.headers.common['Authorization'] = `bearer ${token}`;

}
]);

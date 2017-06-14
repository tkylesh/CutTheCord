app.controller("signupController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
    $scope.values = [];
    $scope.username = "";
    $scope.password = "";
    $scope.confirmPassword = "";

    $scope.signup = function () {
        $http({
            method: 'POST',
            url: "api/account/register",
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: { Email: $scope.username, Password: $scope.password, ConfirmPassword: $scope.confirmPassword }
        })
            .then(function (result) {
                console.log("result=", result);
                $location.path("/home");
            });
    }
}]);
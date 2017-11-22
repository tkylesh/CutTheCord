app.controller("loginController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
    $scope.login = function () {
        // show something to the user to remind them that patience is a virtue
        swal({
            title: "Logging in...",
            type: "info",
            showConfirmButton: false,
            text: "One moment please",
            timer: 3000,
            allowOutsideClick: false,
            allowEscapeKey: false 
        });

        $http({
            method: 'POST',
            url: "/Token",
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: { grant_type: "password", username: $scope.username, password: $scope.password }
        })
            .then(function (result) {
                console.log("result=", result);
                swal.close(); //closes the patience modal
                sessionStorage.setItem('user', result.data.userName);
                sessionStorage.setItem('token', result.data.access_token);
                $http.defaults.headers.common['Authorization'] = `bearer ${result.data.access_token}`;

                $location.path("/home");
            }, function (error) {
                swal("Login failed", error.statusText, "error");
            });
    };
}]);
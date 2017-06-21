app.controller("calendarController",["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.welcome = "calendar controller";
    $scope.schedules = [];

    

    var loadSchedule = () => {
        var memberEmail = sessionStorage.getItem("user");
        console.log("user: ", memberEmail);

        var config = {
            params: {
                "email": memberEmail
            }
        };

        $http.get('http://localhost:49348/api/member', config).then(
            (result) => {
                console.log("get member: ", result);
                var memberId = result.data.Id;
                $http.get(`http://localhost:49348/api/schedule/${memberId}`).then((result) => {
                    console.log("get schedules for member: ", result);
                    $scope.schedules = result.data;
                });
            });
    };
    loadSchedule();

}]);
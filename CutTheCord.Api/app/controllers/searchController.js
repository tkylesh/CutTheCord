app.controller("searchController",["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.welcome = "search controller";
    
    $scope.showList;
    $scope.searchText = "";

    $scope.search = () =>
    {
        $http.get(`api/search/${$scope.searchText}`)
        .then(function (result) {
            console.log(result.data);
            $scope.showList = result.data;
        });
    };


    $scope.AddShow = (show) =>
    {
        var config = {
            params: {
                "email": "taylor@gmail.com"
            }
        };

        $http.get('http://localhost:49348/api/member',config).then(
            (result) => {
                console.log("retrieve member: ", result);
                var days = angular.toJson(show.schedule.days);
                var time = show.schedule.time;
                //var scheduleString = `${days}, ${time}`;

                $http.post('api/show',
                    {
                        "show": show,
                        "member": "test",
                        "schedule":
                            {
                                "time": time,
                                "days": days
                            }
                    }).then((result) => {
                        console.log(result);
                    });
            },
            (error) => { console.log("error retrieving member: ", error) }
            );
    };
    


}]);
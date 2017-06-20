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
    


}]);
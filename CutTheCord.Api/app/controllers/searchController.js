app.controller("searchController",["$scope", "$http", "$location", "ShowFactory", function ($scope, $http, $location, ShowFactory) {

    $scope.welcome = "search controller";
    ShowFactory.searchShows().then((shows) => {
        $scope.shows = shows;
        console.log("shows: ", shows);
    });

}]);
app.factory("ShowFactory", ["$http", "$q", function ($http, $q) {

    var searchShows = () => {
        return $q((resolve, reject) => {
            $http.get("http://api.tvmaze.com/search/shows?q=girls", { headers: { Allow: 'GET' } })
            .then((response) => {
                console.log(response);
                let shows = [];
                Object.Keys(response).forEach((key) => {
                    response[key].id = key;
                    shows.push(response[key]);
                });
                resolve(foods);
            },
            (errorResponse) => {
                reject(errorResponse);
            });
        });

    };

    return { searchShows: searchShows };
}]);
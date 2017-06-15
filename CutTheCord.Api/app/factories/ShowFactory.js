app.factory("ShowFactory", function ($q, $http) {

    var searchShows = (query) => {
        return $q((resolve, reject) => {
            $http.get(`http://api.tvmaze.com/search/shows?q=${query}`)
            .success((response) => {
                let shows = [];
                Object.Keys(response).forEach((key) => {
                    response[key].id = key;
                    shows.push(response[key]);
                });
                resolve(foods);
            })
            .error((errorResponse) => {
                reject(errorResponse);
            });
        });

    };

    return { searchShows: searchShows };
});
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

        $http.get('http://localhost:49348/api/member', config).then(
            (result) => {
                console.log("retrieve member: ", result);
                var days = angular.toJson(show.schedule.days);
                var time = show.schedule.time;
                var member = result.data;
                var member2 = angular.toJson(result.data);
                console.log(member2);
                //var scheduleString = `${days}, ${time}`;

                $http.post('api/show',
                    {
                        "show": show,
                        "member":
                            {
                                "ApplicationUser": {
                                    "Claims": [],
                                    "Logins": [],
                                    "Roles": [],
                                    "Email": member.ApplicationUser.Email,
                                    "EmailConfirmed": member.ApplicationUser.EmailConfirmed,
                                    "PasswordHash": member.ApplicationUser.PasswordHash,
                                    "SecurityStamp": member.ApplicationUser.SecurityStamp,
                                    "PhoneNumber": null,
                                    "PhoneNumberConfirmed": false,
                                    "TwoFactorEnabled": false,
                                    "LockoutEndDateUtc": null,
                                    "LockoutEnabled": false,
                                    "AccessFailedCount": 0,
                                    "Id": member.ApplicationUser.Id,
                                    "UserName": "taylor@gmail.com"
                                },
                                "Shows": [],
                                "Id": member.Id,
                                "Email": member.Email,
                                "FirstName": member.FirstName,
                                "LastName": member.LastName
                            },
                        "schedule":
                            {
                                "time": time,
                                "days": days
                            }
                    }).then((result) => {
                        console.log("post show: ", result);
                        $http.post('api/schedule',
                        {
                            "show": show,
                            "member":
                            {
                                "ApplicationUser": {
                                    "Claims": [],
                                    "Logins": [],
                                    "Roles": [],
                                    "Email": member.ApplicationUser.Email,
                                    "EmailConfirmed": member.ApplicationUser.EmailConfirmed,
                                    "PasswordHash": member.ApplicationUser.PasswordHash,
                                    "SecurityStamp": member.ApplicationUser.SecurityStamp,
                                    "PhoneNumber": null,
                                    "PhoneNumberConfirmed": false,
                                    "TwoFactorEnabled": false,
                                    "LockoutEndDateUtc": null,
                                    "LockoutEnabled": false,
                                    "AccessFailedCount": 0,
                                    "Id": member.ApplicationUser.Id,
                                    "UserName": member.ApplicationUser.UserName
                                },
                                "Shows": [],
                                "Id": member.Id,
                                "Email": member.Email,
                                "FirstName": member.FirstName,
                                "LastName": member.LastName
                            },
                            "schedule":
                                {
                                    "time": time,
                                    "days": days
                                }
                        }).then((result) => { console.log("post schedule: ", result); });
                    });
            });
    };
    


    }]);
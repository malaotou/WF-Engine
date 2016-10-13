var app = angular.module("app", []);
app.controller("worklist", function ($scope, $http) {
    $scope.getWorkList = function () {
        $http.get('../api/WorkList/WorkList')
            .then(function (data) {
                console.log(data.data[0]);
                $scope.data = data;
            }, function (error) { });

    }
});
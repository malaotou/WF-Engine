var app = angular.module("app", []);
app.controller("worklist", function ($scope, $http) {
    $scope.getWorkList = function () {
        $http.get('../api/WorkList/WorkList')
            .then(function (data) {
                console.log(data.data[0]);
                $scope.data = data;
            }, function (error) { });

    }
    $scope.approve = function (data) {
        $scope.Action = 1;
        //alert($scope.Remark);
        console.log(data);

        var para = new continueData(data.RuntimeInstanceID, data.ID, $scope.Action, data.UserID, $scope.Remark);
        console.log(para);

        $http.post('../api/WorkList/process', para).then(function (data) {
            console.log(para);
            console.log(data);
            if (data.status == 200) {
                alert("审批成功");
            }
        }, function (error) { console.log(err);alert("审批时发生错误") });
    }
    $scope.deny = function (data) {
        $scope.Action = 1;
        alert(data.ID);
    }
    function continueData(InstanceId, WorkListid, Action, UserId, Remark) {
        this.InstanceId = InstanceId;
        this.WorkListId = WorkListid;
        this.Action = Action;
        this.UserId = UserId;
        this.Remark = Remark;
    }
});
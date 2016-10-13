var app = angular.module("app", []);
app.controller("process", function ($scope, $http) {
    $scope.getProcess = function () {

        $http.get('../Api/wf/ListProcessDefine')
            .then(function (data) {
                console.log(data.data[0]);
                $scope.data = data;
            }, function (error) { });

    }
    $scope.title="请审批此流程";
    $scope.id;
    $scope.user = "demouser";
    $scope.orgCode;
    $scope.orgName;
    $scope.startProcess = function (id) {

        var para = new parameter(id, 'Starter', 'start', $scope.title);
        $http.post('../api/wf/process', para).then(function (data) { console.log(data); }, function (error) { console.log(err);});;

    }
    $scope.submitForm = function () {
        //alert($scope.title);
        //alert($scope.id);
        var body = new demoData($scope.orgCode, $scope.orgName);
        console.log(body);
        var para = new parameter($scope.id, $scope.user, 'start',$scope.title, body);
        $http.post('../api/wf/process', para).then(function (data) {
            console.log(para);
            console.log(data);
            if (data.status == 200) {
                alert("流程发起成功");
            }
        }, function (error) { console.log(err); });
    }
    $scope.checked = function () {
       // alert('');
    }
    function parameter(id, userid, command, title,body) {
        this.ProcessId = id;
        this.UserId = userid;
        this.Command = command;
        this.Remark = title;
        this.Body = body;
    }

    function demoData(orgCode, orgName) {
        this.orgCode = orgCode;
        this.orgName = orgName;
    }
});
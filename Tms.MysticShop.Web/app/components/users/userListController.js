(function (app) {
    //khai báo controller
    app.controller("userListController", userListController);

    //injection những thứ cần dùng
    userListController.$inject = ['$scope', 'apiService'];

    //khai báo contructor
    function userListController($scope, apiService) {
        $scope.userList = [];
        $scope.page = 0;
        $scope.pageCount = 0;
        $scope.getUsers = getUsers;

        function getUsers(page) {
            page = page || 0;
            var config = {
                params: {
                    page: page,
                    pageSize: 20
                }
            }
            apiService.get("/api/User/GetAll", config, function (result) {
                $scope.userList = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pageCount = result.data.TotalPages;
                $scope.TotalCount = result.data.TotalCount;
            }, function () {
                console.log("Error get users");
            });
        }

        $scope.getUsers();
    }

})(angular.module("tmsmystic.users"))
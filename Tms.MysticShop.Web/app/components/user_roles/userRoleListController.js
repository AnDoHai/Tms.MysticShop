(function (app) {
    app.controller('userRoleListController', userRoleListController);

    userRoleListController.$inject = ['$scope', 'apiService'];
    
    function userRoleListController($scope, apiService) {
        $scope.userRoles = [];

        $scope.getUserRoles = getUserRoles;

        function getUserRoles() {
            apiService.get("/api/UserRole/GetAll", null, function (result) {
                $scope.userRoles = result.data;
            }, function () {
                console.log("Load UserRole Fail");
            });
        }

        $scope.getUserRoles();
    }
})(angular.module('tmsmystic.user_roles'))
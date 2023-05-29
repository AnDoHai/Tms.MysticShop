(function () {
    angular.module('tmsmystic.user_roles', ['tmsmysticshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('user_roles', {
            url: "/user_roles",
            templateUrl: "/app/components/user_roles/userRoleListView.html",
            controller: "userRoleListController"
        });
    }
})();
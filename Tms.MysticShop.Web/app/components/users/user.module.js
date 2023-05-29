(function () {
    angular.module('tmsmystic.users', ['tmsmysticshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('users', {
            url: "/users",
            templateUrl: "/app/components/users/userListView.html",
            controller: "userListController"
        });
    }
})();
﻿/// <reference path="https://cdnjs.cloudflare.com/ajax/libs/angular.js/1.8.3/angular.min.js" />

(function () {
    angular.module('tmsmystic', ['tmsmysticshop.common',
        'tmsmystic.user_roles',
        'tmsmystic.users']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise("/admin");
    }
})();


var myApp = angular.module('myModule', []);

myApp.controller("MyController", MyController);
myApp.service("Validator", Validator);

MyController.$inject = ['$scope','Validator'];

function MyController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber(2);
    }
}

//service
function Validator($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            $window.alert('this is event');
        } else {
            $window.alert('this is odđ');
        } 
    }
}
(function (angular) {
    'use strict';

    angular.module('app')
        .config(config);

    config.$inject = ['$locationProvider', '$stateProvider'];

    function config($locationProvider, $stateProvider) {
        $locationProvider.hashPrefix('!').html5Mode(true);

        var home = {
            name: 'home',
            url: '/',
            templateUrl: '/app/home/view.html',
            controller: 'homeController as homeCtrl'
        }

        $stateProvider.state(home);
    }
    
})(window.angular);
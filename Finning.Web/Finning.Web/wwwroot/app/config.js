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

        var customers = {
            name: 'customers',
            url: '/customers',
            templateUrl: '/app/customers/view.html',
            controller: 'customersController as customerCtrl',
            resolve: {
                'customers': [
                    'customersService', function (customersService) {
                        return customersService.query().$promise;
                    }
                ]
            
            }
        }

        $stateProvider.state(home);
        $stateProvider.state(customers);
    }
    
})(window.angular);
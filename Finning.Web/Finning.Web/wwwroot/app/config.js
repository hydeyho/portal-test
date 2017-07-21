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
            controller: 'homeController as $ctrl'
        };

        var customers = {
            name: 'customers',
            url: '/customers',
            templateUrl: '/app/customers/view.html',
            controller: 'customersController as $ctrl',
            resolve: {
                'customers': [
                    'customersService', function(customersService) {
                        return customersService.query().$promise;
                    }
                ]

            }
        };

        var customerDetails = {
            name: 'customers.details',
            url: '/{accountNumber}',
            templateUrl: '/app/customers/details/view.html',
            controller: 'customerDetailsController as $ctrl'
        };

        var machines = {
            name: 'machines',
            url: '/machines',
            templateUrl: '/app/machines/view.html',
            controller: 'machinesController as $ctrl',
            resolve: {
                'machines': [
                    'machinesService', function (machinesService) {
                        return machinesService.query().$promise;
                    }
                ]

            }
        };

        var machineDetails = {
            name: 'machines.details',
            url: '/{serialNumber}',
            templateUrl: '/app/machines/details/view.html',
            controller: 'machineDetailsController as $ctrl'
        };

        $stateProvider.state(home);
        $stateProvider.state(customers);
        $stateProvider.state(customerDetails);
        $stateProvider.state(machines);
        $stateProvider.state(machineDetails);
    }
    
})(window.angular);
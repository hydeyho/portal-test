(function (angular) {
    'use strict';

    angular
        .module('app')
        .factory('customersService', service);

    service.$inject = ['$resource'];

    function service($resource) {

        var resource = $resource('api/customers/:accountNumber');
        return resource;

    }
})(window.angular);
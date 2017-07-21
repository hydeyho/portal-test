(function (angular) {
    'use strict';

    angular
        .module('app')
        .factory('machinesService', service);

    service.$inject = ['$resource'];

    function service($resource) {

        var resource = $resource('api/machines/:serialNumber');
        return resource;

    }
})(window.angular);
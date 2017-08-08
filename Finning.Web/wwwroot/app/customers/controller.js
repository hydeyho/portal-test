(function (angular) {
    'use strict';

    angular
        .module('app')
        .controller('customersController', controller);

    controller.$inject = ['customers'];

    function controller(customers) {
        /* jshint validthis:true */
        var vm = this;
        vm.customers = customers;

        activate();

        function activate() { }
    }
})(window.angular);

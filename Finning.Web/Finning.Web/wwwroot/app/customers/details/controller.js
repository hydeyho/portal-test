(function (angular) {
    'use strict';

    angular
        .module('app')
        .controller('customerDetailsController', controller);

    controller.$inject = ['$stateParams', 'customersService'];

    function controller($stateParams, customersService) {
        /* jshint validthis:true */
        var vm = this;

        activate($stateParams.accountNumber);

        function activate(accountNumber) {
            vm.customerDetails = customersService.get({ accountNumber: accountNumber });
        }
    }
})(window.angular);

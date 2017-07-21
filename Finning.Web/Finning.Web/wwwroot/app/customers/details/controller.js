(function (angular) {
    'use strict';

    angular
        .module('app')
        .controller('customerDetailsController', controller);

    controller.$inject = ['customerDetails'];

    function controller(customerDetails) {
        /* jshint validthis:true */
        var vm = this;
        vm.customerDetails = customerDetails;

        activate();

        function activate() { }
    }
})(window.angular);

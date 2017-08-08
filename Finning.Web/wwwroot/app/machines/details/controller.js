(function (angular) {
    'use strict';

    angular
        .module('app')
        .controller('machineDetailsController', controller);

    controller.$inject = ['$stateParams', 'machinesService'];

    function controller($stateParams, machinesService) {
        /* jshint validthis:true */
        var vm = this;

        activate($stateParams.serialNumber);

        function activate(serialNumber) {
            vm.machineDetails = machinesService.get({ serialNumber: serialNumber });
        }
    }
})(window.angular);

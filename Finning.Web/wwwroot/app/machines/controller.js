(function (angular) {
    'use strict';

    angular
        .module('app')
        .controller('machinesController', controller);

    controller.$inject = ['machines'];

    function controller(machines) {
        /* jshint validthis:true */
        var vm = this;
        vm.machines = machines;

        activate();

        function activate() { }
    }
})(window.angular);

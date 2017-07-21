(function (angular) {
    'use strict';

    angular
        .module('app')
        .controller('customersController', controller);

    controller.$inject = [];

    function controller() {
        /* jshint validthis:true */
        var vm = this;

        activate();

        function activate() { }
    }
})(window.angular);

(function () {
    'use strict';

    angular
        .module('app')
        .factory('medicinefactory', medicinefactory);

    medicinefactory.$inject = ['$http'];

    function medicinefactory($http) {
        var service = {
            getData: function () {
                return $http.get("/agent/getData")
            }
        };

        return service;

    }
})();
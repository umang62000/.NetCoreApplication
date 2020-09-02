(function () {
    'use strict';

    angular
        .module('app')
        .controller('medicinecontroller', ['$scope', '$location', 'medicinefactory', medicinecontroller]);

    //studentcontroller.$inject = ['$location'];

    function medicinecontroller($scope, $location, medicinefactory) {
            var vm = this;
        vm.title = 'medicinecontroller';
        loadAllStudentsRecords();

        function loadAllStudentsRecords() {
            var promiseGetMedicines = medicinefactory.getDatas();

            promiseGetStudent.then(function (pl) { $scope.Medicines = pl.data },
                function (errorPl) {
                    $scope.error = errorPl;
                });
        }  

            /* jshint validthis:true */
            //var vm = this;
            //vm.title = 'studentcontroller';

            //activate();

            //function activate() { }
        };
})();

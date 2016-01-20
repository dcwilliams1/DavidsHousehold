(function () {


    function appHeaderControllerFunction($scope){
        var self = this;
        self.currentUser = '';
        self.getUser = function () {
            self.currentUser = 'David';
        };
    }

    AppHeaderController.$inject = [$scope];
     angular.module('DavidsHousehold').controller('AppHeaderController', appHeaderControllerFunction);
})();
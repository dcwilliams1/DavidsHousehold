(function () {

    householdApp = angular.module('DavidsHousehold');
    householdApp.controller('HeaderController', ['$scope', function($scope){
        var self = this;
        self.currentUser = '';
        self.getUser = function () {
            self.currentUser = 'David';
        };
    }]);
})();
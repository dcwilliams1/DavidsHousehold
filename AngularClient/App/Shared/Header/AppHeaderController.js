(function () {

    householdApp = angular.module('DavidsHousehold');
    householdApp.controller('AppHeaderController', function(){
        var self = this;
        self.currentUser = '';
        self.getUser = function () {
            self.currentUser = 'David';
        };
    });
})();
(function () {

    householdApp = angular.module('DavidsHousehold');
    householdApp.controller('HeaderController', function(){
        var self = this;
        self.currentUser = '';
        self.getUser = function () {
            self.currentUser = 'David';
        };
    });
})();
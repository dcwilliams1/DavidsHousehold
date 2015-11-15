(function () {

    householdApp = angular.module('DavidsHousehold');
    householdApp.controller('HeaderController', [function(){
        var self = this;
        self.user = '';
        self.getUser = function () {
            self.user = 'David';
        };
    }]);
})();
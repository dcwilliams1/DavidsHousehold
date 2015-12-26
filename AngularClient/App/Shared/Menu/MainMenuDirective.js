(function(){
    var householdMenuDirective = function () {
        return {
            templateUrl: "shared/Menu/MainMenu.html",
            restrict: "E",
            scope: {},
            link: linkFunction
        };

        function linkFunction(scope, element, attrs, controller) {
        }
    };
    angular.module("DavidsHousehold").directive("householdMenu", householdMenuDirective);
})();

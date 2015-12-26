(function () {
    angular.module("DavidsHousehold").directive("householdHeader", function () {
        return {
            templateUrl: "Shared/Header/AppHeader.html",
            restrict: "E",
            scope: {},
            controller: "AppHeaderController",
            controllerAs: "ctrl",
            link: linkFunction
        };

        function linkFunction(scope, element, attrs, ctrl){
            ctrl.getUser();

        }
    });
})();

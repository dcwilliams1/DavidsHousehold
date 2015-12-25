(function () {
    angular.module("DavidsHousehold").directive("householdHeader", function () {
        return {
            templateUrl: "shared/Header/Header.html",
            restrict: "E",
            scope: {},
            controller: "HeaderController",
            controllerAs: "ctrl",
            link: link
        };

        function link(scope, element, attrs, ctrl){
            ctrl.getUser();

        }
    });
})();

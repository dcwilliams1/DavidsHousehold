(function () {
    angular.module("DavidsHousehould", []).directive("householdHeader", function () {
        return {
            templateUrl: "Header.html",
            restrict: "E",
            scope: {},
            controller: "HeaderController"
        };

    });
})();

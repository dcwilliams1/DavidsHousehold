/**
 * Created by David on 12/26/2015.
 */
(function(){
    function categoryControllerFunction($scope, BudgetDataService){
        var self = this;
        var dataService = BudgetDataService;
        self.categories = dataService.categories();
    }

    //CategoriesController.$inject = [$scope, BudgetDataService];
    angular.module('Budget').controller("CategoriesController", categoryControllerFunction);
})();




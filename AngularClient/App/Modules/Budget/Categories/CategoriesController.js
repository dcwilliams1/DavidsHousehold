/**
 * Created by David on 12/26/2015.
 */
(function(){
    var categoryControllerFunction = function(BudgetDataService){
        var self = this;
        var dataService = BudgetDataService;
        self.categories = dataService.categories();
    };
    angular.module('Budget').controller("CategoriesController", categoryControllerFunction);
})();




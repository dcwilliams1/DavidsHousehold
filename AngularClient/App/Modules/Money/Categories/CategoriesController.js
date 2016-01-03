/**
 * Created by David on 12/26/2015.
 */
(function(){
    var categoryControllerFunction = function(MoneyDataService){
        var self = this;
        var dataService = MoneyDataService;
        self.categories = dataService.categories();
    };
    angular.module('Money').controller("CategoriesController", categoryControllerFunction);
})();




(function(){
    var dataService, transaction;
    function investmentDataControllerFunction($scope, InvestmentsDataService){
        var self = this;
        dataService = InvestmentsDataService;
        self.submitTransaction = submitTransaction;

    }

    function submitTransaction(){
        transaction = dataService.postTransaction();
    }
    investmentDataControllerFunction.$inject = ['$scope', 'InvestmentsDataService'];
    angular.module('Investments').controller('InvestmentDataController', investmentDataControllerFunction);

})();

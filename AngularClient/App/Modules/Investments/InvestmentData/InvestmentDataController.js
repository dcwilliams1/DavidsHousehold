(function(){
    var dataService, transaction;
    function investmentDataControllerFunction($scope, InvestmentsDataService){
        var investmentDataCtrl = this;
        dataService = InvestmentsDataService;
        investmentDataCtrl.submitTransaction = function(){
            investmentDataCtrl.transaction = dataService.postTransaction();
        }
    }


    investmentDataControllerFunction.$inject = ['$scope', 'InvestmentsDataService'];
    angular.module('Investments').controller('InvestmentDataController', investmentDataControllerFunction);

})();

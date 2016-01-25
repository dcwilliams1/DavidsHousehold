(function(){
    function investmentDataControllerFunction($scope, InvestmentDataService){
        var self = this;


    }

    InvestmentDataController.$inject = [$scope, InvestmentDataService];
    angular.module('Investments').controller('InvestmentDataController', investmentDataControllerFunction);
})();

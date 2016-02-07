/**
 * Created by David on 1/18/2016.
 */

(function(){
    function investmentDataServiceFunction ($http, $q){
        var apiUrl = 'http://localhost:8081';
        var http = $http;
        //var q = $q;

        function postTransaction(newTransaction){
            http.post(apiUrl + '/transactiontest', newTransaction)
                .then(function(response){
                    return response.data;
                }, function(error){
                });
        }

        return {
            postTransaction: postTransaction
        };

    }



  angular.module('Investments').factory('InvestmentsDataService', investmentDataServiceFunction)
})();

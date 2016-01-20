(function () {

    function budgetDataServiceFunction($http, $q) {
        var apiUrl = 'http://localhost:8081';
        var http = $http;
        //var q = $q;

        function getCategories(){
            http.get(apiUrl + '/categories')
                .then(function(response){
                    return response.data;
            }, function(error){
                });
        }

        return {
            categories: getCategories
        };
    }

    angular.module('Budget').factory('BudgetDataService', budgetDataServiceFunction);
})();

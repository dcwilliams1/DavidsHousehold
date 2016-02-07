describe('CategoriesController', function() {
    var ctrl, dataService, httpBackend;
    beforeEach(module('Budget'));

    beforeEach(inject(function ($rootScope, $controller, $httpBackend, BudgetDataService) {
        scope = $rootScope.$new();
        httpBackend = $httpBackend;
        dataService = BudgetDataService;
        ctrl = $controller('CategoriesController', {$scope: scope});
        httpBackend.when('GET', 'http://localhost:8081/categories')
            .respond({categories: [{id: 1, name: 'TestCategory'}]});
    }));

    it('calls the Budget Data Service to get categories', function () {
        dataService.categories(function (data) {
            httpBackend.flush();
            expect(ctrl.categories).toEqual([{id: 1, name: 'TestCategory'}]);
        });
    });

});



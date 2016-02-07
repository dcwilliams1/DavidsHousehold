describe('Budget Data Service', function(){
    var httpBackend, ctrl, dataService;
    beforeEach(module('Budget'));

    beforeEach(inject(function($rootScope, $httpBackend, $controller, $injector){
        dataService = $injector.get('BudgetDataService');
        httpBackend = $httpBackend;
    }));

    beforeEach(function(){
        httpBackend.expectGET('http://localhost:8081/categories')
            .respond(200, {categories: 'GET successful'});
    });

    it('calls the backend api', function(){
        var testCategories = dataService.categories();
        httpBackend.flush();
    });

    it('returns test data', function(){
        dataService.categories(function(data){
           expect(data.categories).toEqual('GET successful');
        });
    });

    afterEach(function(){
        httpBackend.verifyNoOutstandingRequest();
        httpBackend.verifyNoOutstandingExpectation();
    })

});

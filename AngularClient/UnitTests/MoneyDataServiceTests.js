describe('Money Data Service', function(){
    var httpBackend, ctrl, dataService;
    beforeEach(module('Money'));

    beforeEach(inject(function($rootScope, $httpBackend, $controller, $injector){
        dataService = $injector.get('MoneyDataService');
        httpBackend = $httpBackend;
    }));

    it('should call the backend api', function(){
        httpBackend.expectGET('http://localhost:8081/categories')
            .respond(200, {categories: 'GET successful'});

        var testCategories = dataService.categories();
        httpBackend.flush();
    });

    afterEach(function(){
        httpBackend.verifyNoOutstandingRequest();
        httpBackend.verifyNoOutstandingExpectation();
    })

});

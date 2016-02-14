describe('InvestmentsController', function() {
    var ctrl, dataService, httpBackend;
    beforeEach(module('Investments'));

    beforeEach(inject(function ($rootScope, $controller, $httpBackend, $injector ) {
        scope = $rootScope.$new();
        httpBackend = $httpBackend;
        dataService = $injector.get('InvestmentsDataService');
        ctrl = $controller('InvestmentDataController', {$scope: scope});
        httpBackend.when('POST', 'http://localhost:8081/transaction')
            .respond({id: 2, name: 'TestInvestment'});
    }));

   it('calls the Investment Data Service to post a transaction', function () {
        var serviceMethod = spyOn(dataService, 'postTransaction').and.callFake(function(){
            return  {id: 1, name: 'TestInvestment'};
        });
        ctrl.submitTransaction(function (data) {
        });
        expect(serviceMethod).toHaveBeenCalled();
        expect(ctrl.transaction.id).toBe(1);
    });

    afterEach(function() {
        httpBackend.verifyNoOutstandingExpectation();
        httpBackend.verifyNoOutstandingRequest();
    });

});
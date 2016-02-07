describe('InvestmentsController', function() {
    var ctrl, dataService, httpBackend;
    beforeEach(module('Investments'));

    beforeEach(inject(function ($rootScope, $controller, $httpBackend, $injector ) {
        scope = $rootScope.$new();
        httpBackend = $httpBackend;
        dataService = $injector.get('InvestmentsDataService');
        ctrl = $controller('InvestmentDataController', {$scope: scope});
        httpBackend.when('POST', 'http://localhost:8081/Transaction')
            .respond({transaction: [{id: 1, name: 'TestInvestment'}]});
    }));

    it('calls the Investment Data Service to post a transaction', function () {
        ctrl.submitTransaction(function (data) {
            httpBackend.flush();
            expect(ctrl.transaction).toEqual([{id: 1, name: 'TestInvestment'}]);
        });
    });

});
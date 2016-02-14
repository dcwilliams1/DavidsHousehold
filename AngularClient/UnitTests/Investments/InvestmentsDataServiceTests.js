describe('Investments Data Service', function() {
    var httpBackend, dataService;
    beforeEach(module('Investments'));
    beforeEach(inject(function($httpBackend, InvestmentsDataService){
        httpBackend = $httpBackend;
        dataService = InvestmentsDataService;
    }));

    it('calls the Express API to post a transaction', function(){
        httpBackend.expectPOST('http://localhost:8081/transaction')
            .respond(200);
        dataService.postTransaction(function (data) {
        });
        httpBackend.flush();
    });

    afterEach(function() {
        httpBackend.verifyNoOutstandingExpectation();
        httpBackend.verifyNoOutstandingRequest();
    });
});

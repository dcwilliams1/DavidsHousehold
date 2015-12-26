var AppHeader = require('./Page Drivers/AppHeaderPageDriver.js');

describe('Routes -', function(){
    describe('Main Menu Categories Link', function(){
        var header;
        beforeEach(function(){
            header = new AppHeader();
        });
        it('should show the Categories view', function(){
            header.moneyLink.click();
            header.categoriesLink.click();
            var content = element(by.css('[ng-view]')).getText();
            expect(content).toMatch('Select a Category');
        });
    });


});
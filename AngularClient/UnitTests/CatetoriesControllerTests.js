describe('CategoriesController', function(){
    var ctrl, dataService;
    beforeEach(module('Money'));

    beforeEach(inject(function($rootScope, $controller, MoneyDataService){
        scope = $rootScope.$new();
        spyOn(MoneyDataService, 'categories')
            .and.returnValue([{id: 1, name: 'TestCategory'}])
        dataService = MoneyDataService;
        ctrl = $controller('CategoriesController', {$scope: scope});
    }));

    it('calls the MoneyDataService', function(){
        var testCategories = ctrl.categories;
        expect(dataService.categories).toHaveBeenCalled();
        expect(dataService.categories.calls.count()).toEqual(1);
        expect(ctrl.categories).toEqual([{id: 1, name: 'TestCategory'}]);
    });
});

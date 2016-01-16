describe('Application Header', function () {
    var appHeaderCtrl, rootScope, compile;
    beforeEach(module('DavidsHousehold'));

    describe('Header Controller', function() {
        beforeEach(inject(function ($controller) {
            appHeaderCtrl = $controller('AppHeaderController');
        }));

        it('should return a user', function () {
            expect(appHeaderCtrl.currentUser).toBeFalsy();
            appHeaderCtrl.getUser();
            expect(appHeaderCtrl.currentUser).toBeTruthy();
        });
    });

    describe('Header Directive', function(){
        it('should have a user', function($compile, $rootScope){
            element = $compile('<household-header></household-header>')($rootScope);
            $rootScope.$digest();
            var userWelcome = angular.element(element.find('#userWelcome'));
            expect(userWelcome.length).toBeGreaterThan(8);
        });
    });
    //describe('Main Menu', function(){
    //    var location;
    //    beforeEach(inject(function($location){
    //        location = $location;
    //    }));
    //
    //    describe('Category Link', function(){
    //       it('should navigate to the category view', function(){
    //            location.path('/');
    //           //navigate here
    //            expect(location.path()).toEqual('/categories');
    //       });
    //    });
    //});
});




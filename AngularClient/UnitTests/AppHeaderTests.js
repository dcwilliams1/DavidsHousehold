describe('Application Header', function () {
    var appHeaderCtrl, rootScope, compile;

    describe('Header Controller', function() {
        beforeEach(module('DavidsHousehold'));
        beforeEach(inject(function ($controller, $compile, $rootScope) {
            appHeaderCtrl = $controller('AppHeaderController');
        }));

        it('should return a user', function () {

            expect(appHeaderCtrl.currentUser).toBeFalsy();
            appHeaderCtrl.getUser();
            expect(appHeaderCtrl.currentUser).toBeTruthy();
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




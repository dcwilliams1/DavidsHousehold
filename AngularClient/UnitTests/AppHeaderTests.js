describe('Application Header', function () {
    var ctrl;
    beforeEach(module('DavidsHousehold'));
    beforeEach(inject(function ($controller) {
        ctrl = $controller('AppHeaderController');
    }));

    describe('Header Controller', function() {
        it('should return a user', function () {
            expect(ctrl.currentUser).toBeFalsy();
            ctrl.getUser();
            expect(ctrl.currentUser).toBeTruthy();
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




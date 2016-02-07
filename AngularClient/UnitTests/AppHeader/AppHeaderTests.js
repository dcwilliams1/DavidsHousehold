describe('Application Header', function () {
    var appHeaderCtrl, appHeaderElement, element;
    beforeEach(module('DavidsHousehold'));
    beforeEach(function(){
        appHeaderElement = angular.element('<household-header></household-header>');

    });

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
        var getUserSpy, element;
        beforeEach(function(){

            //element = $compile('<household-header></household-header>')($rootScope);
            //$rootScope.$digest();
        });
        it('should have a user', function($compile, $rootScope){
            element = $compile('<household-header></household-header>')($rootScope);
            $rootScope.$digest();
            var userWelcome = angular.element(element.find('#userWelcome'));
            expect(userWelcome.length).toBeGreaterThan(8);
        });

        it ('should call the controller to find the user', function(){
            getUserSpy = spyOn(appHeaderCtrl, 'getUser');
           expect(getUserSpy).toHaveBeenCalled;
        });
    });

    describe('Header Menu', function(){
        var location, categoryLink, scope;
        beforeEach(inject(function($location, $rootScope){
            location = $location;
            scope = $rootScope.$new();
        }));

        beforeEach(function() {
            appHeaderElement = angular.element('<household-header></household-header>');
        });

        //describe('Category Link', function(){
        //   it('should navigate to the category view', function(){
        //        location.path('/');
        //       scope.$apply();
        //       expect(location.path()).toBe('/');
        //       categoryLink = angular.element(appHeaderElement.find('#mainMenuCategoryLink'));
        //       categoryLink.triggerHandler('click');
        //       scope.$apply();
        //        expect(location.path()).toBe('/categories');
        //   });
        //});
    });
});




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
        var location, categoryLink;
        beforeEach(inject(function($location){
            location = $location;
        }));

        describe('Category Link', function(){
           it('should navigate to the category view', function(){
                location.path('/');
               categoryLink = angular.element(appHeaderElement.find('#mainMenuCategoryLink'));
               categoryLink.triggerHandler('click');
                expect(location.path()).toEqual('/categories');
           });
        });
    });
});




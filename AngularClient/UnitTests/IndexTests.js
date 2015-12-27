describe('HeaderController', function () {
    var ctrl;
    beforeEach(module('DavidsHousehold'));
    beforeEach(inject(function ($controller) {
        ctrl = $controller('AppHeaderController');
    }));

    it('should return a user', function(){
        expect(ctrl.currentUser).toBeFalsy();
        ctrl.getUser();
        expect(ctrl.currentUser).toBeTruthy();
    });
});

describe('Index Page', function(){
    beforeEach(module('DavidsHousehold'));

    it('should have a sidebar', function(){

    });

});
describe('HeaderController', function () {
    var ctrl,  scope;
    beforeEach(module('DavidsHousehold'));
    beforeEach(inject(function ($controller) {
        ctrl = $controller('AppHeaderController');
    }));

    it('should return a user', function(){
        expect(ctrl.currentUser).toBeFalsy();
        ctrl.getUser();
        expect(ctrl.currentUser).toBeTruthy();
    });
})
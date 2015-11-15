describe('HeaderControllerTests', function () {
    beforeEach(module('DavidsHousehold'));
    var ctrl;
    beforeEach(inject(function ($controller) {
        ctrl = $controller('HeaderController');
    }));

    it('should return a user', function(){
        expect(ctrl.user).toBeFalsy();
        ctrl.getUser();
        expect(ctrl.user).toBeTruthy();
    });
})
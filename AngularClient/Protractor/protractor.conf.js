exports.config = {
    seleniumAddress: 'http://127.0.0.1:4444/wd/hub',

    specs: [
        'RouteTests.js',
        'CategoriesTests.js'
],
    multiCapabilities: [{
        'browserName': 'chrome'
    }],
        //{
    //    'browserName': 'firefox'
    //}],

    baseUrl: 'http://localhost:63342/DavidsHousehold/AngularClient/Index.html'
};

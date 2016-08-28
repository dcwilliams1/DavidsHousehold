// Karma configuration
// Generated on Sat Nov 14 2015 22:47:01 GMT-0700 (Mountain Standard Time)

module.exports = function (config) {
    config.set({

        // base path that will be used to resolve all patterns (eg. files, exclude)
        basePath: '',


        // frameworks to use
        // available frameworks: https://npmjs.org/browse/keyword/karma-adapter
        frameworks: ['jasmine'],


        // list of files / patterns to load in the browser
        files: [
            'AngularClient/App/Assets/libs/angular.js',
            'AngularClient/App/Assets/libs/angular-route.js',
            'node_modules/angular-mocks/angular-mocks.js',
            'AngularClient/App/HouseholdApp.js',
            'AngularClient/App/*.html',
            'AngularClient/App/Shared/Header/AppHeaderController.js',
            'AngularClient/App/Shared/Header/AppHeaderDirective.js',
            'AngularClient/App/Shared/Header/*.html',
            'AngularClient/App/Modules/Budget/Categories/CategoriesController.js',
            'AngularClient/App/Modules/Budget/Categories/categories.html',
            'AngularClient/App/Modules/Budget/MonthEnd/MonthEndController.js',
            'AngularClient/App/Modules/Budget/MonthEnd/MonthEnd.html',
            'AngularClient/App/Modules/Budget/Services/BudgetDataService.js',
            'AngularClient/App/Modules/Investments/InvestmentData/InvestmentDataController.js',
            'AngularClient/App/Modules/Investments/InvestmentData/InvestmentInputForm.html',
            'AngularClient/App/Modules/Investments/Services/InvestmentsDataService.js',
            'AngularClient/UnitTests/AppHeader/*.js',
            'AngularClient/UnitTests/Budget/*.js',
            'AngularClient/UnitTests/Investments/*.js',
        ],


        // list of files to exclude
        exclude: [
        ],


        // preprocess matching files before serving them to the browser
        // available preprocessors: https://npmjs.org/browse/keyword/karma-preprocessor
        preprocessors: {
            "AngularClient/App/Modules/Budget/Categories/CategoriesController.js" : ['coverage'],
            "AngularClient/App/Modules/Budget/Services/BudgetDataService.js" : ['coverage'],
            "AngularClient/App/Modules/Investments/InvestmentData/InvestmentsDataController.js" : ['coverage'],
            "AngularClient/App/Modules/Investments/Services/InvestmentsDataServices.js" : ['coverage'],
            "AngularClient/App/Shared/Header/AppHeaderController.js" : ['coverage'],
            "AngularClient/App/Shared/Header/AppHeaderDirective.js" : ['coverage'],
            "AngularClient/App/Shared/Header/*.html" : ['ng-html2js']
            //'**/*.html': ['ng-html2js']
        },


        // test results reporter to use
        // possible values: 'dots', 'progress'
        // available reporters: https://npmjs.org/browse/keyword/karma-reporter
        reporters: ['progress', 'coverage'],
        coverageReporter: {
      // specify a common output directory
          dir: 'build/reports/coverage'
        },

        // web server port
        port: 9876,


        // enable / disable colors in the output (reporters and logs)
        colors: true,


        // level of logging
        // possible values: config.LOG_DISABLE || config.LOG_ERROR || config.LOG_WARN || config.LOG_INFO || config.LOG_DEBUG
        logLevel: config.LOG_INFO,


        // enable / disable watching file and executing tests whenever any file changes
        autoWatch: true,


        // start these browsers
        // available browser launchers: https://npmjs.org/browse/keyword/karma-launcher
        browsers: ['Chrome'],


        // Continuous Integration mode
        // if true, Karma captures browsers, runs the tests and exits
        singleRun: false,

        // Concurrency level
        // how many browser should be started simultanous
        concurrency: Infinity
    })
}

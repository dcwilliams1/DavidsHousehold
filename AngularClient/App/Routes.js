angular.module('DavidsHousehold')
    .config(function($routeProvider, $locationProvider){
        $routeProvider
            .when('#', {
                templateUrl: 'Modules/Budget/Categories/categories.html',
                controller: 'CategoriesController'
            })
            .when('/', {
                templateUrl: 'Modules/Budget/Categories/categories.html',
                controller: 'CategoriesController'
            })
            .when('/categories', {
                templateUrl: 'Modules/Budget/Categories/categories.html',
                controller: 'CategoriesController'
            });

        //if(window.history && window.history.pushState){
        //    $locationProvider.html5Mode({
        //        enabled: true,
        //        requireBase: false
        //    });
        //}
    });


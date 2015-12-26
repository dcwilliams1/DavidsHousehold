angular.module('DavidsMoney')
    .config(function($routeProvider, $locationProvider){
        $routeProvider
            .when('/', {
                templateUrl: 'Modules/Money/Category',
                controller: 'CategoryController'
            })
            .when('/category', {
                templateUrl: 'Modules/Money/Categories',
                controller: 'CategoriesController'
            })
    });
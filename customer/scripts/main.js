var trackworkApp = angular.module('TrackWorkApp', ['ui.router', 'ngStorage']);

trackworkApp.config(function($stateProvider, $urlRouterProvider) {

  // Default state
  $urlRouterProvider.otherwise('/home');

  // Setting up the states
  $stateProvider
    .state('index', {
      url: '/home',
      templateUrl: 'partials/index.template.html',
      controller: 'IndexController',
      controllerAs: 'index'
    })
    .state('404', {
      url: '/404',
      template: '<h1>404 - Not found</h1>'
    });
});

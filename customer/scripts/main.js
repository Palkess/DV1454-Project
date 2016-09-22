var trackworkApp = angular.module('TrackWorkApp', ['ui.router', 'ngStorage']);

trackworkApp.config(function($stateProvider, $urlRouterProvider) {

  // Default state
  $urlRouterProvider.otherwise('/hem');

  // Setting up the states
  $stateProvider
    .state('index', {
      url: '/hem',
      templateUrl: 'partials/index.template.html',
      controller: 'IndexController',
      controllerAs: 'index'
    })
    .state('booking', {
      url: '/boka',
      templateUrl: 'partials/booking.template.html',
      controller: 'BookingController',
      controllerAs: 'booking'
    })
    .state('404', {
      url: '/404',
      template: '<h1>404 - Not found</h1>'
    });
});

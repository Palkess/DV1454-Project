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
    .state('booked', {
      url: '/jonas/bokade-resor',
      templateUrl: 'partials/booked.template.html',
      controller: 'BookedController',
      controllerAs: 'booked'
    })
    .state('about', {
      url: '/info',
      templateUrl: 'partials/about.template.html'
    })
    .state('404', {
      url: '/404',
      template: '<h1>404 - Not found</h1>'
    });
});

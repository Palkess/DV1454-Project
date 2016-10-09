angular
    .module('TrackWorkApp')
    .controller('BookingController', ['$scope', '$sessionStorage', 'FlightService', BookingController]);

function BookingController($scope, $sessionStorage, FlightService) {
  var vm = this;


  vm.flights = [];

  vm.flight = {
    'class': ''
  };

  FlightService.getAllFlights()
    .then(function(data){
      // Success
      console.log(data);
      vm.flights = data;
    }, function(data){
      // Error
      console.log("Error: " + data);
    });


}

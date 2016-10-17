angular
    .module('TrackWorkApp')
    .controller('BookedController', ['$scope', '$sessionStorage', 'FlightService', BookedController]);

function BookedController($scope, $sessionStorage, FlightService) {
  var vm = this;

  vm.flights = [];

  function updateFlights(){
    FlightService.getAllBookedFlights(1)
      .then(function(data){
        // Success
        console.log(data);

        vm.flights = data;
      }, function(data){
        // Error
      });
  }

  vm.cancelFlight = function(userID, flightID){
    FlightService.cancelFlight(flightID, userID)
      .then(function(data){
        // Success
        console.log(data);
        alert("Ditt flyg har blivit avbokat!");
        updateFlights();
      }, function(data){
        // Error
      });
  };

  updateFlights();
}

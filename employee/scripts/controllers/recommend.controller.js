angular
    .module('TrackWorkApp')
    .controller('RecommendController', ['$scope', '$sessionStorage', 'FlightService', RecommendController]);

function RecommendController($scope, $sessionStorage, FlightService) {
  var vm = this;

  vm.flight = {
    'class': ''
  };

  FlightService.getAllAirPorts()
    .then(function(data){
      // Success
      vm.destinations = data;
    }, function(data){
      // Error
    });

  FlightService.getAllCustomers()
    .then(function(data){
      // Success
      vm.customers = data;
    }, function(data){
      // Error
    });

  vm.searchFlights = function(){
    FlightService.filterFlights(vm.destination, vm.takeoff)
      .then(function(data){
        // Success
        console.log("erer");
        vm.flights = data;
      }, function(data){
        // Error
      });
  };

  vm.bookFlight = function(flightID, customerID, seatType){
    FlightService.bookFlight(flightID, customerID, seatType)
      .then(function(data){
        // Success
        alert("Resan har blivit bokad!");
      }, function(data){
        //Error
        console.log("Error: " + data);
      });

    FlightService.filterFlights(vm.destination, vm.takeoff)
      .then(function(data){
        // Success
        vm.flights = data;
      }, function(data){
        // Error
      });
  };
}

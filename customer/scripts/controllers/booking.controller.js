angular
    .module('TrackWorkApp')
    .controller('BookingController', ['$scope', '$sessionStorage', 'FlightService', BookingController]);

function BookingController($scope, $sessionStorage, FlightService) {
  var vm = this;


  vm.flights = [];

  vm.flight = {
    'class': ''
  };

  vm.bookFlight = function(flightID, customerID, seatType){
    FlightService.bookFlight(flightID, customerID, seatType)
      .then(function(data){
        // Success
        console.log(data);
        console.log("Flight: " + flightID + "Customer: " + customerID + "seatType: " + seatType);
        alert("Resan har blivit bokad!");
      }, function(data){
        //Error
        console.log("Error: " + data);
      });
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

angular
    .module('TrackWorkApp')
    .controller('BookingController', ['$scope', '$sessionStorage', 'FlightService', BookingController]);

function BookingController($scope, $sessionStorage, FlightService) {
  var vm = this;

  vm.seats = 0;

  vm.flights = [];

  vm.flight = {
    'class': '',
    'seats': 0
  };

  var today = new Date();
  var date = today.getFullYear() + "-" + (today.getMonth()+1) + "-" + today.getDate();

  $scope.today = date;

  vm.getDestinations = function(){
      FlightService.getDestinations(vm.departure)
        .then(function(data){
          // Success
          vm.destinations = data;
        }, function(data){
          // Error
        });
  }

  FlightService.getDepartures()
    .then(function(data){
      // Success
      vm.departures = data;
    }, function(data){
      // Error
    });

    FlightService.getDestinations()
      .then(function(data){
        // Success
        vm.destinations = data;
      }, function(data){
        // Error
      });

  vm.setSeats = function(obj, nr){
      nr = parseInt(nr, 10);
      obj.seats = nr;
  }

  vm.searchFlights = function(){
    FlightService.filterFlights(vm.departure, vm.destination, vm.takeoff)
      .then(function(data){
        // Success
        vm.flights = data;
      }, function(data){
        // Error
      });
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
}

angular
    .module('TrackWorkApp')
    .controller('RecommendController', ['$scope', '$sessionStorage', 'FlightService', RecommendController]);

function RecommendController($scope, $sessionStorage, FlightService) {
  var vm = this;

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

  FlightService.getAllCustomers()
    .then(function(data){
      // Success
      vm.customers = data;
    }, function(data){
      // Error
    });

  vm.searchFlights = function(){
    FlightService.filterFlights(vm.departure, vm.destination, vm.takeoff)
      .then(function(data){
        // Success
        console.log("Data: " + data);
        vm.flights = data;
      }, function(data){
        // Error
      });
  };

  vm.setSeats = function(obj, nr){
      nr = parseInt(nr, 10);
      obj.seats = nr;
  }

  vm.bookFlight = function(flightID, customerID, seatType){
    FlightService.bookFlight(flightID, customerID, seatType)
      .then(function(data){
        // Success
        alert("Resan har blivit bokad!");
      }, function(data){
        //Error
        console.log("Error: " + data);
      });

    FlightService.filterFlights(vm.departure, vm.destination, vm.takeoff)
      .then(function(data){
        // Success

        vm.flights = data;
      }, function(data){
        // Error
      });
  };
}

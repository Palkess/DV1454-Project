angular
    .module('TrackWorkApp')
    .controller('BookedController', ['$scope', '$sessionStorage', 'FlightService', BookedController]);

function BookedController($scope, $sessionStorage, FlightService) {
  var vm = this;

  vm.customers = [];
  vm.currentCustomer = null;

  vm.flights = [];

  vm.showCustomer = function(CustomerID){
    vm.currentCustomer = CustomerID;

    updateFlights();
  };

  function getCustomers(){
    FlightService.getAllCustomers()
      .then(function(data){
        //Success
        vm.customers = data;
      }, function(data){
        // Error
      });
  }

  function updateFlights(){
    FlightService.getAllBookedFlights(vm.currentCustomer)
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
        getCustomers();
      }, function(data){
        // Error
      });
  };

  getCustomers();
}

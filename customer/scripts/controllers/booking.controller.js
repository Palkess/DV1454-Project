angular
    .module('TrackWorkApp')
    .controller('BookingController', ['$scope', '$sessionStorage', BookingController]);

function BookingController($scope,$sessionStorage) {
  var vm = this;

  vm.flight = {
    'class': ''
  };
}

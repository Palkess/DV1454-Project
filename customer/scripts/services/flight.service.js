/***
 * FlightService - Factory for handling flights in the database
 *
 */
angular
    .module('TrackWorkApp')
    .factory('FlightService', ['$sessionStorage', '$q', '$http', FlightService]);

function FlightService($sessionStorage, $q, $http) {
  return {
    'getFlights': getFlights,
    'bookFlight': bookFlight
  };

  /**
   * Requests all flights in the database and returns them as json-data
   *
   * @returns promise with data
   */
  function getFlights(){
    return $q(function(resolve, reject){
      $http.get('')
        .then(function(data){
          // Success
          resolve(data.data);
        }, function(data){
          // Error
          reject(data.message);
        });
    });
  }

  /**
   * Books a given flightID
   *
   * @returns promise with a message
   */
  function bookFlight(flightID){
    return $q(function(resolve, reject){
      $http.post('', { flightID: flightID })
        .then(function(data){
          // Success
          resolve(data.data);
        }, function(data){
          // Error
          reject(data.message);
        });
    });
  }
}

/***
 * FlightService - Factory for handling flights in the database
 *
 */
angular
    .module('TrackWorkApp')
    .factory('FlightService', ['$sessionStorage', '$q', '$http', FlightService]);

function FlightService($sessionStorage, $q, $http) {
  return {
    'getAllFlights': getAllFlights,
    'bookFlight': bookFlight
  };

  /**
   * Requests all flights in the database and returns them as json-data
   *
   * @returns promise with data
   */
  function getAllFlights(){
    return $q(function(resolve, reject){
      $http.get('scripts/db/db.php?q=getAllFlights')
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
   * Books a given flightID, sends back a message on the status
   *
   * @param flightID - ID number of the chosen flight
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

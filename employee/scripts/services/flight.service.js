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
    'getAllBookedFlights': getAllBookedFlights,
    'getAllCustomers': getAllCustomers,
    'getAllAirPorts': getAllAirPorts,
    'getAllDepartures': getAllDepartures,
    'getAllDestinations': getAllDestinations,
    'filterFlights': filterFlights,
    'bookFlight': bookFlight,
    'cancelFlight': cancelFlight
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
   * Retrieve all the booked flights based on user
   *
   * @param userID   - ID number of the user
   * @returns promise with a message
   */
  function getAllBookedFlights(userID){
    return $q(function(resolve, reject){
      $http({
          method: 'GET',
          url: 'scripts/db/db.php',
          params: { q:'getAllBookedFlights', userID: userID }
      })
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
   * Retrieve all users
   *
   * @returns promise with a message
   */
  function getAllCustomers(){
    return $q(function(resolve, reject){
      $http({
          method: 'GET',
          url: 'scripts/db/db.php',
          params: { q:'getAllCustomers' }
      })
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
   * Requests all airports
   *
   * @returns promise with data
   */
  function getAllAirPorts(){
    return $q(function(resolve, reject){
      $http.get('scripts/db/db.php?q=getAllAirPorts')
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
   * Requests all active departures
   *
   * @returns promise with data
   */
  function getAllDepartures(){
    return $q(function(resolve, reject){
      $http.get('scripts/db/db.php?q=getAllDepartures')
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
   * Requests all active destinations
   *
   * @returns promise with data
   */
  function getAllDestinations(){
    return $q(function(resolve, reject){
      $http.get('scripts/db/db.php?q=getAllDestinations')
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
   * Filter flights
   *
   * @returns promise with a message
   */
  function filterFlights(departure, destination, takeoff){
    return $q(function(resolve, reject){
      $http({
          method: 'GET',
          url: 'scripts/db/db.php',
          params: {
            q:'filterFlights_new',
            departure: departure,
            destination: destination,
            takeoff: takeoff
           }
      })
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
   * @param userID   - ID number of the user
   * @param seatType - The type of seat chosen
   * @returns promise with a message
   */
  function bookFlight(flightID, userID, seatType){
    return $q(function(resolve, reject){
      $http({
          method: 'GET',
          url: 'scripts/db/db.php',
          params: { q:'bookFlight', flightID: flightID, userID: userID, seatType: seatType }
      })
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
   * Cancel a flight
   *
   * @param flightID - ID number of the chosen flight
   * @param userID   - ID number of the user
   * @returns promise with a message
   */
  function cancelFlight(flightID, userID){
    return $q(function(resolve, reject){
      $http({
          method: 'GET',
          url: 'scripts/db/db.php',
          params: { q:'cancelFlight', flightID: flightID, userID: userID }
      })
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

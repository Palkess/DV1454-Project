<?php

error_reporting(-1);

$string = file_get_contents("preferences.json");
$preferences = json_decode($string, true);

$connection = mssql_connect($preferences['host'], $preferences['user'], $preferences['password']);
mssql_select_db($preferences['database'], $connection);
$sql = "";
$params = array();

//////////////////////////////////////////////
/////// Set up statements for input
//////////////////////////////////////////////

if(isset($_GET['q'])){
  if($_GET['q'] == "getAllFlights"){
    $sql = "SELECT * FROM v_getAllFlights";
  }

  if($_GET['q'] == "bookFlight" &&
    isset($_GET['flightID'])    &&
    isset($_GET['userID'])      &&
    isset($_GET['seatType'])
  )
  {
    $sql = "EXEC p_BookFlight @CustomerID = " . $_GET['userID'] . ", @FlightID = " . $_GET['flightID'] . ", @seatType = " . $_GET['seatType'];
  }
}

//////////////////////////////////////////////
/////// End statements for input
//////////////////////////////////////////////

$result = [];
$query = mssql_query($sql);

if(mssql_num_rows($query)){
  while($row = mssql_fetch_array($query, MSSQL_ASSOC)){
    $result[] = $row;
    if(isset($_GET['verbose']) && $_GET['verbose'] == True){
      echo "<pre>";
      var_dump($row);
      echo "</pre>";
    }
  }
}



header('Content-type: application/json');
echo json_encode($result);

mssql_free_result($query);
mssql_close($connection);

<?php 
// Create connection
$conn = mysqli_connect("localhost", "shaun", "test1234", "ewms");

// Check connection
if(!$conn){echo 'error:' . mysqli_connect_error();}

if(isset($_POST['search'])){
    $search = mysqli_real_escape_string($conn,$_POST['search']);

    $query = "SELECT * FROM user WHERE passport like '".$search."%' ORDER BY passport ASC LIMIT 7";
    $result = mysqli_query($conn,$query);
    
    while($row = mysqli_fetch_array($result) ){
        $response[] = array("value"=>$row['username'],"label"=>$row['passport']);
    }

    echo json_encode($response);
}

exit; ?>


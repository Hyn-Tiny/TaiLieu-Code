<?php
$hostName="localhost";
$userName="root";
$password="";
$database="QLSP";

$conn=mysqli_connect($hostName,$userName,$password,$database);
if($conn)
{echo"ket noi thanh cong";}
else{echo"ket noi khong thanh cong";}
?>
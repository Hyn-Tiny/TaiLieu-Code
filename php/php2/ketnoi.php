<?php
$hostname = "localhost";
$userName = "root";
$password = "";
$database = "QLSV";

// ket noi

$conn = mysqli_connect($hostname, $userName, $password, $database);

if ($conn) {
    echo "kết nối thành công";
} else {
    echo "kết nối không thành công";
}
?>
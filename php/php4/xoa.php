<?php
include("ketnoi.php");
$maID=$_GET["id"];
$query="DELETE FROM `tbl_cuahang` WHERE MaCH='$maID'";
$kq=mysqli_query($conn,$query);

if($kq)
{
    echo"xoa thanh cong";
    header("location:hienthi.php");
}
else
{
    echo "xoa khong thanh cong";
}
mysqli_close($conn);
?>
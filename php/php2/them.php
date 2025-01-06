<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<?php
include("ketnoi.php");

if(isset($_GET["them"]))
{
    $maSV=$_GET["MaSV"];
    $TenSV=$_GET["TenSV"];
    $gioiTinh=$_GET["GioiTinh"];
    $nganh=$_GET["Nganh"];
    $diaChi=$_GET["DiaChi"];

    $query="INSERT INTO `tbl_sinhvien`(`MaSV`, `TenSV`, `GioiTinh`, `Nganh`, `DiaChi`) VALUES ('$maSV','$TenSV','$gioiTinh','$nganh','$diaChi')";

    $kq=mysqli_query($conn,$query);

    if($kq)
    {
        echo"them thanh cong";
        header("location:hienthi.php");
    }
    else
    {
        echo"thêm không thành công";
    }
    mysqli_close($conn);
}

?>
<form action="" method="get">
    <label for="MaSV">Mã SV:</label><input type="text" name="MaSV" id=""><br>
    <label for="TenSV">Tên SV:</label><input type="text" name="TenSV" id=""><br>
    <label for="GioiTinh">Giới tính :</label><input type="text" name="GioiTinh" id=""><br>
    <label for="Nganh">Ngành: </label><input type="text" name="Nganh" id=""><br>
    <label for="DiaChi">Địa Chỉ:</label><input type="text" name="DiaChi" id=""><br>

    <input type="submit" name="them" value="them">
</form>

<a href="hienthi.php">Thoát</a>
</body>
</html>
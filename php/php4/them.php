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


if(isset($_GET["them"])){

    $maCH=$_GET["MaCH"];
    $tenCH=$_GET["TenCH"];
    $chuSoHuu=$_GET["ChuSoHuu"];
    $soLuong=$_GET["SoLuong"];
    $diaChi=$_GET["DiaChi"];

    $query="INSERT INTO `tbl_cuahang`(`MaCH`, `TenCH`, `ChuSoHuu`, `SoLuong`, `DiaChi`) VALUES ('$maCH','$tenCH','$chuSoHuu','$soLuong','$diaChi')";
    $kq=mysqli_query($conn,$query);

    if($kq)
    {
        echo"them thanh cong";
        header("location:hienthi.php");
    }
    else
    {
        echo "them khong thanh cong";
    }
    mysqli_close($conn);
}

?>
    <form action="" method="get">
        <label for="MaCH">Mã Cửa Hàng:</label><input type="text" name="MaCH" id=""><br>
        <label for="TenCH">Tên Cửa Hàng:</label><input type="text" name="TenCH" id=""><br>
        <label for="ChuSoHuu">Chủ Sở Hữu:</label><input type="text" name="ChuSoHuu" id=""><br>
        <label for="SoLuong">Số Lượng:</label><input type="text" name="SoLuong" id=""><br>
        <label for="DiaChi">Địa Chỉ:</label><input type="text" name="DiaChi" id=""><br>
        <input type="submit" name="them" value="them">
    </form>

    <a href="hienthi.php">Thoat</a>
</body>
</html>
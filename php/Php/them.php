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

     if (isset($_GET["them"])) {

        $maKH=$_GET["MaKH"];
        $tenKH=$_GET["TenKH"];
        $gioiTinh=$_GET["GioiTinh"];
        $SDT=$_GET["SDT"];
        $diaChi=$_GET["DiaChi"];
        $query = "INSERT INTO `tbl_khachhang`(`MaKH`, `TenKH`, `GioiTinh`, `SDT`, `DiaChi`) VALUES ('$maKH','$tenKH','$gioiTinh','$SDT','$diaChi')";
        $ketQua = mysqli_query($conn, $query);

        if ($ketQua) {
            echo "them thanh cong";

            header("location:hienthi.php");
        } else {
            echo "them khong thanh cong";
        }
     }
     mysqli_close($conn);
    ?>
</body>

<form action="" method="get">
    <label for="MaKH">Mã KH:</label><input type="text" name="MaKH"><br>
    <label for="TenKH">Tên KH:</label><input type="text" name="TenKH"><br>
    <label for="GioiTinh">Giới Tính</label><input type="text" name="GioiTinh"><br>
    <label for="SDT">SDT</label><input type="text" name="SDT"><br>
    <label for="DiaChi">Địa Chỉ</label><input type="text" name="DiaChi"><br>
    <input type="submit" name="them" value="them">
</form>
<br>
<a href="hienthi.php">thoát</a>
</html>
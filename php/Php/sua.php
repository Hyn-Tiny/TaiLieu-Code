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
        $maID=$_GET["id"];
        $query="SELECT * FROM `tbl_khachhang` WHERE MaKH='$maID'";

        $kq=mysqli_query($conn,$query);

        $rows=mysqli_fetch_row($kq);

        if(isset($_GET["Sua"]))
        {
            $maKH=$_GET["txtMaKH"];
            $tenKH=$_GET["txtTenKH"];
            $gioiTinh=$_GET["txtGioiTinh"];
            $SDT=$_GET["txtSDT"];
            $diaChi=$_GET["txtDiaChi"];

            $query="UPDATE `tbl_khachhang` SET `TenKH`='$tenKH',`GioiTinh`='$gioiTinh',`SDT`='$SDT',`DiaChi`='$diaChi' WHERE MaKH='$maKH'";
            $kq=mysqli_query($conn,$query);
            if($kq)
            {
                echo "sua thanh cong";
                header("location:hienthi.php");
            }
            else
            {
                echo "sua khong thanh cong";
            }

        }
        mysqli_close($conn);
    ?>

<form action="" method="get">
<label for="txtMaKH">Mã KH:</label><input type="text"name="txtMaKH"value="<?php echo $rows[0];?>"><br>
<label for="txtTenKH">Tên KH:</label><input type="text"name="txtTenKH"value="<?php echo $rows[1];?>"><br>
<label for="txtGioiTinh">Giới Tính:</label><input type="text"name="txtGioiTinh"value="<?php echo $rows[2];?>"><br>
<label for="txtSDT">SDT:</label><input type="text"name="txtSDT"value="<?php echo $rows[3];?>"><br>
<label for="txtDiaChi">Địa Chỉ:</label><input type="text"name="txtDiaChi"value="<?php echo $rows[4];?>"><br>

<input type="submit" name="Sua" value="Sua"><br>
<a href="hienthi.php">thoát</a>
</form>
</body>
</html>
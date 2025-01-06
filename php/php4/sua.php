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
    $maID = $_GET["id"];
    $query = "SELECT * FROM `tbl_cuahang` WHERE MaCH='$maID'";
    $kq = mysqli_query($conn, $query);

    $rows = mysqli_fetch_row($kq);
    if (isset($_GET["sua"])) {
        $maCH = $_GET["MaCH"];
        $tenCH = $_GET["TenCH"];
        $chuSoHuu = $_GET["ChuSoHuu"];
        $soLuong = $_GET["SoLuong"];
        $diaChi = $_GET["DiaChi"];

        $query = "UPDATE `tbl_cuahang` SET `MaCH`='$maCH',`TenCH`='$tenCH',`ChuSoHuu`='$chuSoHuu',`SoLuong`='$soLuong',`DiaChi`='$diaChi' WHERE MaCH='$maCH'";
        $kq = mysqli_query($conn, $query);
        if ($kq) {
            echo "sua thanh cong";
            header("location:hienthi.php");
        } else {
            echo "sua khong thanh cong";
        }
    }
    mysqli_close($conn);
    ?>
    <form action="" method="get">
        <label for="MaCH">Mã Cửa Hàng:</label><input type="text" name="MaCH" id="" value="<?php echo $rows[0] ?>"><br>
            <label for="TenCH">Tên Cửa Hàng:</label><input type="text" name="TenCH" id="" value="<?php echo $rows[1] ?>"><br>
            <label for="ChuSoHuu">Chủ Sở Hữu:</label><input type="text" name="ChuSoHuu" id="" value="<?php echo $rows[2] ?>"><br>
            <label for="SoLuong">Số Lượng:</label><input type="text" name="SoLuong" id="" value="<?php echo $rows[3] ?>"><br>
            <label for="DiaChi">Địa Chỉ:</label><input type="text" name="DiaChi" id="" value="<?php echo $rows[4] ?>"><br>
            <input type="submit" name="sua" value="sua">
    </form>

    <a href="hienthi.php">Thoat</a>
</body>

</html>
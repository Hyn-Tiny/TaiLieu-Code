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
    $query = "SELECT * FROM `tbl_sanpham` WHERE  MaSP='$maID'";
    $kq = mysqli_query($conn, $query);
    $rows=mysqli_fetch_row($kq);

    if(isset($_GET["sua"]))
    {
            $maSP=$_GET["MaSP"];
            $tenSP=$_GET["TenSP"];
            $gia=$_GET["Gia"];
            $soLuong=$_GET["SoLuong"];
            $xuatXu=$_GET["XuatXu"];

            $query="UPDATE `tbl_sanpham` SET `TenSP`='$tenSP',`Gia`='$gia',`SoLuong`='$soLuong',`XuatXu`='$xuatXu' WHERE MaSP='$maSP'";
    
            $kq=mysqli_query($conn,$query);
            if($kq)
            {
                echo "sua thanh cong";
                header("location:hienthi.php");
            }
            else{
                echo "sua khong thanh cong";
            }
    }
    mysqli_close($conn);
    ?>

    <form action="" method="get">
        <label for="MaSP">Mã SP:</label><input type="text" name="MaSP" id=""value="<?php echo $rows [0];?>"><br>
        <label for="TenSP">Tên SP:</label><input type="text" name="TenSP" id=""value="<?php echo $rows [1];?>"><br>
        <label for="Gia">Giá:</label><input type="text" name="Gia" id=""value="<?php echo $rows [2];?>"><br>
        <label for="SoLuong">Số Lượng:</label><input type="text" name="SoLuong" id=""value="<?php echo $rows [3];?>"><br>
        <label for="XuatXu">Xuất Xứ:</label><input type="text" name="XuatXu" id=""value="<?php echo $rows [4];?>"><br>

        <input type="submit" name="sua" value="sua">
    </form>
</body>

</html>
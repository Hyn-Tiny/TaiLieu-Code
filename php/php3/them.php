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
            $maSP=$_GET["MaSP"];
            $tenSP=$_GET["TenSP"];
            $gia=$_GET["Gia"];
            $soLuong=$_GET["SoLuong"];
            $xuatXu=$_GET["XuatXu"];

            $query="INSERT INTO `tbl_sanpham`(`MaSP`, `TenSP`, `Gia`, `SoLuong`, `XuatXu`) VALUES ('$maSP','$tenSP','$gia','$soLuong','$xuatXu')";
    
            $kq=mysqli_query($conn,$query);
            if($kq)
            {
                echo "them thanh cong";
                header("location:hienthi.php");
            }
            else{
                echo "them khong thanh cong";
            }
            mysqli_close($conn);
        }

    ?>

    <form action="" method="get">
        <label for="MaSP">Mã SP:</label><input type="text" name="MaSP" id=""><br>
        <label for="TenSP">Tên SP:</label><input type="text" name="TenSP" id=""><br>
        <label for="Gia">Giá:</label><input type="text" name="Gia" id=""><br>
        <label for="SoLuong">Số Lượng:</label><input type="text" name="SoLuong" id=""><br>
        <label for="XuatXu">Xuất Xứ:</label><input type="text" name="XuatXu" id=""><br>

        <input type="submit" name="them" value="them">
    </form>
</body>
</html>
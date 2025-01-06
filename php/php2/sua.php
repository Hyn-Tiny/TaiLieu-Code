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

    $MaID=$_GET["id"];
    $query="SELECT * FROM `tbl_sinhvien` WHERE  MaSV='$MaID'";
    $kq=mysqli_query($conn,$query);

    $rows=mysqli_fetch_row($kq);

    if(isset($_GET["sua"]))
    {
        
    $maSV=$_GET["MaSV"];
    $TenSV=$_GET["TenSV"];
    $gioiTinh=$_GET["GioiTinh"];
    $nganh=$_GET["Nganh"];
    $diaChi=$_GET["DiaChi"];

    $query="UPDATE `tbl_sinhvien` SET `TenSV`='$TenSV',`GioiTinh`='$gioiTinh',`Nganh`='$nganh',`DiaChi`='$diaChi' WHERE MaSV='$maSV'";

    $kq=mysqli_query($conn,$query);

    if($kq)
    {
        echo"sua thanh cong";
        header("location:hienthi.php");
    }
    else
    {
        echo"sua không thành công";
    }
    mysqli_close($conn);
    }

?>

<form action="" method="get">
    <label for="MaSV">Mã SV:</label><input type="text" name="MaSV" id=""value="<?php echo $rows[0] ;?>"><br>
    <label for="TenSV">Tên SV:</label><input type="text" name="TenSV" id=""value="<?php echo $rows[1] ;?>"><br>
    <label for="GioiTinh">Giới tính :</label><input type="text" name="GioiTinh" id=""value="<?php echo $rows[2] ;?>"><br>
    <label for="Nganh">Ngành: </label><input type="text" name="Nganh" id=""value="<?php echo $rows[3] ;?>"><br>
    <label for="DiaChi">Địa Chỉ:</label><input type="text" name="DiaChi" id=""value="<?php echo $rows[4] ;?>"><br>

    <input type="submit" name="sua" value="sua">
</form>

<a href="hienthi.php">Thoát</a>
</body>
</html>
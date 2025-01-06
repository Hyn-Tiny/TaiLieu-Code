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

    $maKH = $_GET["id"];
    $query = "DELETE FROM `tbl_khachhang` WHERE MaKH='$maKH'";

    $ketQua = mysqli_query($conn, $query);

    if ($ketQua) {
        echo ("xoa thanh cong");

        header("location:hienthi.php");
    } else {
        echo ("xoa khong thanh cong");
    }
    mysqli_close($conn);
    ?>

</body>

</html>
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

        $query="SELECT * FROM `tbl_khachhang` WHERE 1";

        echo "<table>
    <tr>
        <th>Mã KH</th>
        <th>Tên KH</th>
        <th>Giới Tính</th>
        <th>SĐT</th>
        <th>Địa Chỉ</th>
        <th>Sửa</th>
        <th>Xóa</th>
    </tr>";
        $ketQua=mysqli_query($conn,$query);

        while($rows = mysqli_fetch_row($ketQua))
        {
            echo"<tr>
        <td>$rows[0]</td>
        <td>$rows[1]</td>
        <td>$rows[2]</td>
        <td>$rows[3]</td>
        <td>$rows[4]</td>
        <td><a href=sua.php?id=".$rows[0].">sua</a></td>
        <td><a href=xoa.php?id=".$rows[0].">xoa</a></td>
        </tr>";
        }
        echo "</table>";
    ?>
    <a href="them.php">them</a>
</body>
</html>
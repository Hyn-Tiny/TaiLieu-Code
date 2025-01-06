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
        $query="SELECT * FROM `tbl_sinhvien` WHERE 1";

        $kq=mysqli_query($conn,$query);
        echo "<table>
    <tr>
        <th> Mã SV </th>
        <th> Tênn SV </th>
        <th> Giới Tính </th>
        <th> Ngành </th>
        <th> Đia Chỉ </th>
        <th> Sửa </th>
        <th> Xóa </th>
    </tr>";
        while($rows=mysqli_fetch_row($kq))
        {
            echo "<tr>
        <td>$rows[0] </td>
        <td>$rows[1]</td>
        <td>$rows[2]</td>
        <td>$rows[3]</td>
        <td>$rows[4]</td>
        <td><a href=sua.php?id=".$rows[0].">Sửa</a></td>
        <td><a href=xoa.php?id=".$rows[0].">Xóa</a></td>
    </tr>";
        }

        echo "</table>";
    ?>
    
<a href="them.php">Thêm</a>
</body>
</html>
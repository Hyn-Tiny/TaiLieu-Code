<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hien thi</title>
</head>

<body>
    <?php
    include("ketnoi.php");
    $query = "SELECT * FROM `tbl_sanpham` WHERE 1";

    $kq = mysqli_query($conn, $query);

    echo "<table>
    <tr>
        <th> Mã SP </th>
        <th> Tên SP </th>
        <th> Giá </th>
        <th> Số lượng </th>
        <th> Xuất Xứ </th>
        <th> Cập nhật </th>
        <th> Xóa </th>
    </tr>";
    while ($rows = mysqli_fetch_row($kq)) {
        echo "<tr>
        <td> $rows[0] </td>
        <td> $rows[1] </td>
        <td> $rows[2] </td>
        <td> $rows[3] </td>
        <td> $rows[4] </td>
        <td><a href=sua.php?id=" . $rows[0] . "> Sửa </a></td>
        <td><a href=xoa.php?id=" . $rows[0] . "> Xóa </a></td>
    </tr>";
    }
    echo "</table>";

    mysqli_close($conn);
    ?>

    <a href="them.php">Them</a>


</body>

</html>
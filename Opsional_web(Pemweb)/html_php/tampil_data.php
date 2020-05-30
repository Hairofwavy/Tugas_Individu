<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WEB</title>
</head>
<body>
<style>
body{
    background-color:#0c090a;
    color:white;
}
#anggota{
background:#transparent;
border:1px solid #ccc;
margin-top:0%;
margin-left:25%;
width:710px;
padding:4px;
border-radius:3px;
}
.tabel{
border:1px solid #ccc;
}
#tr{
border:1px solid #ccc;
background:#444;
color:white;
padding:12px;
text-align:center;
}
</style>
<div id="anggota">
<p align="center">&raquo;ISI DALAM DATABASE&laquo;</p>
<div align="center">
<?php 
error_reporting(E_ALL ^ (E_NOTICE | E_WARNING));
include "koneksi_potsgree.php";
$sql="SELECT * FROM pengguna";
$result = pg_query($sql);
echo"<table border='1px'>";
echo"<tr id='tr'>";
echo"<td>Nama</td>";
echo"<td>jenis Kelamin</td>";
echo"<td>Agama</td>";
echo"<td>Telepon</td>";
echo"<td>Email</td>";
echo"<td>Username</td>";
echo"<td>Password</td>";
echo"</tr>";
while ($row = pg_fetch_array($result))
{
echo "<tr>";
echo"<td>".$row['nama']."</td>";
echo"<td>".$row['jenis_kelamin']."</td>";
echo"<td>".$row['agama']."</td>";
echo"<td>".$row['telepon']."</td>";
echo"<td>".$row['email']."</td>";
echo"<td>".$row['username']."</td>";
echo"<td>".$row['password']."</td>";
echo"</tr>";
}
echo"</table>";
?>
</div>
<br><br>
<td><button type="button" style="font-size=20px;border-radius:3px;padding:10px 10px;"
    onclick="jalankanScript();">Kembali</button></td>

</body>
</html>

<script>
function jalankanScript() {
    var yakin = confirm("Apakah kamu yakin untuk kembali ke menu Login?");

        if (yakin) {
            window.location = "Flogin.php";
        } else {
            document.write("Baiklah, tetap di sini saja ya :)");
        }
}
</script>



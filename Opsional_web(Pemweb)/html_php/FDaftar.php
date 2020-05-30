<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WEB</title>
</head>
<body>
    <!-- CSS -->
<style>
body{
        background-repeat:no-repeat;
        margin:0;
        background-image: url(../img/daniil-silantev-hjODrLxv55E-unsplash.jpg);
        background-size:cover;

    }
#daftar{
color:#0c090a;
background:#transparent;
border:1px solid #ccc;
margin-top: 10%;
margin-left: 35%;
width:400px;
padding:4px;
border-radius:5px;
}
.texbox{
border:1px solid #ccc;
height:25px;
}
.btn{
width:85px;
height:30px;
color:#099;
font-weight:bold;
margin-bottom:3px;
}
.btn:hover{
background:#333;
color:#fff;
font-weight:bold;
cursor:pointer;
border:2px solid #099;
border-radius:4px;
}
</style>
<!-- Akhir CSS -->


<div id="daftar">
<p align="center">&raquo;FORM PENDAFTARAN&laquo;</p>
<table border="0px">
<form method="post" enctype="multipart/form-data">
<tr><td>Nama Lengkap</td> <td>:</td> <td><input name="nama" size="25" class="texbox"></td></tr>
<tr><td>Jenis Kelamin</td><td>:</td><td><select name="jk" class="texbox" value="<?php $_POST['jk']?>">
<option value="pilih">--Pilih--</option>
<option value="Laki-laki">Laki-laki</option>
<option value="Perempuan">Perempuan</option>
<option value="Other">Other</option>
</select></td></tr>
<tr><td>Agama</td><td>:</td><td><select name="agama" class="texbox" value="<?php $_POST['agama']?>>
<option value="pilih">--Pilih--</option>
<option value="pilih">--Pilih--</option>
<option value="Islam">Islam</option>
<option value="kristen">Kristen</option>
<option value="Hindu">Hindu</option>
<option value="buddha">Buddha</option>
<option value="Other">Other</option>
</select></td></tr>
<tr><td>Telepon</td> <td>:</td><td><input name="telepon" size="25" class="texbox"></td></tr>
<tr><td>Email</td> <td>:</td><td><input name="email" size="25" class="texbox"></td></tr>
<tr><td>Username</td> <td>:</td><td><input name="uname" size="25" class="texbox"></td></tr>
<tr><td>Password</td> <td>:</td><td><input type ="password" name="pass" size="25" class="texbox"></td></tr>
<tr><td><input type="submit" value="Simpan" class="btn">
<input type="hidden" name="act" value="add" class="btn"></td></tr>
</table>
</form>
</div>
<!-- php isi Database -->
<?php
error_reporting(E_ALL ^ (E_NOTICE | E_WARNING));
$db = pg_connect("host=localhost port=5433 dbname=ProjectUAS user=postgres password=220100");
if ($_POST['act']=="add"){
$sql_add="INSERT INTO pengguna (nama,jenis_kelamin,agama,telepon,email,username,password) VALUES 
("."
 
'".$_POST['nama']."',
'".$_POST['jk']."',
'".$_POST['agama']."',
'".$_POST['telepon']."',
'".$_POST['email']."',
'".$_POST['uname']."',
'".$_POST['pass']."') ";
$result = pg_query($sql_add);
echo'<script>alert("Data Berhasil Disimpan");window.location ="tampil_data.php";</script>';
}
?>
<!-- akhir isi Database -->
</body>
</html>
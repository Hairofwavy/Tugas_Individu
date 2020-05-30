<?php 
include 'koneksi_potsgree.php';
 
$username = $_POST['username'];
$password = $_POST['pass1'];
 
$login = pg_query("select * from pengguna where username='$username' and password='$password'");
$cek = pg_num_rows($login);
// cek apakah data ada dalam database
if($cek > 0){
	session_start();
	$_SESSION['username'] = $username;
	$_SESSION['status'] = "login";
	header("location:sesion.php");
}else{
	header("location:FormHome.html");	
}


 
?>
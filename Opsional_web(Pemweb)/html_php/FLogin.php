<?php
include 'koneksi_potsgree.php';
?>

<!DOCTYPE HTML>  
<html>
<head>
<meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WEB</title>

    <!-- CSS -->
    <style>
      a {
        text-decoration: none;
        }
      body{background: url(../img/gunung.jpg);
  	    margin: 0;
  	    padding: 0;
  	    background-size: cover;
  	    background-repeat: no-repeat;
  	    background-attachment: fixed;
        }

        .card {
        background: #fbfbfb;
        border-radius: 8px;
        box-shadow: 1px 2px 8px rgba(0, 0, 0, 0.65);
        height: 410px;
        margin: 6rem auto 8.1rem auto;
        width: 329px;
        }
        .card-title {
        font-family: "Raleway Thin", sans-serif;
        letter-spacing: 4px;
        padding-bottom: 23px;
        padding-top: 13px;
        text-align: center;
        }
                     

    </style>
    <!-- akhirCSS -->
</head>
<body>  

<div class ="card">
  <div class= "card-title">
    <h1>LOGIN</h1>
<form method="post" action="login.php" onSubmit="return validasi()">  
     <tr><td>Username:</td><td><input type="text" name="username" id="username"></td></tr>
      <br><br>
     <tr><td>Password:</td><td><input type="password" name="pass1" id= "pass1"></td></tr>
      <br><br><br><br>
          <a href="Zonk.html"> Lupa password?</a>
          <a href="FDaftar.php"> Buat Akun</a>
      <br><br>
      <input type="submit" name="submit" value="LOGIN">  
  </div>
</div>
</form>


</body>

<script type="text/javascript">
	function validasi() {
		var username = document.getElementById("username").value;
		var pass1 = document.getElementById("pass1").value;		
		if (username != "" && password!="") {
			return true;
		}else{
			alert('Username dan Password harus di isi !');
			return false;
		}
	}
 
</script>
</html>
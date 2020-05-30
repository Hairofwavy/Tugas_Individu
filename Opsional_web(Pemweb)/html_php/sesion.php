<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WEB</title>
    <!-- CSS -->
    <link rel="stylesheet" href="../css/sesion.css">
    <!-- akhirCSS -->
    <!-- Font -->
    <link href="https://fonts.googleapis.com/css2?family=Lobster&family=Viga&display=swap" rel="stylesheet">
    <!-- akhirFont -->
</head>
<body>
    <form action="">

<tr>
    <td><div class= "konten">
        <div class="type">
        <!-- PHP -->
        <?php
        include 'koneksi_potsgree.php';
        
        // mengaktifkan session
        session_start();
        
        // cek apakah user telah login, jika belum login maka di alihkan ke halaman login
        if($_SESSION['status'] =="login"){
            // menampilkan pesan selamat datang
            echo "Hai, selamat datang ". $_SESSION['username'];
        } else {
            header("location:Flogin.php");

        } 
        ?>
        <!-- akhir PHP -->
        </div>
    </div>
    <div class="tombol">
        <a href="logout.php">LOGOUT</a>    
    </div>
    </td>
        <td>
            <img src="../img/kisspng-lady-justice-symbol-criminal-justice-clip-art-auction-5abafbf9ecef67.2388397715222036419705.png" alt="Keadilan" >
        </td>
</tr>
        </form>
           
</body>
</html>


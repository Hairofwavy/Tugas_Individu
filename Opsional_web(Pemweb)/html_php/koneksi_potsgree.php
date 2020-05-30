<!DOCTYPE html>
<html>
    <head>
        <title>WEB</title>
    </head>
    <body>
    <?php

            // konfigurasi koneksi
            $host       =  "localhost";
            $dbuser     =  "postgres";
            $dbpass     =  "220100";
            $port       =  "5433";
            $dbname    =  "ProjectUAS";


            $db = pg_connect("host=localhost port=5433 dbname=ProjectUAS user=postgres password=220100");
            // script koneksi php postgree
            $link = new PDO("pgsql:dbname=$dbname;host=$host", $dbuser, $dbpass); 
                
            if($link)
            {
                echo "<script type = 'text/javascript'>
                alert('Koneksi Database berhasil');
            </script>";
            }else
            {
                echo "<script type = 'text/javascript'>
                alert('Koneksi Database gagal');
            </script>";
            }
            ?>
                        
    </body>
</html>

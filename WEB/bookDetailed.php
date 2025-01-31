<?php
    session_set_cookie_params([
        'lifetime' => 0, // Expire when browser closes
        'path' => '/',
        'domain' => '',
        'httponly' => true, // Prevent JS access
        'samesite' => 'Strict' // Prevent CSRF
      ]);
    session_start();

    if(isset($_GET["ISBN"]) && count($_GET)==1){
        require_once "../BACKEND/databaseFunctions.php";

        $book_data = GetBookByIsbn($_GET["ISBN"]);
        
    }else{
        header("Location: ./");
    }
?>

<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php 
        if($book_data == []){
            echo "Nincs ilyen könyvünk!";
        }else{
            echo $book_data["title"];
        }
    ?></title>
    <link rel="stylesheet" href="style.css">
</head>
<body>

<div class="content__container">

    <?php
        if($book_data == []){
            echo "404 Nincs ilyen könyvünk!";
            return;
        }else{
            /* print "<pre>";
            var_dump($book_data);
            print "</pre>"; */
            require "navbar.html";
            require "showDetailed.php";

        }

        //it's not done, there are still data to be placed in, and it should check every time if the $book_data is empty or not, or we should do something else
    ?>
    
    </div>
</div>

</body>
</html>

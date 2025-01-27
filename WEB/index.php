<?php
session_start();
$page = isset($_GET['page']) ? $_GET['page'] : 'mainPage';

if($page == "userDetailed" && !isset($_SESSION["user_id"])){
  $page = "mainPage";
}

?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title><?php 
    if ($page === 'mainPage') {
        echo "Főoldal";

    }else if ($page === 'bookList') {
        echo "Könyveink";

    }else if ($page === 'aboutUs') {
      echo "Rólunk";

    }else if ($page === 'userDetailed') {
      echo "Felhasználói oldal";

    }else {
        echo "Az oldal nem található";
    }
  
  ?></title>
  <link rel="stylesheet" href="style.css">
  <script defer src="main.js"></script>
  <script src="jquery.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>
</head>
<body>
  
  <?php
    require_once "navbar.html";
    var_dump($_SESSION);

    if ($page === 'mainPage') {
        require_once "mainPage.php";

    }else if ($page === 'bookList') {
        require_once "bookList.php";

    }else if ($page === 'aboutUs') {
      require_once "aboutUs.php";

    }else if ($page === 'userDetailed') {
      if(isset($_SESSION["user_id"])){
        require_once "userDetailed.php";
      }

    }else {
        echo "<h2>Az oldal nem található</h2>";
    }
    
    require_once "footer.html";
    
  ?>
</html>
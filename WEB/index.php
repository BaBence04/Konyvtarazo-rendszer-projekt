<?php
require_once "../BACKEND/databaseFunctions.php";

session_set_cookie_params([
  'lifetime' => 0, // Expire when browser closes
  'path' => '/',
  'domain' => '',
  'httponly' => true, // Prevent JS access
  'samesite' => 'Strict' // Prevent CSRF
]);

session_start();

// If the user is not logged in, check for the "remember me" cookie
if (!isset($_SESSION['user_id']) && isset($_COOKIE['remember_me'])) {
  $token = $_COOKIE['remember_me'];
  
  
  $data = create_token($token, -1, "remember_me");

  if ($data["result"] == "loginFound") {
      // Token is valid, log the user in
      $_SESSION['user_id'] = $data['user_id'];
      $_SESSION["restricted"] = $data["member"]=="false"?"true":"false";

      //we may want to update the token 

  } else {
      // Token is invalid or expired, delete the cookie
      setcookie('remember_me', '', time() - 3600, '/');
  }
}


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
    // var_dump($_SESSION);

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
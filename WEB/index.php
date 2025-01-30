<?php
session_start();

// If the user is not logged in, check for the "remember me" cookie
// if (!isset($_SESSION['user_id']) && isset($_COOKIE['remember_me'])) {
//   $token = $_COOKIE['remember_me'];

  

//   if ($row && strtotime($row['expires_at']) > time()) {
//       // Token is valid, log the user in
//       $_SESSION['user_id'] = $row['user_id'];

//       // Optionally, regenerate the session ID for security
//       session_regenerate_id(true);

//       // Optionally, refresh the token and update the cookie
//       $newToken = bin2hex(random_bytes(64));
//       $newExpires = time() + (30 * 24 * 60 * 60);

//       $stmt = $pdo->prepare("UPDATE persistent_logins SET token = ?, expires_at = ? WHERE token = ?");
//       $stmt->execute([$newToken, date('Y-m-d H:i:s', $newExpires), $token]);

//       setcookie('remember_me', $newToken, $newExpires, '/', '', true, true);
//   } else {
//       // Token is invalid or expired, delete the cookie
//       setcookie('remember_me', '', time() - 3600, '/');
//   }
// }


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
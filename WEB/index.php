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

      //generate new token for security reasons
      do{
          $token = generate_token(1);
      }while(create_token($token, $_SESSION["user_id"], "remember_me")["result"] == "false");

      delete_token($token);
      
      $expires = time() + (30 * 24 * 60 * 60); // 30 days from now
      // Set a long-lived cookie
      setcookie('remember_me', $token, $expires, '/', '', true, true); // Secure and HTTP-only

  } else {
      // Token is invalid or expired, delete the cookie
      setcookie('remember_me', '', time() - 3600, '/');
  }
}

$path = explode("?",explode("web/",$_SERVER['REQUEST_URI'])[1])[0];
$parts_of_path = explode("/", $path);
$page_to_load = "mainPage";
$page_title = "Főoldal";

if(count($parts_of_path) == 1){
  if($path == "fiok"){
    if(isset($_SESSION["user_id"])){
      $page_to_load = "userDetailed";
      $page_title = "Fiók";
    }     
    
  }elseif($path == ""){
    $page_to_load = "mainPage";
    $page_title = "Főoldal";

  }elseif($path == "konyveink"){
    $page_to_load = "bookList";
    $page_title = "Könyveink";

  }elseif($path == "rolunk"){
    $page_to_load = "aboutUs";
    $page_title = "Rólunk";

  }elseif($path == "kapcsolat"){
    $page_to_load = "contacts";
    $page_title = "Kapcsolat";
  }

}elseif(count($parts_of_path) == 2){
  //book detailed
  if($parts_of_path[0] == "konyveink"){
    $isbn = $parts_of_path[1];
    $book_data = GetBookByIsbn($isbn);
    if($book_data != []){
      $page_to_load = "bookDetailed";
      $page_title = $book_data["title"];
    }
  }
}


?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title><?=$page_title?></title>
  <link rel="stylesheet" href="/web/style.css">
  <script src="/web/jquery.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>
  
  <link rel="android-chrome" sizes="192x192" href="/web/icons/android-chrome-192x192.png">
  <link rel="android-chrome" sizes="512x512" href="/web/icons/android-chrome-512x512.png">
  <link rel="apple-touch-icon" sizes="180x180" href="/web/icons/apple-touch-icon.png">
  <link rel="icon" type="image/png" sizes="32x32" href="/web/icons/favicon-32x32.png">
  <link rel="icon" type="image/png" sizes="16x16" href="/web/icons/favicon-16x16.png">
  <link rel="manifest" href="/web/site.webmanifest">
    <link rel="shortcut icon" href="/web/icons/favicon.ico" type="image/x-icon">
</head>
<body>
  <?php require_once "navbar.html"; ?>
  <div class="space-after-nav"></div>
  <?php
    if ($page_to_load === 'mainPage') {
      require_once "mainPage.php";

    }else if ($page_to_load === 'bookList') {
      require_once "bookList.php";

    }else if ($page_to_load === 'aboutUs') {
      echo "rólunk oldal";
    }else if ($page_to_load === 'userDetailed') {
      require_once "userDetailed.php";      

    }else if($page_to_load === "bookDetailed"){
      require_once "bookDetailed.php";

    }else if($page_to_load === "contacts"){
      echo "kapcsolatok oldal"; 
    }else {
        echo "<h2>Az oldal nem található</h2>";
    }
    
    require_once "footer.html";
    
  ?>
</html>
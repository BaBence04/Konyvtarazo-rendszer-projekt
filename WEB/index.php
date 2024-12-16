<?php
$page = isset($_GET['page']) ? $_GET['page'] : 'mainPage';

require "navbar.html";

if ($page === 'mainPage') {
    require "mainPage.php";
} elseif ($page === 'bookList') {
    require "bookList.php";
} elseif ($page === 'aboutUs') {
  require "aboutUs.php";
} else {
    echo "<h2>Az oldal nem található</h2>";
}

require "footer.html";
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Főoldal</title>
  <link rel="stylesheet" href="style.css">
</head>
<body>

<script defer src="main.js"></script>

</body>
</html>
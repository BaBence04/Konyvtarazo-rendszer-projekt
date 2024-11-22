<?php
    require "../BACKEND/elementCreators.php";
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bookstore Grid Layout</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <h1>Összes könyvünk</h1>
    <?php
        echo CreateGenreFilter();
    ?>
    
    <?php
        $title = "";
        $genre = "";
        $author = "";
        $release_date = "";
        $lang = "";
        $isbn = "";
        if(isset($_GET['title'])){
            $title = $_GET['title'];
        }

        if(isset($_GET['genre'])){
            $genre = $_GET['genre'];
        }

        if(isset($_GET['author'])){
            $author = $_GET['author'];
        }

        if(isset($_GET['release_date'])){
            $release_date = $_GET['release_date'];
        }

        if(isset($_GET['lang'])){
            $lang = $_GET['lang'];
        }
 
        if(isset($_GET['isbn'])){
            $isbn = $_GET['isbn'];
        }
        echo CreateListedBooksElements("", "", "", "","", "");
    ?>
    <script src="jquery.js"></script>
    <script>
        
    </script>
</body>
</html>

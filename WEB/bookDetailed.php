<?php
    if(isset($_GET["ISBN"]) && count($_GET)==1){
        require "../BACKEND/databaseFunctions.php";

        $book_data = GetBookByIsbnId($_GET["ISBN"]);
        
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
        }else{
            print "<pre>";
            var_dump($book_data);
            print "</pre>";


        }

        //it's not done, there are still data to be placed in, and it should check every time if the $book_data is empty or not, or we should do something else
    ?>
    <div class="book-details">
        <div class="book-image">
            <img src="<?=$book_data["picture_base64"]?>" alt="Book Image">
        </div>

        <div class="book-info">
            <div class="book-title">Könyv Címe</div>
            <div class="book-author">Szerző Neve</div>

            <div class="book-genres">
                <span>#Fantasy</span>
                <span>#Sci-fi</span>
                <span>#Rejtély</span>
            </div>

            <div class="book-description">
                Ez egy rövid leírás a könyvről. Bemutatja a könyv történetét, a karaktereket és a cselekmény fő elemeit. Ez a szöveg segít az olvasóknak eldönteni, hogy érdekesnek találják-e a könyvet, és hogy szeretnék-e elolvasni.
            </div>

            <div class="availability">Elérhető</div>

            <div class="buttons">
                <button class="wishlist-button">Kívánságlistához adás</button>
                <button class="reserve-button">Foglalás most</button>
            </div>
        </div>
    </div>
</div>

</body>
</html>

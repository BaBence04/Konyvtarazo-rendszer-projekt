<?php
    if(isset($_GET["ISBN"]) && count($_GET)==1){
        require "../BACKEND/databaseFunctions.php";

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
            require "showDetailed.php";


        }

        //it's not done, there are still data to be placed in, and it should check every time if the $book_data is empty or not, or we should do something else
    ?>
    
    </div>
</div>
<script src="jquery.js"></script>
<script>
    function reserveOrBook(){
        if(<?=isset($_SESSION['user_id'])?>){
           $.ajax({
            url: "../BACKEND/api.php",
            type: "POST", //send it through get method
            data: { 
                user_id: <?=$_SESSION['user_id']?>, 
                isbn_id: <?=$book_data['ISBN_id']?> 
            },
            success: function(response)  {
                //Ezt is szép fancyre meg kell csinálni
               if(response != '<?=$availability_data["status"]?>'){
                    alert("közben megváltozott");
               }
               document.getElementById("reserve-button").disabled = true;
            }
            }); 
        }
    }
</script>
</body>
</html>

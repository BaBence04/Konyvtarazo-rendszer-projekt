<?php
    require "../BACKEND/elementCreators.php";

    //DEV THING REMOVE WHEN PROD OR LOGIN DONE
    session_start();
    print_r($_SESSION)
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bookstore Grid Layout</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <h1>Összes könyvünk</h1>
    <?php
        echo CreateFilter();
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
 
        if(isset($_GET['ISBN'])){
            $isbn = $_GET['ISBN'];
        }

    ?>
    <div id="test"><?php
    echo CreateListedBooksElements($title, $genre, $author, $release_date, $lang, $isbn);?>
    </div>
        
    <script src="jquery.js"></script>
    <script>
       function applyFilters(){
            $.ajax({
            url: "../BACKEND/api.php",
            type: "get", //send it through get method
            data: { 
                title: $("#title")[0].value, 
                genre: $("#genre-select")[0].value, 
                author: $("#author")[0].value,
                release_date: $("#date")[0].value, 
                lang: $("#lang-select")[0].value, 
                ISBN: $("#ISBN")[0].value
            },
            success: function(response)  {
                $("#test")[0].innerHTML = response; 
                var extra = "?";
                if($("#title")[0].value!=""){
                    extra+= "title="+$("#title")[0].value+"&";
                }
                if($("#genre-select")[0].value!=""){
                    extra+= "genre="+$("#genre-select")[0].value+"&";
                }
                if($("#author")[0].value!=""){
                    extra+= "author="+$("#author")[0].value+"&";
                }
                if($("#date")[0].value!=""){
                    extra+= "release_date="+$("#date")[0].value+"&";
                }
                if($("#lang-select")[0].value!=""){
                    extra+= "lang="+$("#lang-select")[0].value+"&";
                }
                if($("#ISBN")[0].value!=""){
                    extra+= "ISBN="+$("#ISBN")[0].value+"&";
                }
                if(extra.length>1){
                    extra = extra.slice(0, -1);
                }
                window.history.pushState({},"",extra);
            }
            });
       } 
    </script>
</body>
</html>

<?php
    require "../BACKEND/elementCreators.php";


?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bookstore Grid Layout</title>
    <link rel="stylesheet" href="./style.css">
    <script defer src="main.js"></script>
</head>
<body>
    <h1>Összes könyvünk</h1>
    <?php
        require_once "bookListFilters.php";
    ?>
    
    <?php
        $title = "";
        $genre = "";
        $author = "";
        $release_date = "";
        $lang = "";
        $isbn = "";
        $page_number = 1;
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

        if(isset($_GET["page_number"])){
            $page_number = $_GET["page_number"];
        }

    ?>
    <div id="results">
        <?=create_listed_books_elements($title, $genre, $author, $release_date, $lang, $isbn, $page_number)?>
    </div>
        
    <script src="jquery.js"></script>
    <script>
       function applyFilters(){
            const currentUrl = new URL(window.location);

            currentUrl.searchParams.delete("page_number");

            $.ajax({
            url: "../BACKEND/api.php",
            type: "get", //send it through get method
            data: { 
                title: document.getElementById("title").value, 
                genre: document.getElementById("genre-select").value, 
                author: document.getElementById("author").value,
                release_date: document.getElementById("date").value, 
                lang: document.getElementById("lang-select").value, 
                ISBN: document.getElementById("ISBN").value,
                page_number: 1
            },
            success: function(response)  {
                document.getElementById("results").innerHTML = response; 
                // var extra = "?";
                if(document.getElementById("title").value!=""){
                    // extra+= "title="+document.getElementById("title").value+"&";
                    currentUrl.searchParams.set("title", document.getElementById("title").value);
                }
                if(document.getElementById("genre-select").value!=""){
                    // extra+= "genre="+document.getElementById("genre-select").value+"&";
                    currentUrl.searchParams.set("genre", document.getElementById("genre-select").value);
                }
                if(document.getElementById("author").value!=""){
                    // extra+= "author="+document.getElementById("author").value+"&";
                    currentUrl.searchParams.set("author", document.getElementById("author").value);
                    
                }
                if(document.getElementById("date").value!=""){
                    // extra+= "release_date="+document.getElementById("date").value+"&";
                    currentUrl.searchParams.set("release_date", document.getElementById("date").value);
                }
                if(document.getElementById("lang-select").value!=""){
                    // extra+= "lang="+document.getElementById("lang-select").value+"&";
                    currentUrl.searchParams.set("lang", document.getElementById("lang-select").value);
                }
                if(document.getElementById("ISBN").value!=""){
                    // extra+= "ISBN="+document.getElementById("ISBN").value+"&";
                    currentUrl.searchParams.set("ISBN", document.getElementById("ISBN").value);
                }
                // if(extra.length>1){
                //     extra = extra.slice(0, -1);
                // }
                // window.history.pushState({},"",extra);
                window.history.pushState({}, "", currentUrl);
            }
            });
       } 
    </script>
</body>
</html>

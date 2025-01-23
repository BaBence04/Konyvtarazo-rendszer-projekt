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


            if(document.getElementById("title").value!=""){
                // extra+= "title="+document.getElementById("title").value+"&";
                currentUrl.searchParams.set("title", document.getElementById("title").value);
            }else{
                currentUrl.searchParams.delete("title");
            }

            if(document.getElementById("genre-select").value!=""){
                // extra+= "genre="+document.getElementById("genre-select").value+"&";
                currentUrl.searchParams.set("genre", document.getElementById("genre-select").value);
            }else{
                currentUrl.searchParams.delete("genre");
            }

            if(document.getElementById("author").value!=""){
                // extra+= "author="+document.getElementById("author").value+"&";
                currentUrl.searchParams.set("author", document.getElementById("author").value);   
            }else{
                currentUrl.searchParams.delete("author");
            }

            if(document.getElementById("date").value!=""){
                // extra+= "release_date="+document.getElementById("date").value+"&";
                currentUrl.searchParams.set("release_date", document.getElementById("date").value);
            }else{
                currentUrl.searchParams.delete("release_date");
            }

            if(document.getElementById("lang-select").value!=""){
                // extra+= "lang="+document.getElementById("lang-select").value+"&";
                currentUrl.searchParams.set("lang", document.getElementById("lang-select").value);
            }else{
                currentUrl.searchParams.delete("lang");
            }

            if(document.getElementById("ISBN").value!=""){
                // extra+= "ISBN="+document.getElementById("ISBN").value+"&";
                currentUrl.searchParams.set("ISBN", document.getElementById("ISBN").value);
            }else{
                currentUrl.searchParams.delete("ISBN");
            }

            window.history.pushState({}, "", currentUrl);

            UpdateResults();
        }

             

        function UpdateResults(){
            const currentUrl = new URL(window.location);


            $.ajax({
            url: "../BACKEND/api.php",
            type: "get", //send it through get method
            data: { 
                title: currentUrl.searchParams.get("title"), 
                genre: currentUrl.searchParams.get("genre"), 
                author: currentUrl.searchParams.get("author"),
                release_date: currentUrl.searchParams.get("release_date"), 
                lang: currentUrl.searchParams.get("lang"), 
                ISBN: currentUrl.searchParams.get("ISBN"),
                page_number: currentUrl.searchParams.get("page_number")==null?1:currentUrl.searchParams.get("page_number")
            },
            success: function(response)  {
                document.getElementById("results").innerHTML = response; 
            }
            });
        }
        
        function SearchOnEnter(event){
            if(event.key == "Enter"){
               applyFilters();
            }
        }

        function NavigateToNextOrPreviousPage(direction){
            if(direction == 1 || direction == -1){
                const currentUrl = new URL(window.location);
                const currentPageNumber = currentUrl.searchParams.get("page_number")==null?1:currentUrl.searchParams.get("page_number")*1;

                let newPageNumber = Math.max(currentPageNumber+direction, 0);
                

                if(newPageNumber == 1){
                    currentUrl.searchParams.delete("page_number");
                }else{
                    currentUrl.searchParams.set("page_number", newPageNumber);
                }
                
                window.history.pushState({}, '', currentUrl);

                UpdateResults();
            }
        }

    </script>
</body>
</html>

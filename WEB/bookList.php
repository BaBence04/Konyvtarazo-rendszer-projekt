<?php
    require "../BACKEND/elementCreators.php";


?>

<h1>Könyveink</h1>

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

<main>
    <?php require_once "bookListFilters.php";?>
    
    <div id="results">
        <?=create_listed_books_elements($title, $genre, $author, $release_date, $lang, $isbn, $page_number)?>
    </div>
</main>

    
<script src="/web/bookList.js"></script>
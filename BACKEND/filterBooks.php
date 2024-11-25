<?php
    require "elementCreators.php";
    if(isset($_GET['title'])&& isset($_GET['genre'])&& isset($_GET['author'])&& isset($_GET['release_date'])&&isset($_GET['lang'])&& isset($_GET['ISBN'])){
        return CreateListedBooksElements($_GET['title'], $_GET['genre'], $_GET['author'],$_GET['release_date'], $_GET['lang'], $_GET['ISBN']);
    }
?>
<?php
    session_start();
    require "../BACKEND/elementCreators.php";
    //if no userid in session login-screen if yes userdetailed
    if(isset($_SESSION['user_id'])){
        require "userDetailed.php";
    }else{
        require "login.php";
    }

?>
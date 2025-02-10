<?php
do{
    $conn  = mysqli_connect("localhost", "root", "", "konyvtar");
}while(mysqli_connect_errno());

// Change character set to utf8
$conn -> set_charset("utf8");
?>
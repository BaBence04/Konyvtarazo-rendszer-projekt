<?php
    require "databaseFunctions.php";
    require "elementCreators.php";
    //listBooksFiltered

    if($_SERVER['REQUEST_METHOD'] === 'GET'){
        if(isset($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["isbn"]) && count($_GET)==6){
            print_r(CreateListedBooksElements($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["isbn"]));
    
        }

    }else if($_SERVER['REQUEST_METHOD'] === "POST"){
        if(isset($_POST["username"],$_POST["password"]) && count($_POST)==2){
            $hashedPasswordFromDb = GetPassword($_POST["username"])[0]["password"];
            if(password_verify($_POST["password"],$hashedPasswordFromDb)){
                print "valid";
            }else{
                print "invalid";
            }
        }
    }




?>
<?php
    require_once "databaseFunctions.php";
    require "elementCreators.php";
    //listBooksFiltered

    if($_SERVER['REQUEST_METHOD'] === 'GET'){
        if(isset($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["ISBN"]) && count($_GET)==6){
            print_r(CreateListedBooksElements($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["ISBN"]));
    
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
        if(isset($_POST['user_id'], $_POST['isbn_id'])){
            echo AddReservationOrBooking($_POST['isbn_id'], $_POST['user_id']);
        }
        //PASSWORD CHECK IS NOT FINAL IT IS NOT HASHING
        if(isset($_POST['uname'], $_POST['pw'])){
            $gotPw = GetPassword($_POST['uname']);
            if($gotPw == "not found" || $gotPw == "inactive user"){
                echo $gotPw;
            }else{
                if($gotPw == $_POST['pw']){
                    session_start();
                    $_SESSION['user_id'] = GetUserId($_POST['uname']);
                    echo "success";
                }else{
                    echo "incorrect";
                }
            }

        }
    }




?>
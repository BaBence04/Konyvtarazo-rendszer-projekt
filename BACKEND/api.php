<?php
    require_once "databaseFunctions.php";
    require "elementCreators.php";

    session_start();
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

        }else if(isset($_POST['user_id'], $_POST['isbn_id']) && count($_POST)==2){
            echo AddReservationOrBooking($_POST['isbn_id'], $_POST['user_id']);


            //PASSWORD CHECK IS NOT FINAL IT IS NOT HASHING
        }else if(isset($_POST['uname'], $_POST['pw']) && count($_POST)==2){
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

        }else if(count($_POST)==3 && isset($_POST["user_id"], $_POST["book_id"], $_POST["action"]) && $_POST["action"] == "extend" ){
            $result = [];
            
            if(IsItExtendable($_POST["user_id"], $_POST["book_id"])){
                ExtendReturnDate($_POST["book_id"], $_POST["user_id"]);
                $result["message"] = "Sikeres hosszabbítás!";
            }else{
                $result["message"] = "Nem lehet hosszabítani! Feltehetőleg valaki előjegyezte a könyvet mióta megnyitotta az oldalt!";
            }

            echo json_encode($result);
        }else if(isset($_POST["action"]) && count($_POST) == 1 && $_POST["action"] == "isLoggedIn"){
            echo isset($_SESSION['user_id']) ? $_SESSION["user_id"] : "";

        }else if(isset($_SESSION["user_id"], $_POST["action"]) && $_POST["action"] == "logout"){
            unset($_SESSION["user_id"]);

        }else if(isset($_POST["username"])&& isset($_POST["passw"]) && count($_POST)==2){
            echo json_encode(LoginEmployee($_POST["username"], $_POST["passw"]));
        }
        else if(isset($_POST["type"]) && $_POST["type"] == "getUsers" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetUsers($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBooks" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(getBooks($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "deleteExpiredBookings" && count($_POST) == 1){
            echo json_encode(deleteLateBookings());
        }else if(isset($_POST['test']) && $_POST['test'] == "ping"){
            echo "pong";
        }else{
            throw new Exception("Nincs ilyen");
        }
    }

    session_commit();


?>
<?php
    require_once "databaseFunctions.php";
    require "elementCreators.php";

    session_start();
    //listBooksFiltered

    if($_SERVER['REQUEST_METHOD'] === 'GET'){
        if(isset($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["ISBN"]) && (count($_GET)==6 || (count($_GET) == 7 && isset($_GET["page_number"])))){
            $page_number = 1;
            if(isset($_GET["page_number"])){
                $page_number = $_GET["page_number"];
            }

            print_r(create_listed_books_elements($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["ISBN"], $page_number));
    
        }

    }else if($_SERVER['REQUEST_METHOD'] === "POST"){
        if(isset($_POST['isbn_id'], $_SESSION["user_id"]) && count($_POST)==1){
            echo AddReservationOrBooking($_POST['isbn_id'], $_SESSION["user_id"]);


        //returns "not found"/"inactive"/"success"/"incorrect"
        }else if(isset($_POST['uname'], $_POST['pw']) && count($_POST)==2){
            // $result = CheckCredentialForLogin($_POST['uname'], $_POST['pw']);
            
            $gotPw = CheckCredentialForLogin($_POST['uname'], $_POST['pw']);
            //var_dump(CheckCredentialForLogin($_POST['uname'], $_POST['pw']));
            if($gotPw["result"] == "not found"){
                echo $gotPw["result"];
            }else{
                if($gotPw["result"] == NULL){
                    echo "inactive user";
                }else if($gotPw["result"] == "false"){
                    echo "incorrect";
                }else{
                    var_dump($gotPw);
                    $_SESSION['user_id'] = $gotPw['result'];
                    //there is no member key
                    if($gotPw['member'] == "false"){
                        $_SESSION['inactive'] = "true";
                    }
                    echo "success";
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

        }else if(isset($_POST["action"], $_POST["id"], $_SESSION["user_id"]) && ($_POST["action"] == "cancelReservation" || $_POST["action"] == "cancelBooking") && count($_POST) == 2){
            if($_POST["action"] == "cancelReservation"){
                cancel_reservation($_POST["id"], $_SESSION["user_id"]);
            }else{
                cancel_booking($_POST["id"], $_SESSION["user_id"]);
            }
        
        }else if(isset($_POST['test']) && $_POST['test'] == "ping"){
            echo "pong";
        }else{
            throw new Exception("Nincs ilyen");
        }
    }

    session_commit();


?>
<?php
    require_once "databaseFunctions.php";
    require_once "elementCreators.php";
    require_once "additionalFunctions.php";

    session_set_cookie_params([
        'lifetime' => 0, // Expire when browser closes
        'path' => '/',
        'domain' => '',
        'httponly' => true, // Prevent JS access
        'samesite' => 'Strict' // Prevent CSRF
      ]);
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
        if(isset($_POST['isbn_id'], $_SESSION["user_id"], $_SESSION["restricted"]) && count($_POST)==1 && $_SESSION["restricted"] == "false"){
            echo AddReservationOrBooking($_POST['isbn_id'], $_SESSION["user_id"]);


        //returns "not found"/"inactive"/"success"/"incorrect"/"inactive user"
        }else if(isset($_POST['uname'], $_POST['pw'], $_POST["remember_me"]) && count($_POST)==3){
            // $result = CheckCredentialForLogin($_POST['uname'], $_POST['pw']);
            $result = CheckCredentialForLogin($_POST['uname'], $_POST['pw']);
            //var_dump(CheckCredentialForLogin($_POST['uname'], $_POST['pw']));
            if($result["result"] == "not found"){
                echo $result["result"];
            }else{
                if($result["result"] == NULL){
                    echo "inactive user";
                }else if($result["result"] == "false"){
                    echo "incorrect";
                }else{
                     // Regenerate session ID for security
                    session_regenerate_id(true);

                    // var_dump($gotPw);
                    $_SESSION['user_id'] = $result["user_id"];
                    
                    //if restricted isset, and true than the current users membership is due
                    $_SESSION["restricted"] = $result["member"];
                    
                    //remember me is needed
                    if($_POST["remember_me"] == "true"){
                        $_SESSION["remember_me"] = true;
                        echo "here";

                        do{
                            $token = generate_token(1);
                        }while(create_token($token, $_SESSION["user_id"], "remember_me")["result"] == "false");
                        
                        $expires = time() + (30 * 24 * 60 * 60); // 30 days from now
                        // Set a long-lived cookie
                        setcookie('remember_me', $token, $expires, '/', '', true, true); // Secure and HTTP-only
                        
                    }
                    
                    echo "success";
                }
            }

        }else if(count($_POST)==2 && isset($_SESSION["user_id"], $_SESSION["restricted"], $_POST["book_id"], $_POST["action"]) && $_POST["action"] == "extend" && $_SESSION["restricted"] == "false" ){
            $result = [];
            
            if(IsItExtendable($_SESSION["user_id"], $_POST["book_id"])){
                ExtendReturnDate($_POST["book_id"], $_SESSION["user_id"]);
                $result["message"] = "Sikeres hosszabbítás!";
            }else{
                $result["message"] = "Nem lehet hosszabítani! Feltehetőleg valaki előjegyezte a könyvet mióta megnyitotta az oldalt!";
            }

            echo json_encode($result);
        }else if(isset($_POST["action"]) && count($_POST) == 1 && $_POST["action"] == "isLoggedIn"){
            echo isset($_SESSION['user_id']) ? $_SESSION["user_id"] : "";


        //logout
        }else if(isset($_SESSION["user_id"], $_POST["action"]) && $_POST["action"] == "logout"){
            unset($_SESSION['user_id']);
            session_destroy();

            // Delete the "remember me" cookie
            if (isset($_COOKIE['remember_me'])) {
                $token = $_COOKIE['remember_me'];
                
               delete_token($token);

                // Delete the cookie
                setcookie('remember_me', '', time() - 3600, '/');
            }

        //ask for link to reset pasword
        }else if(isset($_POST["username"], $_POST["action"]) && $_POST["action"] == "resetPassword" && count($_POST)==2){
            $user_id = GetUserId($_POST["username"]);
            if($user_id == -1){
                $response = ["status"=>"invalid"];
            }else{
                do{
                    $token = generate_token(1);
                }while(create_token($token, $user_id, "reset")["result"] == "false");
                $response = ["link"=>"localhost:8000/web/resetPassword.php?reset_token=$token", "status"=>"success"];
            }

            echo json_encode($response);
        
        //reset password
        }else if(isset($_POST["reset_token"], $_POST["password"]) && count($_POST)==2){
            
            $token_data = create_token($_POST["reset_token"],-1, "reset");
            if($token_data["result"] == "resetPossible"){
                if(change_password($_POST["password"], $token_data["user_id"])){
                    $response = ["status" => "success"];
                    delete_token($_POST["reset_token"]);
                }else{
                    $response = ["status" => "failed"];
                }

            }else{
                $response = ["status"=>"expired"];
            }
            

            echo json_encode($response);
        

        }else if(isset($_POST["username"], $_POST["passw"]) && count($_POST)==2){
            echo json_encode(LoginEmployee($_POST["username"], $_POST["passw"]));
        }
        else if(isset($_POST["type"]) && $_POST["type"] == "getUsers" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetUsers($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBooks" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(getBooks($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "autoDeleteBookingsAndReservations" && count($_POST) == 1){
            echo json_encode(AutoDeleteLateBookings());
        }else if(isset($_POST["type"]) && $_POST["type"] == "returnInfo" && isset($_POST["bookID"]) && count($_POST) == 2){
            echo json_encode(ReturnInfo($_POST["bookID"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "borrowInfo" && isset($_POST["id"]) && isset($_POST["state"]) && count($_POST) == 3){
            echo json_encode(BorrowInfo($_POST["id"], $_POST["state"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "returnBook" && isset($_POST["bookID"]) && isset($_POST["user_id"]) && isset($_POST["empl_id"]) && count($_POST) == 4){
            echo json_encode(ReturnBook($_POST["user_id"], $_POST["bookID"], $_POST["empl_id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "borrowBook" && isset($_POST["bookID"]) && isset($_POST["user_id"]) && isset($_POST["empl_id"]) && count($_POST) == 4){
            echo json_encode(BorrowBook($_POST["user_id"], $_POST["bookID"], $_POST["empl_id"]));
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
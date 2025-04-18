<?php
    require_once "databaseFunctions.php";
    require_once "elementCreators.php";
    require_once "additionalFunctions.php";
    require_once "mailer.php";

    setup_session_cookie();
    session_start();

    CheckForLastActivity();


    if($_SERVER['REQUEST_METHOD'] === 'GET'){
        //listBooksFiltered
        if(isset($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["ISBN"]) && (count($_GET)==6 || (count($_GET) == 7 && isset($_GET["page_number"])))){
            $page_number = 1;
            if(isset($_GET["page_number"])){
                $page_number = $_GET["page_number"];
            }

            print_r(create_listed_books_elements($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["ISBN"], $page_number));
    
        }

    }else if($_SERVER['REQUEST_METHOD'] === "POST"){
        if(isset($_POST['isbn_id'], $_SESSION["user_id"], $_SESSION["restricted"]) && count($_POST)==1 && $_SESSION["restricted"] == "false"){
            echo AddReservationOrBooking($_POST['isbn_id'], $_SESSION["user_id"])[0]["status"];


        //returns "not found"/"inactive"/"success"/"incorrect"/"inactive user", login
        }else if(isset($_POST['uname'], $_POST['pw'], $_POST["remember_me"]) && count($_POST)==3){
            $result = CheckCredentialForLogin($_POST['uname'], $_POST['pw']);
            if($result["result"] == "not found"){
                echo $result["result"];
            }else if($result["result"] == NULL){
                echo "inactive user";
            }else if($result["result"] == "false"){
                echo "incorrect";
            }else if($result["result"] == "not registered"){
                echo "not registered";

            }else if($result["result"]== "true"){
                    // Regenerate session ID for security
                session_regenerate_id(true);

                // var_dump($gotPw);
                $_SESSION['user_id'] = $result["user_id"];
                $_SESSION['username'] = $result["username"];
                
                //if restricted isset, and true than the current users membership is due
                $_SESSION["restricted"] = $result["member"]=="false"?"true":"false";
                
                //remember me is needed
                if($_POST["remember_me"] == "true"){
                    $_SESSION["remember_me"] = true;

                    do{
                        $token = generate_token(1);
                    }while(create_token($token, $_SESSION["user_id"], "remember_me")["result"] == "false");
                    
                    $expires = time() + (30 * 24 * 60 * 60); // 30 days from now
                    // Set a long-lived cookie
                    setcookie('remember_me', $token, $expires, '/', '', true, true); // Secure and HTTP-only
                    
                }
                
                echo "success";
            }
            
        //change password from userDetailed page
        }else if(isset($_POST["currentPassword"], $_POST["newPassword"], $_SESSION["user_id"], $_SESSION["username"]) && count($_POST) == 2){
            //authenticates the given current password
            $login_result = CheckCredentialForLogin($_SESSION["username"], $_POST["currentPassword"]);

            if($login_result["result"] == "true"){
                
                if(change_password($_POST["newPassword"], $_SESSION["user_id"])){
                    $result = ["status" => "successful"];        
                    
                }else{
                    $result = ["status" => "error", "message"=>"Couldn't log in with the new password, seek help!"];        
                }

            }else{
                $result = ["status" => $login_result["result"]];
            }

            echo json_encode($result);
            
        //kivett könyv meghosszabbítása
        }else if(count($_POST)==2 && isset($_SESSION["user_id"], $_SESSION["restricted"], $_POST["book_id"], $_POST["action"]) && $_POST["action"] == "extend" && $_SESSION["restricted"] == "false" ){
            $result = [];
            
            if(IsItExtendable($_SESSION["user_id"], $_POST["book_id"])){
                ExtendReturnDate($_POST["book_id"], $_SESSION["user_id"]);
                $result["message"] = "Sikeres hosszabbítás!";
            }else{
                $result["message"] = "Nem lehet hosszabítani! Feltehetőleg valaki előjegyezte a könyvet mióta megnyitotta az oldalt!";
            }

            echo json_encode($result);

        //is user logged in
        }else if(isset($_POST["action"]) && count($_POST) == 1 && $_POST["action"] == "isLoggedIn"){
            echo isset($_SESSION['user_id']) ? $_SESSION["user_id"] : "";


        //logout
        }else if(isset($_SESSION["user_id"], $_POST["action"]) && $_POST["action"] == "logout"){
            unset($_SESSION['user_id']);
            unset($_SESSION['username']);
            unset($_SESSION['restricted']);
            unset($_SESSION["last_activity"]);
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
                $response = reset_password($user_id);
            }

            echo json_encode($response);

            //remove book from the favorites
        }else if(isset($_POST["ISBN_id"], $_POST["action"], $_SESSION["user_id"]) && count($_POST) == 2 && $_POST["action"] == "removeFromFavorites"){
            remove_books_from_users_favorites($_SESSION["user_id"], $_POST["ISBN_id"]);

            //add book to the favorites
        }else if(isset($_POST["ISBN_id"], $_POST["action"], $_SESSION["user_id"]) && count($_POST) == 2 && $_POST["action"] == "addToFavorites"){
            add_books_to_users_favorites($_SESSION["user_id"], $_POST["ISBN_id"]);

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
        
            //login employee
        }else if(isset($_POST["username"], $_POST["passw"]) && count($_POST)==2){
            echo json_encode(LoginEmployee($_POST["username"], $_POST["passw"]));
        }
        else if(isset($_POST["type"]) && $_POST["type"] == "getUsers" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetUsers($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getEmployees"  && count($_POST) == 1){
            echo json_encode(GetEmployees());
        }else if(isset($_POST["type"]) && $_POST["type"] == "getEmployee" && isset($_POST["empl_id"]) && count($_POST) == 2){
            echo json_encode(GetEmployee($_POST["empl_id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBooks" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetBooks($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getReservations" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetReservations($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getReservables" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetReservables($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBookings" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetBookings($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBorrowings" && isset($_POST["search"], $_POST["returned"]) && count($_POST) == 3){
            echo json_encode(GetBorrowings($_POST["search"], $_POST["returned"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBorrowedBooks" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetBorrowedBooks($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getPublishers" && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetPublishers($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getUserDetailed" && isset($_POST["id"]) && count($_POST) == 2){
            echo json_encode(GetUser($_POST["id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBookDetailed" && isset($_POST["ISBN"]) && count($_POST) == 2){
            echo json_encode(GetBookByIsbn($_POST["ISBN"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "updatePublishers" && isset($_POST["id"], $_POST["name"], $_POST["phone"], $_POST["email"], $_POST["webpage"]) && count($_POST) == 6){
            UpdatePublishers($_POST["id"], $_POST["name"], $_POST["phone"], $_POST["email"], $_POST["webpage"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "updateUser" && isset($_POST["id"], $_POST["firstname"], $_POST["surname"], $_POST["birthplace"], $_POST["birthdate"], $_POST["address"], $_POST["email"], $_POST["phone"], $_POST["mmn"]) && count($_POST) == 10){
            UpdateUser($_POST["id"], $_POST["firstname"], $_POST["surname"], $_POST["birthplace"], $_POST["birthdate"], $_POST["address"], $_POST["email"], $_POST["phone"], $_POST["mmn"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "updateBook" && isset($_POST["id"], $_POST["title"], $_POST["release_date"], $_POST["lang"], $_POST["publisher"], $_POST["authors"], $_POST["genres"], $_POST["description"], $_POST["picture_base64"]) && count($_POST) == 10){
            echo json_encode(UpdateBook($_POST["id"], $_POST["title"], $_POST["release_date"], $_POST["lang"], $_POST["publisher"], $_POST["authors"], $_POST["genres"], $_POST["description"], $_POST["picture_base64"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "updateSystemSettings" && isset($_POST["membership_fee"], $_POST["borrowing_time"], $_POST["lengthening_time"], $_POST["booking_time"], $_POST["max_reservations"], $_POST["max_lengthenings"], $_POST["latency_fee"], $_POST["reset_token_expiration"], $_POST["login_token_expiration"]) && count($_POST) == 10){
            echo UpdateSystemSettings($_POST["membership_fee"], $_POST["borrowing_time"], $_POST["lengthening_time"], $_POST["booking_time"], $_POST["max_reservations"], $_POST["max_lengthenings"], $_POST["latency_fee"], $_POST["reset_token_expiration"], $_POST["login_token_expiration"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "deletePublisher" && isset($_POST["id"]) && count($_POST) == 2){
            echo json_encode(DeletePublisher($_POST["id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "addPublisher" && isset($_POST["name"], $_POST["phone"], $_POST["email"], $_POST["webpage"])  && count($_POST) == 5){
            echo json_encode(addPublisher($_POST["name"], $_POST["phone"], $_POST["email"], $_POST["webpage"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "addUser" && isset($_POST["surname"], $_POST["first_name"], $_POST["uname"], $_POST["birthdate"], $_POST["email"], $_POST["phone"], $_POST["birthplace"], $_POST["address"], $_POST["mmn"])  && count($_POST) == 10){
            $result = addUser($_POST["surname"], $_POST["first_name"], $_POST["uname"], $_POST["birthdate"], $_POST["email"], $_POST["phone"], $_POST["birthplace"], $_POST["address"], $_POST["mmn"]);
            echo json_encode($result);
            if($result[0]["state"] == "Sikeres"){
                reset_password(GetUserId($_POST["uname"]));
            }
        }else if(isset($_POST["type"]) && $_POST["type"] == "addBookType" && isset($_POST["isbn"], $_POST["title"], $_POST["allGenres"], $_POST["allAuthors"], $_POST["publisher"], $_POST["release_date"], $_POST["lang"], $_POST["descript"], $_POST["picture"])  && count($_POST) == 10){
            echo json_encode( AddBookType($_POST["isbn"], $_POST["title"], $_POST["allGenres"], $_POST["allAuthors"], $_POST["publisher"], $_POST["release_date"], $_POST["lang"], $_POST["descript"], $_POST["picture"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "deleteExpiredReservations" && count($_POST) == 1){
            echo json_encode(AutoDeleteLateBookings());
        }else if(isset($_POST["type"]) && $_POST["type"] == "deleteExpiredBookings" && count($_POST) == 1){
            echo json_encode(AutoDeleteLateReservations());
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
        }else if(isset($_POST["type"]) && $_POST["type"] == "getSystemSettings" && count($_POST) == 1){
            echo json_encode(GetSystemSettings());
        }else if(isset($_POST["type"]) && $_POST["type"] == "renewMembership"  && isset($_POST["id"]) && count($_POST) == 2){
            echo json_encode(RenewMembership($_POST["id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "deactivateUser"  && isset($_POST["id"]) && count($_POST) == 2){
            DeactivateUser($_POST["id"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "deactivateEmpl"  && isset($_POST["empl_id"]) && count($_POST) == 2){
            DeactivateEmpl($_POST["empl_id"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "deactivateBook"  && isset($_POST["book_id"]) && count($_POST) == 2){
            DeactivateBook($_POST["book_id"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "checkPermissions"  && isset($_POST["id"]) && count($_POST) == 2){
            echo json_encode(CheckPermissions($_POST["id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getBookStates"  && isset($_POST["search"]) && count($_POST) == 2){
            echo json_encode(GetBookStates($_POST["search"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "addReservationOrBooking"  && isset($_POST["ISBN"], $_POST["userid"]) && count($_POST) == 3){
            echo json_encode(AddReservationOrBooking($_POST["ISBN"], $_POST["userid"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getUsernames"  && isset($_POST["name"]) && count($_POST) == 2){
            echo json_encode(GetUsernames($_POST["name"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getEmplUsernames"  && isset($_POST["name"]) && count($_POST) == 2){
            echo json_encode(GetEmplUsernames($_POST["name"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getHistory"  && isset($_POST["book_id"], $_POST["user_id"]) && count($_POST) == 3){
            echo json_encode(GetHistory($_POST["book_id"], $_POST["user_id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "changeEmplPass"  && isset($_POST["empl_id"], $_POST["oldPass"], $_POST["newPass"]) && count($_POST) == 4){
            echo json_encode(ChangeEmplPass($_POST["empl_id"], $_POST["oldPass"], $_POST["newPass"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "addEmployee"  && isset($_POST["empl_name"], $_POST["empl_uname"], $_POST["pw"]) && count($_POST) == 4){
            echo AddEmployee($_POST["empl_name"], $_POST["empl_uname"], $_POST["pw"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "getAuthors"  && isset($_POST["ISBN_id"], $_POST["inverse"]) && count($_POST) == 3){
            echo json_encode(GetAuthors($_POST["ISBN_id"], $_POST["inverse"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getCategories"  && isset($_POST["ISBN_id"], $_POST["inverse"]) && count($_POST) == 3){
            echo json_encode(GetCategories($_POST["ISBN_id"], $_POST["inverse"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "getLangs" && count($_POST) == 1){
            echo json_encode(GetLangs());
        }else if(isset($_POST["type"]) && $_POST["type"] == "addToInventory" && isset($_POST["ISBN_id"]) && count($_POST) == 2){
            echo json_encode(AddToInventory($_POST["ISBN_id"]));
        }else if(isset($_POST["type"]) && $_POST["type"] == "checkForBookings" && count($_POST) == 1){
            echo json_encode(CheckForBookings());
        }else if(isset($_POST["type"]) && $_POST["type"] == "changeHandled" && isset($_POST["id"]) && count($_POST) == 2){
            ChangeHandled($_POST["id"]);
        }else if(isset($_POST["type"]) && $_POST["type"] == "removeBooking" && isset($_POST["id"]) && count($_POST) == 2){
            RemoveBooking($_POST["id"]);
        }else{
            //echo var_dump($_POST);
            throw new Exception("Nincs ilyen");
        }
    }

    session_commit();


?>

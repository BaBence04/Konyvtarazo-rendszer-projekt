<?php
    // require "sql.php";

    $results_per_page = 8;
    function get_books_filtered($title, $genre, $author, $release_date, $lang, $isbn, $page){
        require "databaseConnect.php";

        global $results_per_page;

        $offset = ($page-1) * $results_per_page;
        $limit = $results_per_page;
        

        $query = "CALL listBooksFiltered(?,?,?,?,?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssssssii", $title, $genre, $author, $release_date, $lang, $isbn, $offset ,$limit); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();


        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function get_books_filtered_number_of_results($title, $genre, $author, $release_date, $lang, $isbn):int{
        require "databaseConnect.php";

        $offset = 0;
        $limit = -1; //it is -1 so it will return all of the results

        
        $query = "CALL listBooksFiltered(?,?,?,?,?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssssssii", $title, $genre, $author, $release_date, $lang, $isbn, $offset ,$limit); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();

        $number_of_results = $results->num_rows;
        return $number_of_results;
    }

    

    function GetGenres(){
        require "databaseConnect.php";

        $query = "CALL getGenres();";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetLangs(){
        require "databaseConnect.php";

        $query = "CALL getLangs();";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetBookByIsbnId($id){
        require "databaseConnect.php";

        $query = "CALL GetBookById(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        $data = $results->fetch_all(MYSQLI_ASSOC);

        if(count($data)>1){
            throw new Exception("HIBA! több mint egy könyv van ugyanazzal az ISBN idval az adatbázisban!");
        }elseif(count($data)==0){
            return [];
        }elseif(count($data)==1){
            return $data[0];

        }

    }

    function GetBookByIsbn($isbn){
        require "databaseConnect.php";

        $query = "CALL getBookByISBN(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $isbn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        $data = $results->fetch_all(MYSQLI_ASSOC);
        return $data;
        if(count($data)>1){
            throw new Exception("HIBA! több mint egy könyv van ugyanazzal az ISBN-el az adatbázisban!");
        }elseif(count($data)==0){
            return [];
        }elseif(count($data)==1){
            return $data;
        }

    }

    function GetBookedAndReservedBooks($user_id){
        require "databaseConnect.php";

        $query = "CALL getBookedAndReservedBooks(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetBorrowedBooks($user_id){
        require "databaseConnect.php";

        $query = "CALL getBorrowedBooks(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetPreviouslyBorrowedBooks($user_id){
        require "databaseConnect.php";

        $query = "CALL getPreviouslyBorrowedBooks(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);

    }
    
    function CheckBookAvailability($isbn_id, $user_id) : array {
        //returns "reservation" | "booking"
        require "databaseConnect.php";

        $query = "CALL checkAvailability(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $isbn_id,$user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC)[0];
        //we may wanto do something with it though not only return "reservation" or "booking"
    }

    function GetIsbnIdByIsbn($isbn){
        require "databaseConnect.php";

        $query = "CALL getIdFromISBN(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $isbn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        if($results->num_rows>1){
            throw new Exception(("A következő ISBN-hez többször van az adatbázisban ISBN: $isbn."));
        }elseif($results->num_rows==0){
            return -1;
        }else{
            return $results->fetch_all(MYSQLI_ASSOC)[0]["ISBN_id"];
        }
    }

    function AddReservationOrBooking($isbn_id, $user_id){
        require "databaseConnect.php";

        $query = "CALL addReservationOrBooking(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $isbn_id,$user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }
    
    //returns "not found" if there is no user with the given username, returns "false" if the password doesn't match, and returns true for successful logging in
    function CheckCredentialForLogin($username, $pw) {
        require "databaseConnect.php";

        $query = "CALL loginUser(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ss", $username, $pw); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC)[0];
    }

    //not tested hopefully works
    function AutoDeleteLateBookings() {
        require "databaseConnect.php";

        $query = "CALL deleteLateBookings();";

        $stmt = $conn->prepare($query); // Prepare statement
        //$stmt->bind_param("ss", $username, $pw); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }
    function AutoDeleteLateReservations() {
        require "databaseConnect.php";

        $query = "CALL deleteLateReservations();";

        $stmt = $conn->prepare($query); // Prepare statement
        //$stmt->bind_param("ss", $username, $pw); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetSystemSettings(){
        require "databaseConnect.php";

        $query = "CALL getSystemSettings();";

        $stmt = $conn->prepare($query); // Prepare statement
        //$stmt->bind_param("ss", $username, $pw); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }
    

    function GetUserId($username) : string {
        require "databaseConnect.php";

        $query = "CALL getUserId(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $username); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        $data = $results->fetch_all(MYSQLI_ASSOC); 
        if(count($data) == 1){
            return $data[0]['user_id'];
        }else if(count($data) >1){
            throw new Exception("There are more than one users with the same username!");
        }else{
            return -1;
        }
    }
    function GetUser($user_id, $conn=null){
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL getUser(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();

        if($conn_was_not_given){
            $conn->close();
        }

        return $results->fetch_all(MYSQLI_ASSOC);


        /* $data = $results->fetch_all(MYSQLI_ASSOC);
        if(count($data) == 1){
            return $data;
        }else{
            throw new Exception("No user was found with the given id!");
        } */

    }
    
    function GetEmployee($empl_id){
        require "databaseConnect.php";

        $query = "CALL getEmployee(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $empl_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
   }

    function ExtendReturnDate($book_id, $user_id): void{
        require "databaseConnect.php";

        $query = "CALL extendReturnDate(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $book_id,$user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
    }

    //From here mainly desktop functions
    function GetAllBooks($searchTerm, $offseter, $limiter){
        require "databaseConnect.php";

        $query = "CALL getAllBooks(?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("sii", $searchTerm,$offseter, $limiter); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function AddBookType($isbn, $title, $allGenres, $allAuthors, $publisher, $releaseDate, $lang, $descript, $picture){
        require "databaseConnect.php";

        $query = "CALL addBookType(?,?,?,?,?,?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("sssssssss", $isbn,$title,$allGenres, $allAuthors, $publisher, $releaseDate, $lang, $descript, $picture); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
        
    }

    function AddBook($isbn){
        require "databaseConnect.php";

        $query = "CALL extendReturnDate(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $isbn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function LoginEmployee($username, $pw){
        require "databaseConnect.php";

        $query = "CALL loginEmployee(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ss", $username, $pw); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetUsers($search){
        require "databaseConnect.php";

        $query = "CALL getUsers(?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $search); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetEmployees(){
        require "databaseConnect.php";

        $query = "CALL getEmployees();";
        
        $stmt = $conn->prepare($query); // Prepare statement
        //$stmt->bind_param("s", $search); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetBooks($search){
        require "databaseConnect.php";

        $query = "CALL getBooks(?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $search); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetPublishers($search){
        require "databaseConnect.php";

        $query = "CALL getPublishers(?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $search); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }
    
    function UpdatePublishers($id, $name, $phone, $email, $webpage){
        require "databaseConnect.php";

        $query = "CALL updatePublishers(?,?,?,?,?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("issss", $id, $name, $phone, $email, $webpage); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL
        $results = $stmt->get_result();
        $conn->close();
        //return $results->fetch_all(MYSQLI_ASSOC);
    }

    function UpdateUser($id, $firstname, $surname, $birthplace, $birthdate, $address, $email, $phone, $mmn){
        require "databaseConnect.php";

        $query = "CALL updateUserDetails(?,?,?,?,?,?,?,?,?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("issssssss", $id, $surname, $firstname, $birthplace, $birthdate, $address, $email, $phone, $mmn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        //return $results->fetch_all(MYSQLI_ASSOC);
    }

    function UpdateBook($id, $title, $release_date, $lang, $publisher, $authors, $genres, $description, $picture_base64){
        require "databaseConnect.php";

        $query = "CALL updateBookDetails(?,?,?,?,?,?,?,?,?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("issssssss", $id, $title, $release_date, $lang, $publisher, $authors, $genres, $description, $picture_base64); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        //return $results->fetch_all(MYSQLI_ASSOC);
    }
    function UpdateSystemSettings($membership_fee, $borrowing_time, $lengthening_time, $reservation_time, $max_reservations, $max_lengthenings, $latency_fee, $reset_token_expiration, $login_token_expiration){
        require "databaseConnect.php";

        $query = "CALL updateSystemSettings(?,?,?,?,?,?,?,?,?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("iiiiiiiii", $membership_fee, $borrowing_time, $lengthening_time, $reservation_time, $max_reservations, $max_lengthenings, $latency_fee, $reset_token_expiration, $login_token_expiration); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        //return $results->fetch_all(MYSQLI_ASSOC);
    }
    
    function DeletePublisher($id){
        require "databaseConnect.php";

        $query = "CALL deletePublisher(?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function BorrowInfo($id, $state){
        require "databaseConnect.php";

        $query = "CALL borrowInfo(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("is", $id, $state); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function BorrowBook($user_id, $book_id, $empl_id){
        require "databaseConnect.php";

        $query = "CALL borrowBook(?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("iii", $user_id, $book_id, $empl_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function ReturnInfo($book_id){
        require "databaseConnect.php";

        $query = "CALL returnInfo(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $book_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function ReturnBook($user_id, $book_id, $empl_id){
        require "databaseConnect.php";

        $query = "CALL returnBook(?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("iii", $user_id, $book_id, $empl_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function AddPublisher($pubname, $phone, $email, $webpage){
        require "databaseConnect.php";

        $query = "CALL addPublisher(?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssss", $pubname, $phone, $email, $webpage); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function AddUser($surname, $firstname, $uname, $birthdate, $email, $phone, $birthplace, $address, $mmn){
        require "databaseConnect.php";

        $query = "CALL addUser(?,?,?,?,?,?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("sssssssss", $surname, $firstname, $uname, $birthdate, $email, $phone,  $birthplace, $address, $mmn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    

    function AddEmployee($name, $uname, $pw){
        require "databaseConnect.php";

        $query = "CALL addEmployee(?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("sss", $name, $uname, $pw); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();

    }

    function RenewMembership($user_id){
        require "databaseConnect.php";

        $query = "CALL renewMembership(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);

    }
    
    function DeactivateUser($user_id){
        require "databaseConnect.php";

        $query = "CALL deactivateUser(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        //return $results->fetch_all(MYSQLI_ASSOC);
    }

    function DeactivateEmpl($empl_id){
        require "databaseConnect.php";

        $query = "CALL deactivateEmpl(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $empl_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        //return $results->fetch_all(MYSQLI_ASSOC);
    }

    function CheckPermissions($user_id){
        require "databaseConnect.php";

        $query = "CALL checkPermissions(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetBookStates($search){
        require "databaseConnect.php";

        $query = "CALL getBookStates(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $search); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetUsernames($name){
        require "databaseConnect.php";

        $query = "CALL getUsernames(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $name); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetEmplUsernames($name){
        require "databaseConnect.php";

        $query = "CALL getEmplUsernames(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $name); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetHistory($book_id, $user_id){
        require "databaseConnect.php";

        $query = "CALL getHistory(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $book_id, $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function ChangeEmplPass($empl_id, $oldPass, $newPass){
        require "databaseConnect.php";

        $query = "CALL changeEmplPass(?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("iss", $empl_id, $oldPass, $newPass); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetAuthors($ISBN_id, $inverse){
        require "databaseConnect.php";

        $query = "CALL getAuthors(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $ISBN_id, $inverse); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetCategories($ISBN_id, $inverse){
        require "databaseConnect.php";

        $query = "CALL getCategories(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $ISBN_id, $inverse); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }
    
    function DeactivateBook($book_id){
        require "databaseConnect.php";

        $query = "CALL deactivateBook(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $book_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        //return $results->fetch_all(MYSQLI_ASSOC);
    }

    function AddToInventory($ISBN_id){
        require "databaseConnect.php";

        $query = "CALL addToInventory(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $ISBN_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetReservations($searchTerm){
        require "databaseConnect.php";

        $query = "CALL getReservations(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $searchTerm); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }
    
    function GetBookings($searchTerm){
        require "databaseConnect.php";

        $query = "CALL getBookings(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $searchTerm); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetBorrowings($searchTerm){
        require "databaseConnect.php";

        $query = "CALL getBorrowings(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $searchTerm); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_all(MYSQLI_ASSOC);
    }
    /**
     * Return true or false depending if the end date of borrowing the given book is extendable.
     *
     * @param int $user_id The id of the user who want to extend the book
     * @param int $book_id The id of the book which would be extended
     * @return bool Return true or false depending if the end date of borrowing the given book is extendable.
     */
    function IsItExtendable($user_id, $book_id): bool{    
        require "databaseConnect.php";

        $query = "CALL extendable(?, ?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $book_id, $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        $conn->close();
        return $results->fetch_row()[0] == "true";
    }

    function cancel_reservation($reservation_id, $user_id){
        require "databaseConnect.php";

        $query = "CALL cancelReservation(?, ?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $reservation_id, $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $conn->close();
        return $results->fetch_row()[0];
    }

    function cancel_booking($booking_id, $user_id){
        require "databaseConnect.php";

        $query = "CALL cancelBooking(?, ?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $booking_id, $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $conn->close();
        return $results->fetch_row()[0];
    }

    function create_token($token, $user_id, $type, $conn=null) : array {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL generateToken(?, ?, ?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("iss", $user_id, $token, $type); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        if($conn_was_not_given){
            $conn->close();
        }

        $data = $results->fetch_all(MYSQLI_ASSOC);
        if(count($data) == 1){
            return $data[0];
        }else{
            throw new Exception("The data returned by generateToken was not 1 record long!! It was ".count($data));

        }
    }

    function delete_token($token, $conn=null) : void {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL deleteToken(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $token); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        if($conn_was_not_given){
            $conn->close();
        }
    }

    function change_password(string $password, int $user_id, mysqli $conn=null) : bool {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL changePassword(?, ?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("si", $password, $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query

        $user_data = GetUser($user_id, $conn)[0];
        $login_result = CheckCredentialForLogin($user_data["username"], $password);

        if($conn_was_not_given){
            $conn->close();
        }

        return $login_result["result"] == "true";
    }

    function get_user_email_data($user_id, $conn=null) : array {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL getEmailData(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        if($conn_was_not_given){
            $conn->close();
        }

        return $results->fetch_all(MYSQLI_ASSOC)[0];
    }

    function get_books_from_users_shelf(int $user_id, mysqli $conn=null) : array {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL getBooksFromShelf(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();

        if($conn_was_not_given){
            $conn->close();
        }

        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function add_books_to_users_shelf(int $user_id, int $ISBN_id, mysqli $conn=null) : void {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL addBooksToShelf(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $user_id, $ISBN_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query

        if($conn_was_not_given){
            $conn->close();
        }

        return;
    }

    function remove_books_from_users_shelf(int $user_id, int $ISBN_id, mysqli $conn=null) : void {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL removeBooksFromShelf(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $user_id, $ISBN_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query

        if($conn_was_not_given){
            $conn->close();
        }

        return;
    }

    function is_book_on_shelf(int $user_id, int $ISBN_id, mysqli $conn=null) : bool {
        $conn_was_not_given = $conn == null;

        if($conn_was_not_given){
            require "databaseConnect.php";
        }

        $query = "CALL isItOnShelf(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $user_id, $ISBN_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();

        if($conn_was_not_given){
            $conn->close();
        }

        return $results->fetch_assoc()["result"] == "true";
    }

?>

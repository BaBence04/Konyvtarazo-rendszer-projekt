<?php
    require "sql.php";

    function GetBooksFiltered($title, $genre, $author, $release_date, $lang, $isbn){
        require "databaseConnect.php";

        //temporary fix page offset and limit not dealt with yet
        $query = "CALL listBooksFiltered(?,?,?,?,?,?,0,10);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssssss", $title, $genre, $author, $release_date, $lang, $isbn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetGenres(){
        require "databaseConnect.php";

        $query = "CALL getGenres();";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetLangs(){
        require "databaseConnect.php";

        $query = "CALL getLangs();";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetBookByIsbnId($id){
        require "databaseConnect.php";

        $query = "CALL GetBookById(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
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
        $data = $results->fetch_all(MYSQLI_ASSOC);

        if(count($data)>1){
            throw new Exception("HIBA! több mint egy könyv van ugyanazzal az ISBN-el az adatbázisban!");
        }elseif(count($data)==0){
            return [];
        }elseif(count($data)==1){
            return $data[0];

        }

    }

    function GetBookedAndReservedBooks($user_id){
        require "databaseConnect.php";

        $query = "CALL getBookedAndReservedBooks(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetBorrowedBooks($user_id){
        require "databaseConnect.php";

        $query = "CALL getBorrowedBooks(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);

    }

    function GetPreviouslyBorrowedBooks($user_id){
        require "databaseConnect.php";

        $query = "CALL getPreviouslyBorrowedBooks(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
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
        if($results->num_rows>1){
            throw new Exception(("A következő ISBN-hez többször van az adatbázisban ISBN: $isbn."));
        }elseif($results->num_rows==0){
            return -1;
        }else{
            return $results->fetch_all(MYSQLI_ASSOC)[0]["ISBN_id"];
        }

        
    
    }

    function AddReservationOrBooking($isbn_id, $user_id):string {
        require "databaseConnect.php";

        $query = "CALL addReservationOrBooking(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $isbn_id,$user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC)[0]['status'];
    }

    function GetPassword($username) : string {
        require "databaseConnect.php";

        $query = "CALL sendPassword(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $username); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC)[0]['result'];
    }
    function GetUserId($username) : string {
        require "databaseConnect.php";

        $query = "CALL getUserId(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $username); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC)[0]['user_id'];
    }
    function GetUser($user_id) : array {
        require "databaseConnect.php";

        $query = "CALL getUser(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("i", $user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC)[0];
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
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function AddBookType($isbn, $title, $allGenres, $allAuthors, $publisherId, $releaseDate, $lang, $descript, $picture){
        require "databaseConnect.php";

        $query = "CALL addBookType(?,?,?,?,?,?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssssissss", $isbn,$title,$allGenres, $allAuthors, $publisherId, $releaseDate, $lang, $descritp, $picture); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        if($results->fetch_all(MYSQLI_NUM)[0][0] == "Already exists"){
            return -1;
        }
        else{
            return $results->fetch_all(MYSQLI_ASSOC);
        }
    }

    function AddBook($isbn){
        require "databaseConnect.php";

        $query = "CALL extendReturnDate(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $isbn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
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
    function GetBooks($search){
        require "databaseConnect.php";

        $query = "CALL getBooks(?);";
        
        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $search); // Bind parameter to SQL query
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
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function AddPublisher($pubname, $phone, $email, $webpage){
        require "databaseConnect.php";

        $query = "CALL addPublisher(?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssss", $pubname, $phone, $email, $webpage); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        if($results->fetch_all(MYSQLI_NUM)[0][0] == "ilyen név már létezik"){
            return -1;
        }else{
            return $results->fetch_all(MYSQLI_ASSOC);
        }
    }

    function AddUser($surname, $firstname, $uname, $birthdate, $email, $phone, $pw, $birthplace, $address, $mmn){
        require "databaseConnect.php";

        $query = "CALL addUser(?,?,?,?,?,?,?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssssssssss", $surname, $firstname, $uname, $birthdate, $email, $phone, $pw, $birthplace, $address, $mmn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        if($results->fetch_all(MYSQLI_NUM)[0][0] == "a személy már egyszer beregisztrált"){
            return -1;
        }else{
            return $results->fetch_all(MYSQLI_ASSOC);
        }
    }

    function DeleteLateBookings(){
        require "databaseConnect.php";

        $query = "CALL deleteLateBookings();";

        $stmt = $conn->prepare($query); // Prepare statement
        //$stmt->bind_param("ssssssssss", $surname, $firstname, $uname, $birthdate, $email, $phone, $pw, $birthplace, $address, $mmn); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function AddEmployee($uname, $pw){
        require "databaseConnect.php";

        $query = "CALL addEmployee(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ss", $uname, $pw); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        if($results->fetch_all(MYSQLI_NUM)[0][0] == "az alkalmazott már egyszer beregisztrált"){
            return -1;
        }else{
            return $results->fetch_all(MYSQLI_ASSOC);
        }

    }

    function RenewMembership($uname){
        require "databaseConnect.php";

        $query = "CALL renewMembership(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $uname); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);

    }
    /**
     * Return true or false depending if the end date of borrowing the given book is extendable.
     *
     * @param int $user_id The id of the user who want to extend the book
     * @param int $book_id The id of the book which would be extended
     * @return bool Return true or false depending if the end date of borrowing the given book is extendable.
     */
    function IsItExtendable($user_id, $book_id){
        require "databaseConnect.php";

        $query = "CALL extendable(?, ?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $user_id, $book_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_row()[0] == "true";
    }

?>
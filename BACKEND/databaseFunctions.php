<?php
    require "sql.php";

    function GetBooksFiltered($title, $genre, $author, $release_date, $lang, $isbn){
        require "databaseConnect.php";

        $query = "CALL listBooksFiltered(?,?,?,?,?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ssssss", $title, $genre, $author, $release_date, $lang, $isbn); // Bind parameter to SQL query
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


    function CheckBookAvailability($isbn_id, $user_id) : string {
        //returns "reservation" | "booking"
        require "databaseConnect.php";

        $query = "CALL checkAvailabilits(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $isbn_id,$user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
        //we may wanto do something with it though not only return "reservation" or "booking"
    }

    function AddReservationOrBooking($isbn_id, $user_id) : string {
        require "databaseConnect.php";

        $query = "CALL addReservationOrBooking(?,?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("ii", $isbn_id,$user_id); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }

    function GetPassword($username) : array {
        require "databaseConnect.php";

        $query = "CALL sendPassword(?);";

        $stmt = $conn->prepare($query); // Prepare statement
        $stmt->bind_param("s", $username); // Bind parameter to SQL query
        $stmt->execute(); // Execute the SQL query
        $results = $stmt->get_result();
        return $results->fetch_all(MYSQLI_ASSOC);
    }


?>
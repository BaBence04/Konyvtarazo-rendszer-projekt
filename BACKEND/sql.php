<?php
    
    
    function sql_query($query,  $mode){
         //connects to the database
         do{
            $conn  = mysqli_connect("localhost", "root", "", "szabvanyok");
        }while(mysqli_connect_errno());

        
        //runs the query
        if ($result = $conn -> query($query)) {
        }else{
            return false;
        }
    
        mysqli_close($conn);
        
        //fetches (if necessary) the data and returns it in the requested format
        //Modes: assoc<-asszociatív array, numeric<-indexed array, row<-returns the number of rows, none<-returns true if there were no errors       
        GetRequestedDataTypeFromConnection($mode,$result);
    
    }

    function GetRequestedDataTypeFromConnection($mode,$result){
        switch($mode){
            case "assoc":
                return $result->fetch_all(MYSQLI_ASSOC);
            case "numeric";
                return $result->fetch_all(MYSQLI_NUM);
            case "row":
                return $result->num_rows;
            case "":
                return true;
            case "none":
                return true;
        }
    }

?>
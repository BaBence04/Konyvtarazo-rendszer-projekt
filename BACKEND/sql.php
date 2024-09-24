<?php
    
    
    function sql_query($query,  $mode){
        //CHANGE PORT IF NOT WORKING }while(mysqli_connect_errno());
        do{
            $conn = mysqli_connect("localhost", "root", "", "konyvtar", 84);
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

    function makeDb(){
        //CHANGE PORT IF NOT WORKING
        $dbMaker = fopen("dbMaker.txt", "r") or die("Unable to open file");
        $makerComm = fread($dbMaker, filesize("dbMaker.txt"));
        fclose($dbMaker);
        do{
            $conn = mysqli_connect("localhost", "root", "", "");
            echo mysqli_connect_errno();
        }while(mysqli_connect_errno());

        if($result = $conn -> multi_query($makerComm)){
        }
        else{
            return false;
        }
        mysqli_close($conn);

        GetRequestedDataTypeFromConnection("", $result);
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
<?php
    function generate_token($number_to_put_to_end){
        $token = "";

        for ($i=0; $i < 10; $i++) { 
            $token .= rand(0,9);
        }

        return $token .= $number_to_put_to_end;
    }




?>
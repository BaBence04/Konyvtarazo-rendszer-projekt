<?php
    function generate_token($number_to_put_to_end){
        $token = "";

        for ($i=0; $i < 10; $i++) { 
            $token .= rand(0,9);
        }

        return $token .= $number_to_put_to_end;
    }

    function send_reset_email(){
    
        
    }

    function setup_session_cookie() : void {
        session_set_cookie_params([
            'lifetime' => 0, // Expire when browser closes
            'path' => '/',
            'domain' => '',
            'httponly' => true, // Prevent JS access
            'samesite' => 'Strict' // Prevent CSRF
        ]);
    }




?>
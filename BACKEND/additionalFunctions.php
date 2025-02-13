<?php
    require_once "mailer.php";

    function generate_token($number_to_put_to_end){
        $token = "";

        for ($i=0; $i < 10; $i++) { 
            $token .= rand(0,9);
        }

        return $token .= $number_to_put_to_end;
    }

    function reset_password($user_id, $conn=null): array{
        $link = create_reset_token_and_link($user_id);
        
        $user_email_data = get_user_email_data($user_id, $conn);

        $response = [];

        $email_status = send_reset_password_email($user_id, $link, $conn);

        if($email_status["status"] == "success"){
            $response["status"] = "success";

            $hidden_email = "";
            $email_split = explode("@" ,$user_email_data["email"]);

            for ($i=0; $i < strlen($email_split[0]); $i++) { 
                if($i<4){
                    $hidden_email .= $email_split[0][$i];
                }else{
                    $hidden_email .= "*";
                }
            }

            $response["email"] = $hidden_email . "@" .$email_split[1];

        }else{
            $response["status"] = "failed_to_send_email";
            $response["error"] = $email_status["error"];
        }

        return $response;

        
    }

    function send_reset_password_email($user_id, $reset_link, $conn = null): array{
        $user_email_data = get_user_email_data($user_id, $conn);
        
        $recipient_name = "$user_email_data[surname] $user_email_data[first_name]";
        $recipient_address = $user_email_data["email"];
        $subject = "Elfelejtett jelszó!";

        $email_html_body = "
            <div style='font-family: Arial, sans-serif; max-width: 600px; margin: 0 auto;'>
                <table style='width: 100%; background-color: #f9f9f9; border-collapse: collapse;'>
                    <tr>
                        <td style='padding: 20px; text-align: center; background-color: #007BFF; color: #FFFFFF;'>
                            <h1>Elfelejtett jelszó</h1>
                        </td>
                    </tr>
                    <tr>
                        <td style='padding: 20px;'>
                            <p>Kedves $recipient_name,</p>
                            <p>Úgy tűnik, hogy elfelejtetted a jelszavad. Ne aggódj, segítünk visszaállítani!</p>
                            <p>A jelszó visszaállításához kattints az alábbi linkre:</p>
                            <p style='text-align: center;'>
                                <a href='$reset_link' style='display: inline-block; padding: 10px 20px; color: #fff; background-color: #007BFF; text-decoration: none; border-radius: 5px;'>
                                    Jelszó visszaállítása
                                </a>
                                <p>Link: $reset_link</p>
                            </p>
                            <p>Ha nem te kérted a jelszó visszaállítását, kérlek hagyd figyelmen kívül ezt az üzenetet.</p>
                        </td>
                    </tr>
                </table>
            </div>
        ";

        $email_alt_body = "
            Elfelejtett jelszó

            Kedves $recipient_name,

            Úgy tűnik, hogy elfelejtetted a jelszavad. Ne aggódj, segítünk visszaállítani!

            A jelszó visszaállításához kattints az alábbi linkre:
            $reset_link

            Ha nem te kérted a jelszó visszaállítását, kérlek hagyd figyelmen kívül ezt az üzenetet.
        ";

        return send_email($recipient_name, $recipient_address, $subject, $email_html_body, $email_alt_body);
    }

    function create_reset_token_and_link($user_id) : string {
        do{
            $token = generate_token(1);
        }while(create_token($token, $user_id, "reset")["result"] == "false");
        $link = "localhost:8000/web/resetPassword.php?reset_token=$token";
        return $link;
    }

    function send_user_registration_email($user_id, $user_name, $link, $conn=null):array{
        echo $link;
        $user_email_data = get_user_email_data($user_id, $conn);
        
        $recipient_name = "$user_email_data[surname] $user_email_data[first_name]";
        $recipient_address = $user_email_data["email"];
        $subject = "Sikeresen regisztrált könyvtárunknál!";
        $email_html_body = "
            <div style='font-f amily: Arial, sans-serif; max-width: 600px; margin: 0 auto;'>
                <table style='width: 100%; background-color: #f9f9f9; border-collapse: collapse;'>
                    <tr>
                        <td style='padding: 20px; text-align: center; background-color: #007BFF; color: #FFFFFF;'>
                            <h1>Üdvözlünk könyvtárunknál!</h1>
                        </td>
                    </tr>
                    <tr>
                        <td style='padding: 20px;'>
                            <p>Köszönjük, hogy regisztráltál könyvtárunknál!</p>
                            <p>Reméljük elégedett leszel szolgáltatásainkkal!</p>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>A legjobb felhasználói élmény érdekében ajánljuk, hogy adj meg egy jelszót ezen a linken: <br><i>$link</i><br>
                            Miután ez megtörtént utána a felhasználói neveddel ($user_name, az olvasó kártyádon is megtalálod), és az általad megadott jelszóval tudsz a honlapunkon bejelentkezni.</p>
                             <p>Oldalunkon való bejelentkezés előnyei:</p>
                            <ul>
                                <li>Tudsz lefoglalni és előjegyezni könyvet, és ezeket bármikor vissza is tudod mondani
                                <li>Megtudod hosszabbítani már kivett könyveidet</li>
                                <li>Könnyedén nyomon tudod követni kivett könyveid, és azt is bármikor meg tudod nézni, hogy mikorra kell visszavinni őket</li>
                                <li>Bármikor megnézheted, hogy mikor jár le a taggságod</li>
                            </ul>
                        </td>
                    </tr>
                </table>
            </div>
        ";

        $email_alt_body = "
            Üdvözlünk könyvtárunknál!

            Köszönjük, hogy regisztráltál könyvtárunknál! Reméljük elégedett leszel szolgáltatásainkkal!

            A legjobb felhasználói élmény érdekében ajánljuk, hogy adj meg egy jelszót ezen a linken: $link.
            -Miután ez megtörtént utána a felhasználói neveddel ($user_name, az olvasó kártyádon is megtalálod), és a fenti linken megadott jelszavaddal tudsz a honlapunkon bejelentkezni.

            Oldalunkon való bejelentkezés előnyei:
            -Tudsz lefoglalni és előjegyezni könyvet, és ezeket bármikor vissza is tudod mondani
            -Megtudod hosszabbítani már kivett könyveidet
            -Könnyedén nyomon tudod követni kivett könyveid, és azt is bármikor meg tudod nézni, hogy mikorra kell visszavinni őket
            -Bármikor megnézheted, hogy mikor jár le a taggságod
        ";

        return send_email($recipient_name, $recipient_address, $subject, $email_html_body, $email_alt_body);
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
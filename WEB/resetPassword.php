<?php
    session_set_cookie_params([
        'lifetime' => 0, // Expire when browser closes
        'path' => '/',
        'domain' => '',
        'httponly' => true, // Prevent JS access
        'samesite' => 'Strict' // Prevent CSRF
    ]);

    session_start();

    if(!isset($_GET["reset_token"])){
        header("Location: /web/");
    }
?>

<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Reset password</title>
    <script src="jquery.js"></script>
</head>
<body>
    <label for="newPassword">Új jelszó:</label>
    <input required type="password" name="newPassword" id="newPassword"><br>
    <label for="newPasswordAgain">Új jelszó újra:</label>
    <input required type="password" id="newPasswordAgain">
    <button onclick="ChangePassword();" type="button">Cserélés</button>
</body>

<script>
    function ChangePassword(){
        let pw =document.getElementById("newPassword").value;
        let pwAgain =document.getElementById("newPasswordAgain").value;
        if(pw == ""){
            alert("Adjon meg valamit jelszónak!");
            return;
        }if(pw != pwAgain){
            alert("Nem egyezik a kettő jelszó!");
            return;
        }else{
            const currentUrl = new URL(window.location);
        
            $.ajax({
            url: "../BACKEND/api.php",
            type: "POST", //send it through post method
            data: { 
                reset_token: currentUrl.searchParams.get("reset_token"),
                password: pw
            },
            success: function(response)  {
                let data =JSON.parse(response);
                console.log(data);

                alert(data["status"]);
            }}); 
        }
    }
</script>
</html>
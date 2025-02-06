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
    <link rel="stylesheet" href="/web/style.css">
</head>
<body>
    <h1>Majd email-ben fog jönni a link</h1>
    <label for="newPassword">Új jelszó:</label>
    <input type="password" id="newPassword" oninput="ValidatePassword(this.value);">
    <div id="errors_with_password"></div>
    <label for="newPasswordAgain">Új jelszó újra:</label>
    <input required type="password" id="newPasswordAgain">
    <button onclick="ChangePassword();" type="button">Cserélés</button>
</body>
<script src="/web/passwordValidation.js"></script>

<script>
    function ChangePassword(){
        let password =document.getElementById("newPassword").value;
        let passwordAgain =document.getElementById("newPasswordAgain").value;
        ValidatePassword(password);
        if(document.getElementById("errors_with_password").innerHTML == ""){
            if(password != passwordAgain){
                alert("Nem egyezik a kettő jelszó!");
                return;
            }else{
                const currentUrl = new URL(window.location);
            
                $.ajax({
                url: "../BACKEND/api.php",
                type: "POST", //send it through post method
                data: { 
                    reset_token: currentUrl.searchParams.get("reset_token"),
                    password: password
                },
                success: function(response)  {
                    let data =JSON.parse(response);
                    console.log(data);
    
                    alert(data["status"]);
                }}); 
            }

        }else{
            alert("Még vannak hibák a jelszóval!")
        }

    }
</script>
</html>
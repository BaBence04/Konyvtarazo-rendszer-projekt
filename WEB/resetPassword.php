<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Reset password</title>
    <script src="jquery.js"></script>
    <link rel="stylesheet" href="/web/style.css">
    <script src="/web/passwordValidation.js" defer></script>
        
    <link rel="android-chrome" sizes="192x192" href="/web/icons/android-chrome-192x192.png">
    <link rel="android-chrome" sizes="512x512" href="/web/icons/android-chrome-512x512.png">
    <link rel="apple-touch-icon" sizes="180x180" href="/web/icons/apple-touch-icon.png">
    <link rel="icon" type="image/png" sizes="32x32" href="/web/icons/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="/web/icons/favicon-16x16.png">
    <link rel="manifest" href="/web/site.webmanifest">
    <link rel="shortcut icon" href="/web/icons/favicon.ico" type="image/x-icon">
</head>
<body>
    <?php require("navbar.html");?>
    <div class="space-after-nav"></div>
    <div class="change-password-holder" style="margin-inline: auto;">
        <!-- <label for="newPassword">Új jelszó:</label>
        <input type="password" id="newPassword" oninput="ValidatePassword(this.value);" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
        <?php require("new_password_error_messages.html");?>
        <label for="newPasswordAgain" >Új jelszó újra:</label>
        <input required type="password" id="newPasswordAgain" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');"> -->


        <div class="inputbox">
            <img src="/web/imgs/eye-off-line.png" id="eyeicon" onclick="TogglePasswordVisibility(this, 'newPassword');" alt="Toggle Password Visibility">
            <input type="password" id="newPassword" placeholder=" " oninput="ValidatePassword(this.value);" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
            <span for="newPassword">Új jelszó:</span>
            <i></i>
        </div>
        <?php require("new_password_error_messages.html");?>

        <div class="inputbox">
            <input type="password" id="newPasswordAgain" placeholder=" " onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
            <span for="newPasswordAgain">Új jelszó újra:</span>
            <i></i>
        </div>
        <!-- <input type="button" id="changePasswordButton" value="Módosítás" onclick="ChangePassword();"> -->

        <button onclick="ChangePassword();" id="changePasswordButton" type="button">Cserélés</button>
    </div>
</body>

<script>
    function ChangePassword(){
        let password = document.getElementById("newPassword").value;
        let passwordAgain = document.getElementById("newPasswordAgain").value;
        ValidatePassword(password);
        if(Array.from(document.getElementById("errors_with_password").children).every(e=> !e.checkVisibility())){
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
    
                    if(data["status"] == "success"){
                        alert("Sikeresen meg lett változtatva a jelszava!");
                        document.getElementById("newPassword").value = "";
                        document.getElementById("newPasswordAgain").value = "";
                        

                    }else if(data["status"] == "expired"){
                        alert("Ezzel a linkkel már egyszer meg lett változtatva a jelszó! Ha nem tudja jelszavát, kérem kérjen új linket!");
                    }else{
                        alert(data["status"]);
                    }
                }}); 
            }

        }else{
            alert("Még a megadott jelszó nem teljesíti az összes követelményt!");
        }
    }
</script>
</html>
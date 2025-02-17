<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Reset password</title>
    <script src="jquery.js"></script>
    <link rel="stylesheet" href="/web/style.css">
    <script src="/web/passwordValidation.js" defer></script>
</head>
<body>
    <?php require("navbar.html");?>
    <h1>Majd email-ben fog jönni a link</h1>
    <label for="newPassword">Új jelszó:</label>
    <input type="password" id="newPassword" oninput="ValidatePassword(this.value);" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
    <?php require("new_password_error_messages.html");?>
    <label for="newPasswordAgain" >Új jelszó újra:</label>
    <input required type="password" id="newPasswordAgain" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
    <button onclick="ChangePassword();" id="changePasswordButton" type="button">Cserélés</button>
</body>

<script>
    function ChangePassword(){
        let password = document.getElementById("newPassword").value;
        let passwordAgain =document.getElementById("newPasswordAgain").value;
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
                    console.log(data);
    
                    alert(data["status"]);
                }}); 
            }

        }else{
            alert("Még a megadott jelszó nem teljesíti az összes követelményt!");
        }
    }
</script>
</html>
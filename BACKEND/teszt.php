<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Teszt</title>
</head>
<body>
    <?php
        require_once "databaseFunctions.php";
        require_once "elementCreators.php";
        require_once "additionalFunctions.php";
        require_once "mailer.php";

        send_user_registration_email(1, "hoba123", create_reset_token_and_link(1));
    ?>
    
</body>
</html>

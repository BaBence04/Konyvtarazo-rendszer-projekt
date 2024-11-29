<?php
    //make it invisible for the human eye if possible
    session_start();
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Felhasználó</title>
</head>
<body>
    <div class="content__container">
        <?php
            createAccountDetails($_SESSION['user_id']);
        ?>
    </div>

    
</body>
</html>
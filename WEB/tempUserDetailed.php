<?php
    require "../BACKEND/databaseFunctions.php";

    session_start();
    $data = GetUser($_SESSION['user_id']);
?>

<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Felhasználói Fiók</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .content__container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }

        .account-details {
            background-color: white;
            padding: 20px;
            border: 1px solid #ddd;
            box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
            margin-bottom: 20px;
        }

        .account-details h2 {
            margin-top: 0;
        }

        .account-info {
            margin-bottom: 20px;
        }

        .account-info label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .account-info p {
            margin: 0 0 10px;
        }

        .book-section {
            background-color: white;
            padding: 20px;
            border: 1px solid #ddd;
            box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
            margin-bottom: 20px;
        }

        .book-section h3 {
            margin-top: 0;
            margin-bottom: 20px;
        }

        .book-list {
            list-style: none;
            padding: 0;
            margin: 0;
        }

        .book-list li {
            margin-bottom: 15px;
            padding: 10px;
            border: 1px solid #ddd;
            background-color: #f9f9f9;
        }

        .book-list li:last-child {
            margin-bottom: 0;
        }

        .book-title {
            font-weight: bold;
        }

        .book-author {
            color: #555;
        }

        .return-date-past {
            color: red;
        }

    </style>
</head>
<body>

<div class="content__container">
    <!-- Felhasználói adatok -->
    <div class="account-details">
        <h2>Fiók adatai</h2>
        <div class="account-info">
            <label>Név:</label>
            <p><?=$data['surname'].' '.$data['first_name']?></p>

            <label>Felhasználónév:</label>
            <p><?=$data['username']?><p>

            <label>Születési hely:</label>
            <p><?=$data['birth_place']?><p>

            <label>Születési dátum:</label>
            <p><?=$data['birth_date']?><p>

            <label>Lakhely:</label>
            <p><?=$data['address']?><p>

            <label>Email:</label>
            <p><?=$data['email']?></p>

            <label>Telefonszám:</label>
            <p><?=$data['phone_number']?></p>

            <label>Tagság érvényessége:</label>
            <p><?=$data["membership_end_date"]?></p>
            
            <label>Anyja születéskori neve:</label>
            <p><?=$data["mother_maiden_name"]?></p>
            
        </div>
    </div>

    IDÁIG VAN KÉSZ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    <!-- Jelenlegi kivett könyvek -->
    <div class="book-section">
        <?php
            $borrowedBooks = GetBorrowedBooks($_SESSION["user_id"]);
            
        ?>
        <h3>Jelenlegi kivett könyvek</h3>
        <ul class="book-list">
            <li>
                <span class="book-title">A könyv címe 1</span> <br>
                <span class="book-author">Szerző neve</span> <br>
                <span class="return-date">Visszavételi dátum: 2024. október 25.</span>
            </li>
            <li>
                <span class="book-title">A könyv címe 2</span> <br>
                <span class="book-author">Szerző neve</span> <br>
                <span class="return-date">Visszavételi dátum: 2024. november 5.</span>
            </li>
        </ul>
    </div>

    <!-- Korábban kivett könyvek -->
    <div class="book-section">
        <h3>Korábban kivett könyvek</h3>
        <ul class="book-list">
            <li>
                <span class="book-title">A könyv címe 3</span> <br>
                <span class="book-author">Szerző neve</span> <br>
                <span class="return-date-past">Visszavéve: 2024. szeptember 15.</span>
                <span>Viszavitt</span>
            </li>
            <li>
                <span class="book-title">A könyv címe 4</span> <br>
                <span class="book-author">Szerző neve</span> <br>
                <span class="return-date-past">Visszavéve: 2024. augusztus 30.</span>
                <span>Viszavitt</span>
            </li>
        </ul>
    </div>
</div>

</body>
</html>

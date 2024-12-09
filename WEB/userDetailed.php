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
    <script src="./jquery.js"></script>
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

        .book-section input[type="button"]{
            float: right
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
            <p><?=$data['username']?></p>

            <label>Születési hely:</label>
            <p><?=$data['birth_place']?></p>

            <label>Születési dátum:</label>
            <p><?=$data['birth_date']?></p>

            <label>Lakhely:</label>
            <p><?=$data['address']?></p>

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

    
    <!-- Jelenleg kivett könyvek -->
    <div class="book-section">
        <?php
            $borrowedBooks = GetBorrowedBooks($_SESSION["user_id"]);

            if(count($borrowedBooks)>0){
                echo "<h3>Jelenlegi kivett könyvek</h3>";

                echo '<ul class="book-list">';
                foreach ($borrowedBooks as $key => $borrowedBookData) {
                    echo '
                    <li>';
                        echo '<span class="book-title">'.$borrowedBookData["title"].'</span> <br>';
                        echo '<span class="book-author">'.str_replace(",", ", ",$borrowedBookData["authors"]).'</span> <br>';

                        echo '<span class="return-date'.(date("Y-m-d")>$borrowedBookData["end_date"]?"-past":"").'">Határidő: '.$borrowedBookData["end_date"].'</span>';
                        
                        if(IsItExtendable($_SESSION["user_id"], $borrowedBookData["book_id"])){
                            echo '<input data-book-id="'.$borrowedBookData["book_id"].'" type="button" value="Meghosszabbítás" onclick="Meghosszabbitas(this)">';
                        }
                    echo '</li>';

                }
                echo "</ul>";
            }
        ?>
        
        
    </div>
    
    <!-- Korábban kivett könyvek -->
    <div class="book-section">

        
        <ul class="book-list">
            <?php
                $previouslyBorrowedBooks = GetPreviouslyBorrowedBooks($_SESSION["user_id"]);    
                if(count($previouslyBorrowedBooks)>0){
                    echo "<h3>Korábban kivett könyvek</h3>";
        
                    echo '<ul class="book-list">';
                    foreach ($previouslyBorrowedBooks as $key => $previouslyBorrowedBookData) {
                        echo '
                        <li>';
                            echo '<span class="book-title">'.$previouslyBorrowedBookData["title"].'</span> <br>';
                            echo '<span class="book-author">'.str_replace(",", ", ",$previouslyBorrowedBookData["authors"]).'</span> <br>';
        
                            echo '<span class="return-date">Határidő: '.$previouslyBorrowedBookData["end_date"].'</span>
                        </li>';
                    }
                    echo "</ul>";

                }

            ?>
            <!-- <li>
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
            </li> -->
        </ul>
    </div>
</div>

<script>
    function Meghosszabbitas(element){
        var action = "extend";
        var bookId = element.getAttribute("data-book-id");
        var userId = <?=$_SESSION["user_id"]?>;

        var params = {
            book_id: bookId,
            user_id: userId,
            action: action
        }

        $.post("../BACKEND/api.php", params,(data, status)=>{
            // console.log((data));
            if(data.message == "Sikeres hosszabbítás!"){
                location.reload();
            }else{
                alert(data.message);
            }
        },"json").fail((data, status)=>{
            console.log(data);
            console.log(status);
        })
    }
</script>

</body>
</html>

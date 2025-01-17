<?php
    require "../BACKEND/databaseFunctions.php";

    $data = GetUser($_SESSION['user_id']);
    $borrowedBooks = GetBorrowedBooks($_SESSION["user_id"]);
    $previouslyBorrowedBooks = GetPreviouslyBorrowedBooks($_SESSION["user_id"]);  
    
    $bookedAndReservedBooks = GetBookedAndReservedBooks($_SESSION["user_id"]);

    $booked_books = [];
    $reserved_books = [];

    foreach ($bookedAndReservedBooks as $key => $booked_or_reserved_books_data){
        if($booked_or_reserved_books_data["status"] == "booking"){
            $booked_books[] = $booked_or_reserved_books_data;
        }else{
            $reserved_books[] = $booked_or_reserved_books_data;
        }
    }



?>


<style>
    a, a:active, a:hover, a:visited, a:link{
        color: unset;
        text-decoration: unset;
        padding: unset;
        margin: unset;
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

    .hidden{
        display: none;
    }

</style>

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

        <!-- Előjegyzett könyvek -->
            <!-- Kell gomb arra, hogy le lehessen mondani az előjegyzést -->
        <div class="book-section <?php 
            if(count($reserved_books)==0){
                echo "hidden";
            }
        ?>">

            
            <ul class="book-list">
                <?php
                    if(count($reserved_books)>0){
                        echo "<h3>Előjegyzett könyvek</h3>";
            
                        echo '<ul class="book-list">';
                        foreach ($reserved_books as $key => $reserved_books_data) {
                            echo '
                            <li>';
                                echo '<a href="./bookDetailed.php?ISBN='.$reserved_books_data["ISBN"].'"><span class="book-title">'.$reserved_books_data["title"].'</span></a> <br>';
                                echo '<span class="book-author">'.str_replace(",", ", ",$reserved_books_data["authors"]).'</span> <br>';
                                echo '<input data-id="'.$reserved_books_data["id"].'" type="button" class="book_action_button" value="Lemondás" onclick="CancelReservationOrBooking(\'cancelReservation\', this)">';
                                
                            echo '</li>';
                        }
                        echo "</ul>";

                    }

                ?>
            </ul>
        </div>

        <!-- Lefoglalt könyvek -->
                    <!-- Kell gomb arra, hogy le lehessen mondani a foglalást -->
        <div class="book-section <?php 
            if(count($booked_books)==0){
                echo "hidden";
            }
        ?>">

            
            <ul class="book-list">
                <?php
                    if(count($booked_books)>0){
                        echo "<h3>Lefoglalt könyvek</h3>";
            
                        echo '<ul class="book-list">';
                        foreach ($booked_books as $key => $booked_books_data) {
                            echo '
                            <li>';
                                echo '<a href="./bookDetailed.php?ISBN='.$booked_books_data["ISBN"].'"><span class="book-title">'.$booked_books_data["title"].'</span></a> <br>';
                                echo '<span class="book-author">'.str_replace(",", ", ",$booked_books_data["authors"]).'</span> <br>';
                                echo '<input data-id="'.$booked_books_data["id"].'" type="button" class="book_action_button" value="Lemondás" onclick="CancelReservationOrBooking(\'cancelBooking\', this)">';
                                
                            echo '</li>';
                        }
                        echo "</ul>";

                    }

                ?>
            </ul>
        </div>

    
        <!-- Jelenleg kivett könyvek -->
        <div class="book-section <?php 
            if(count($borrowedBooks)==0){
                echo "hidden";
            }
        ?>">
            <?php

                if(count($borrowedBooks)>0){
                    echo "<h3>Jelenlegi kivett könyvek</h3>";

                    echo '<ul class="book-list">';
                    foreach ($borrowedBooks as $key => $borrowed_book_data) {
                        echo '
                        <li>';
                            echo '<a href="./bookDetailed.php?ISBN='.$borrowed_book_data["ISBN"].'"><span class="book-title">'.$borrowed_book_data["title"].'</span></a> <br>';
                            echo '<span class="book-author">'.str_replace(",", ", ",$borrowed_book_data["authors"]).'</span> <br>';

                            echo '<span class="return-date'.(date("Y-m-d")>$borrowed_book_data["end_date"]?"-past":"").'">Határidő: '.$borrowed_book_data["end_date"].'</span>';
                            
                            if(IsItExtendable($_SESSION["user_id"], $borrowed_book_data["book_id"])){
                                echo '<input data-book-id="'.$borrowed_book_data["book_id"].'" type="button" class="book_action_button" value="Meghosszabbítás" onclick="Meghosszabbitas(this)">';
                            }
                        echo '</li>';

                    }
                    echo "</ul>";
                }
            ?>
            
            
        </div>
        
        <!-- Korábban kivett könyvek -->
        <div class="book-section <?php 
            if(count($previouslyBorrowedBooks)==0){
                echo "hidden";
            }
        ?>">

            
            <ul class="book-list">
                <?php
                    if(count($previouslyBorrowedBooks)>0){
                        echo "<h3>Korábban kivett könyvek</h3>";
            
                        echo '<ul class="book-list">';
                        foreach ($previouslyBorrowedBooks as $key => $previously_borrowed_book_data) {
                            echo '
                            <li>';
                                echo '<a href="./bookDetailed.php?ISBN='.$previously_borrowed_book_data["ISBN"].'"><span class="book-title">'.$previously_borrowed_book_data["title"].'</span></a> <br>';
                                echo '<span class="book-author">'.str_replace(",", ", ",$previously_borrowed_book_data["authors"]).'</span> <br>';
            
                                echo '<span class="return-date">Határidő: '.$previously_borrowed_book_data["end_date"].'</span>
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
        <div class="logout-container">
            <button id="logoutButton" onclick="Kijelentkezés();">Kijelentkezés</button>
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

        function Kijelentkezés(){
            $.ajax({
            url: "../BACKEND/api.php",
            type: "post", //send it through get method
            data: { 
                action: "logout"
            },
            success: function(response)  {
            
            // window.open("./userDetailed.php", "_self");
            const currentUrl = new URL(window.location);
            currentUrl.searchParams.set("page", "mainPage");
            // console.log(currentUrl)
            window.history.pushState({}, '', currentUrl);
            location.reload();
            
            }
            });
        }

        function CancelReservationOrBooking(which, element){
            if((which != "cancelReservation" && which != "cancelBooking") || parseInt(element.getAttribute("data-id")) != element.getAttribute("data-id")) return;


            // console.log(document.getElementById("username").value, document.getElementById("password").value );
            $.ajax({
                url: "../BACKEND/api.php",
                type: "POST", //send it through post method
                data: { 
                    action: which, 
                    id: element.getAttribute("data-id") 
                },
                success: function(response)  {
                    //remove the element or reload site
                    location.reload();
                }
            }); 
        }

    </script>

</body>


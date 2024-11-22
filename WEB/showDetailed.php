<div class="book-details">
        <div class="book-image">
            <img src="<?=$book_data["picture_base64"]?>" alt="Book Image">
        </div>

        <div class="book-info">
            <div class="book-title"><?=$book_data["title"]?></div>
            <div class="book-author"><?=implode(", ", explode(",",$book_data["picture_base64"]))?></div>

            <div class="book-genres">
            <?php
                $genres = explode(",", $book_data["genres"]);
                foreach ($genres as $genre) {
                    echo "<span>#$genre</span>";
                }
            ?>
            </div>

            <div class="book-description">
                <?= $book_data["description"]?>
            </div>
            <div class="release_date"><?=$book_data["release_date"]?></div>
            <div class="isbn"><?=$book_data["ISBN"]?></div>

            <div class="availability">Elérhető</div>


            <div class="buttons">
                <button class="wishlist-button">Kívánságlistához adás</button>

                <?php
                    //if te user is logged in
                    if(isset($_SESSION["user_id"])){
                        //returns "reservation" | "booking"
                        $availability_data = CheckBookAvailability(GetIsbnIdByIsbn($_GET["ISBN"]),$_SESSION["user_id"]);
                        if($availability_data["available"] == "true"){
                            if($availability_data["status"] == "reservation"){
                                echo `<button class="reserve-button">Előjegyzés</button>`;        

                            }else{
                                echo `<button class="reserve-button">Foglalás</button>`;        
                            }


                        }
                    }

                ?>
            </div>
        </div>
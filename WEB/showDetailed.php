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
                    session_start();
                    //if te user is logged in
                    if(isset($_SESSION["user_id"])){
                        //returns "reservation" | "booking"
                        $availability_data = CheckBookAvailability(GetIsbnIdByIsbn($_GET["ISBN"]),$_SESSION["user_id"]);
                        //EZEKRE A GOMBOKRA KELL EGY DISABLED STÍLUS
                        $buttonHtml = '<button class="reserve-button" id="reserve-button" onclick="reserveOrBook();"';
                        if($availability_data["available"] != "true"){
                            $buttonHtml .= ' disabled';
               
                        }
                        $buttonHtml .= '>';
                        if($availability_data["status"] == "reservation"){
                            $buttonHtml .= "Előjegyzés";
                        }else{
                            $buttonHtml .= "Foglalás";
                        }
                        $buttonHtml .= "</button>";
                        echo $buttonHtml;
                    }

                ?>
            </div>
        </div>
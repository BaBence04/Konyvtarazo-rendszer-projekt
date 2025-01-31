<div class="book-details">
        <div class="book-image">
            <img src="<?=$book_data["picture_base64"]?>" alt="Book Image">
        </div>

        <div class="book-info">
            <div class="book-title"><?=$book_data["title"]?></div>
            <div class="book-author"><?=implode(", ", explode(",",$book_data["authors"]))?></div>

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

            <?php if(!isset($_SESSION["user_id"])): ?>
            <div class="availability">Elérhető</div>
            <?php endif;?>


            <div class="buttons">
                <!-- <button class="wishlist-button">Kívánságlistához adás</button> -->

                <?php
                    //if the user is logged in
                    if(isset($_SESSION["user_id"])){
                        //returns "reservation" | "booking"
                        $availability_data = CheckBookAvailability(GetIsbnIdByIsbn($_GET["ISBN"]),$_SESSION["user_id"]);
                        
                        //EZEKRE A GOMBOKRA KELL EGY DISABLED STÍLUS
                        if($availability_data["available"] == "true"){
                            $buttonHtml = '<button class="reserve-button" id="reserve-button" onclick="reserveOrBook();"';

                            $buttonHtml .= '>';
                            if($availability_data["status"] == "reservation"){
                                $buttonHtml .= "Előjegyzés";
                            }else{
                                $buttonHtml .= "Foglalás";
                            }
                            $buttonHtml .= "</button>";
                            echo $buttonHtml;
                        }
                    }

                ?>
            </div>
        </div>

        <script src="jquery.js"></script>
        <script>
            function reserveOrBook(){
                $.ajax({
                    url: "../BACKEND/api.php",
                    type: "POST", //send it through get method
                    data: { 
                        isbn_id: <?=$book_data['ISBN_id']?> 
                    },
                    success: function(response)  {
                            //Ezt is szép fancyre meg kell csinálni
                        if(response != '<?=$availability_data["status"]?>'){
                            alert("A könyv állapota menetközben megváltozott, úgyhogy "+((response=="reservation")?"elő lett jegyezve":"le lett foglalva"));
                            
                        }else if(response == "reservation"){
                            alert("Sikeres előjegyzés!");

                        }else if(response == "booking"){
                            alert("Sikeres foglalás!");
                        }
                        // document.getElementById("reserve-button").disabled = true;
                        location.reload();
                    }
                }); 
                
            }
        </script>
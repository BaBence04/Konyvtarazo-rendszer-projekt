<main>
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
            <div class="release_date">Kiadás éve: <?=$book_data["release_date"]?></div>
            <div class="isbn" title="Az ISBN számok olyan egyedi azonosítók amikkel be lehet azonosítani könyveket">ISBN: <?=$book_data["ISBN"]?></div>
    
            <?php if(!isset($_SESSION["user_id"])): ?>
            <div class="availability">Elérhető</div>
            <?php endif;?>
    
    
            <div class="buttons">
                <!-- <button class="wishlist-button">Kívánságlistához adás</button> -->
    
                <!-- if the user is logged in -->
                <?php if(isset($_SESSION["user_id"])):?>

                    <?php
                        //returns "reservation" | "booking"
                        $availability_data = CheckBookAvailability(GetIsbnIdByIsbn($book_data["ISBN"]),$_SESSION["user_id"]);
                        
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
                    

                    ?>
                    <svg xmlns="http://www.w3.org/2000/svg" data-selected="<?= is_book_on_shelf($_SESSION["user_id"], $book_data["ISBN_id"]) ?>" data-isbn-id="<?=$book_data["ISBN_id"]?>" onclick="addOrRemoveFromShelf(this)" width="48" height="48" viewBox="0 0 24 24" fill="none" stroke="black" stroke-width="1" stroke-linecap="round" stroke-linejoin="round" class="lucide lucide-library-big"><rect width="8" height="18" x="3" y="3" rx="1"/><path d="M7 3v18"/><path d="M20.4 18.9c.2.5-.1 1.1-.6 1.3l-1.9.7c-.5.2-1.1-.1-1.3-.6L11.1 5.1c-.2-.5.1-1.1.6-1.3l1.9-.7c.5-.2 1.1.1 1.3.6Z"/></svg>

                <?php endif;?>
            </div>
        </div>
    </div>
</main>

    <script>
        function reserveOrBook(){
            $.ajax({
                url: "/BACKEND/api.php",
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

        function addOrRemoveFromShelf(element){
            const isbnId = element.getAttribute("data-isbn-id");
            if(parseInt(isbnId) != isbnId) return;

            const selected = element.getAttribute("data-selected") == "1";
            let action = selected?"removeFromShelf":"addToShelf";

            $.ajax({
                url: "/BACKEND/api.php",
                type: "POST", //send it through get method
                data: { 
                    action: action,
                    ISBN_id: isbnId
                },
                success: function(response)  {
                    selected?element.setAttribute("data-selected", 0):element.setAttribute("data-selected", 1); 
                    // location.reload();
                }
            }); 

        }
    </script>
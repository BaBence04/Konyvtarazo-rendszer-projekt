<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.css"/>
<script src="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.js"></script>
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

    <div class="similar-books-section">
        <h2>Ezek tetszhetnek még:</h2>
        <div class="slider-container swiper">
            <div class="similar-books-slider swiper-wrapper">
                
                <?php
                $similar_books = getSimilarBooks($book_data["ISBN_id"]);
                foreach ($similar_books as $similar_book) {
                    echo '<div class="book_item swiper-slide" data-ISBN="' . $similar_book['ISBN'] . '" onclick="OpenSimilarBookDetailed(this)">';
                    echo '<img src="' . $similar_book['picture_base64'] . '" alt="' . $similar_book['title'] . '">';
                    echo '<div class="book_info">';
                    echo '<div class="book_title">' . $similar_book['title'] . '</div>';
                    echo '<div class="book_author">' . $similar_book['authors'] . '</div>';
                    echo '<div class="book_genre">#' . $similar_book['genres'] . '</div>';
                    echo '</div>';
                    echo '</div>';
                }
                ?>
            </div>
            <div class="swiper-pagination"></div>
            <div class="swiper-button-prev"></div>
            <div class="swiper-button-next"></div>

            
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

        document.addEventListener("DOMContentLoaded", function () {
            const swiper = new Swiper('.slider-container', {
                direction: 'horizontal',
                loop: true,
                slidesPerView: 5,
                loopAdditionalSlides: 5,
                spaceBetween: 20,
                watchSlidesProgress: true,

                pagination: {
                    el: '.swiper-pagination',
                    clickable: true,
                },

                navigation: {
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                },

                scrollbar: {
                    el: '.swiper-scrollbar',
                },

                on: {
                    slideChange: function () {
                        console.log("Current index:", this.activeIndex);
                    }
                },

                breakpoints: {
                    0: {
                        slidesPerView: 1
                    },
                    768: {
                        slidesPerView: 3
                    },
                    1222: {
                        slidesPerView: 5
                    },
                }
            });

            window.addEventListener("resize", function () {
            swiper.update();
        });
        });

        console.log("Total slides: ", document.querySelectorAll('.swiper-slide').length);




        



    </script>

    

<!-- <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.css"/> -->
<!-- <script src="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.js"></script> -->
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
    
            <!-- <?php if(!isset($_SESSION["user_id"])): ?>
            <div class="availability">Elérhető</div>
            <?php endif;?>
     -->
    
            <div class="buttons">
                <!-- if the user is logged in -->
                <?php if(isset($_SESSION["user_id"], $_SESSION["restricted"]) && $_SESSION["restricted"] == "false"):?>

                    <?php
                        //returns "reservation" | "booking"
                        $availability_data = CheckBookAvailability(GetIsbnIdByIsbn($book_data["ISBN"]),$_SESSION["user_id"]);
                        // var_dump( $availability_data);
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
                <?php endif;?>

                <?php if(isset($_SESSION["user_id"], $_SESSION["restricted"])):?>
                    <label class='ui-like'>
                        <input type='checkbox' onchange='addOrRemoveFromFavorites(this);' data-isbn-id='<?=$book_data["ISBN_id"]?>' class='like-input'  <?= is_book_on_favorites($_SESSION["user_id"], $book_data["ISBN_id"])==true?"checked":"" ?>>
                        <div class='like'>
                        <svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill=''><g stroke-width='0' id='SVGRepo_bgCarrier'></g><g stroke-linejoin='round' stroke-linecap='round' id='SVGRepo_tracerCarrier'></g><g id='SVGRepo_iconCarrier'><path d='M20.808,11.079C19.829,16.132,12,20.5,12,20.5s-7.829-4.368-8.808-9.421C2.227,6.1,5.066,3.5,8,3.5a4.444,4.444,0,0,1,4,2,4.444,4.444,0,0,1,4-2C18.934,3.5,21.773,6.1,20.808,11.079Z'></path></g></svg>
                        </div>
                    </label>
                    <!-- <svg xmlns="http://www.w3.org/2000/svg" class="heartIcon" onclick="addOrRemoveFromFavorites(this);" data-selected="<?= is_book_on_favorites($_SESSION["user_id"], $book_data["ISBN_id"]) ?>" data-isbn-id="<?=$book_data["ISBN_id"]?>" width="24" height="24" viewBox="0 0 24 24" fill="white" stroke="black" stroke-width="1" stroke-linecap="round" stroke-linejoin="round" class="lucide lucide-heart"><path d="M19 14c1.49-1.46 3-3.21 3-5.5A5.5 5.5 0 0 0 16.5 3c-1.76 0-3 .5-4.5 2-1.5-1.5-2.74-2-4.5-2A5.5 5.5 0 0 0 2 8.5c0 2.3 1.5 4.05 3 5.5l7 7Z"/></svg> -->
                    <!-- <svg xmlns="http://www.w3.org/2000/svg" data-selected="<?= is_book_on_favorites($_SESSION["user_id"], $book_data["ISBN_id"]) ?>" data-isbn-id="<?=$book_data["ISBN_id"]?>" onclick="addOrRemoveFromFavorites(this)" width="48" height="48" viewBox="0 0 24 24" fill="none" stroke="black" stroke-width="1" stroke-linecap="round" stroke-linejoin="round" class="lucide lucide-library-big"><rect width="8" height="18" x="3" y="3" rx="1"/><path d="M7 3v18"/><path d="M20.4 18.9c.2.5-.1 1.1-.6 1.3l-1.9.7c-.5.2-1.1-.1-1.3-.6L11.1 5.1c-.2-.5.1-1.1.6-1.3l1.9-.7c.5-.2 1.1.1 1.3.6Z"/></svg> -->

                <?php endif;?>
            </div>
        </div>
    </div>

    <div class="simlar-books-container">
        <div class="swiper-button">
            <svg xmlns="http://www.w3.org/2000/svg" class="prev-button" onclick="ShowNextOrPreviousItem(-1);" height="40px" viewBox="0 -960 960 960" width="40px" fill="#0a7b6a"><path d="m313-440 196 196q12 12 11.5 28T508-188q-12 11-28 11.5T452-188L188-452q-6-6-8.5-13t-2.5-15q0-8 2.5-15t8.5-13l264-264q11-11 27.5-11t28.5 11q12 12 12 28.5T508-715L313-520h447q17 0 28.5 11.5T800-480q0 17-11.5 28.5T760-440H313Z"/></svg>
        </div>

        <div class="similar-books-section">
            <h2>Ezek tetszhetnek még:</h2>
            
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
                
                <!-- <div class="swiper-pagination"></div> -->
                
        </div>  

        <div class="swiper-button">
            <svg xmlns="http://www.w3.org/2000/svg" class="next-button" onclick="ShowNextOrPreviousItem(1);" height="40px" viewBox="0 -960 960 960" width="40px" fill="#0a7b6a"><path d="M647-440H200q-17 0-28.5-11.5T160-480q0-17 11.5-28.5T200-520h447L451-716q-12-12-11.5-28t12.5-28q12-11 28-11.5t28 11.5l264 264q6 6 8.5 13t2.5 15q0 8-2.5 15t-8.5 13L508-188q-11 11-27.5 11T452-188q-12-12-12-28.5t12-28.5l195-195Z"/></svg>
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
                    if(response != '<?=(isset($_SESSION["user_id"], $_SESSION["restricted"]) && $_SESSION["restricted"] == "false")? $availability_data["status"]:""?>'){
                        console.log(response);
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
        //if direction == 1 than it shows the next, if it is -1 than it shows the previous item
        function ShowNextOrPreviousItem(direction){
            let sliderElement = document.querySelector(".similar-books-slider");
            let items = document.getElementsByClassName("book_item");
            if(direction == 1 || direction == -1){
                if(direction == -1 && sliderElement.scrollLeft == 0){
                    direction = (items.length-1) * items[0].scrollWidth;

                }else if(direction == 1 &&  sliderElement.scrollLeft + sliderElement.clientWidth >= sliderElement.scrollWidth){
                    direction = -sliderElement.scrollWidth
                }

                sliderElement.scrollBy(direction, 0);
            }
        }

        

        // document.addEventListener("DOMContentLoaded", function () {
        //     const swiper = new Swiper('.slider-container', {
        //         direction: 'horizontal',
        //         loop: true,
        //         slidesPerView: 5,
        //         loopAdditionalSlides: 5,
        //         spaceBetween: 20,
        //         watchSlidesProgress: true,

        //         pagination: {
        //             el: '.swiper-pagination',
        //             clickable: true,
        //         },

        //         navigation: {
        //             nextEl: '.swiper-button-next',
        //             prevEl: '.swiper-button-prev',
        //         },

        //         scrollbar: {
        //             el: '.swiper-scrollbar',
        //         },

        //         on: {
        //             slideChange: function () {
        //                 console.log("Current index:", this.activeIndex);
        //             }
        //         },

        //         breakpoints: {
        //             0: {
        //                 slidesPerView: 1
        //             },
        //             768: {
        //                 slidesPerView: 3
        //             },
        //             1222: {
        //                 slidesPerView: 5
        //             },
        //         }
        //     });

        //     window.addEventListener("resize", function () {
        //     swiper.update();
        // });
        // });

        // console.log("Total slides: ", document.querySelectorAll('.swiper-slide').length);




        



    </script>

    

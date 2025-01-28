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
<link rel="stylesheet" href="style.css">


<body>

    <div class="container">
        <div class="sidebar">
            <div class="nav-item selected" id="nav-account-details" onclick="showSection(this);">
                Fiók <span>adatai</span> <span class="indicator"></span>
            </div>
            <div class="nav-item" id="nav-reserved-books" onclick="showSection(this);">
                Előjegyzett <span>könyvek</span> <span class="indicator"></span>
            </div>
            <div class="nav-item" id="nav-booked-books" onclick="showSection(this);">
                Lefoglalt <span>könyvek</span> <span class="indicator"></span>
            </div>
            <div class="nav-item" id="nav-borrowed-books" onclick="showSection(this);">
                Jelenleg kivett <span>könyvek</span> <span class="indicator"></span>
            </div>
            <div class="nav-item" id="nav-previously-borrowed-books" onclick="showSection(this);">
                Korábban kivett <span>könyvek</span> <span class="indicator"></span>
            </div>
        </div>

        <div class="main-content">
            <div class="section" style="display: block;" id="account-details">
                <h2>Fiók adatai</h2>
                <div class="account-info">
                    <div><strong>Név:</strong> <?=$data['surname'].' '.$data['first_name']?></div>
                    <div><strong>Felhasználónév:</strong> <?=$data['username']?></div>
                    <div><strong>Születési hely:</strong> <?=$data['birth_place']?></div>
                    <div><strong>Születési dátum:</strong> <?=$data['birth_date']?></div>
                    <div><strong>Lakhely:</strong> <?=$data['address']?></div>
                    <div><strong>Email:</strong> <?=$data['email']?></div>
                    <div><strong>Telefonszám:</strong> <?=$data['phone_number']?></div>
                    <div><strong>Tagság érvényessége:</strong> <?=$data["membership_end_date"]?></div>
                    <div><strong>Anyja születéskori neve:</strong> <?=$data["mother_maiden_name"]?></div>
                </div>
            </div>

            <div class="section" id="reserved-books">
                <?php if(count($reserved_books) > 0): ?>
                    <h3>Előjegyzett könyvek</h3>
                    <?php foreach ($reserved_books as $reserved_books_data): ?>
                        <div class="book-item">
                            <a href="./bookDetailed.php?ISBN=<?= $reserved_books_data['ISBN'] ?>"><?= $reserved_books_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $reserved_books_data['authors']) ?></span>
                            <button class="book_action_button" onclick="CancelReservationOrBooking('cancelReservation', this)" data-id="<?= $reserved_books_data['id'] ?>">Lemondás</button>
                        </div>
                    <?php endforeach; ?>
                <?php endif; ?>
            </div>

            <div class="section" id="booked-books">
                <?php if(count($booked_books) > 0): ?>
                    <h3>Lefoglalt könyvek</h3>
                    <?php foreach ($booked_books as $booked_books_data): ?>
                        <div class="book-item">
                            <a href="./bookDetailed.php?ISBN=<?= $booked_books_data['ISBN'] ?>"><?= $booked_books_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $booked_books_data['authors']) ?></span>
                            <button class="book_action_button" onclick="CancelReservationOrBooking('cancelBooking', this)" data-id="<?= $booked_books_data['id'] ?>">Lemondás</button>
                        </div>
                    <?php endforeach; ?>
                <?php endif; ?>
            </div>

            <div class="section" id="borrowed-books">
                <?php if(count($borrowedBooks) > 0): ?>
                    <h3>Jelenlegi kivett könyvek</h3>
                    <?php foreach ($borrowedBooks as $borrowed_book_data): ?>
                        <div class="book-item">
                            <a href="./bookDetailed.php?ISBN=<?= $borrowed_book_data['ISBN'] ?>"><?= $borrowed_book_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $borrowed_book_data['authors']) ?></span>
                            <span class="return-date"><?= $borrowed_book_data['end_date'] ?></span>
                            <button class="book_action_button" data-book-id="<?= $borrowed_book_data['book_id'] ?>" onclick="Meghosszabbitas(this)">Meghosszabbítás</button>
                        </div>
                    <?php endforeach; ?>
                <?php endif; ?>
            </div>

            <div class="section" id="previously-borrowed-books">
                <?php if(count($previouslyBorrowedBooks) > 0): ?>
                    <h3>Korábban kivett könyvek</h3>
                    <?php foreach ($previouslyBorrowedBooks as $previously_borrowed_book_data): ?>
                        <div class="book-item">
                            <a href="./bookDetailed.php?ISBN=<?= $previously_borrowed_book_data['ISBN'] ?>"><?= $previously_borrowed_book_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $previously_borrowed_book_data['authors']) ?></span>
                            <span class="return-date"><?= $previously_borrowed_book_data['end_date'] ?></span>
                        </div>
                    <?php endforeach; ?>
                <?php endif; ?>
            </div>

            <div class="logout-container">
                <button id="logoutButton" onclick="Kijelentkezés();">Kijelentkezés</button>
            </div>
        </div>
    </div>

    <script>

        function showSection(element) {
            let navItems = Array.from(document.querySelectorAll(".sidebar>.nav-item"));
            const sections = Array.from(document.querySelectorAll('.section'));

            let newIndex = navItems.indexOf(element);
            let currentIndex = -1

            let currentSelectedElement = document.querySelector(".nav-item.selected");
            if(currentSelectedElement != undefined){
                if(element == currentSelectedElement){
                    return;
                }

                currentIndex = navItems.indexOf(currentSelectedElement);            
                sections[currentIndex].style.display = "none";

                const selectedNavItems = document.querySelectorAll('.nav-item.selected');
                selectedNavItems.forEach(item => {
                    item.classList.remove("selected");
                });
            }

            if(newIndex>currentIndex){
                console.log("slide out right");
            }

            sections[newIndex].style.display = "block";


            navItems[newIndex].classList.add("selected");
        }


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


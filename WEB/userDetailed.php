<?php
    require_once "../BACKEND/databaseFunctions.php";

    $data = GetUser($_SESSION['user_id'])[0];
    $borrowed_books = GetBorrowedBooks($_SESSION["user_id"]);
    $previously_borrowed_books = GetPreviouslyBorrowedBooks($_SESSION["user_id"]);  
    
    $booked_and_reserved_books = GetBookedAndReservedBooks($_SESSION["user_id"]);
    $books_on_shelf = get_books_from_users_shelf($_SESSION["user_id"]);

    $booked_books = [];
    $reserved_books = [];

    foreach ($booked_and_reserved_books as $key => $booked_or_reserved_books_data){
        if($booked_or_reserved_books_data["status"] == "booking"){
            $booked_books[] = $booked_or_reserved_books_data;
        }else{
            $reserved_books[] = $booked_or_reserved_books_data;
        }
    }



?>
<main class="container">
    <div class="sidebar">
        <div class="indicator"></div>
        <div class="nav-item selected" id="nav-account-details" data-link="adatok" onclick="showSection(this); SetUrlToOpenSection(this);">
            Fiók <span>adatai</span> 
            <!-- <span class="indicator"></span> -->
        </div>
        <div class="nav-item" id="nav-reserved-books" data-link="elojegyzett" onclick="showSection(this); SetUrlToOpenSection(this);">
            Előjegyzett <span>könyvek</span> 
            <!-- <span class="indicator"></span> -->
        </div>
        <div class="nav-item" id="nav-booked-books" data-link="lefoglalt" onclick="showSection(this); SetUrlToOpenSection(this);">
            Lefoglalt <span>könyvek</span> 
            <!-- <span class="indicator"></span> -->
        </div>
        <div class="nav-item" id="nav-borrowed-books" data-link="kivett" onclick="showSection(this); SetUrlToOpenSection(this);">
            Jelenleg kivett <span>könyvek</span> 
            <!-- <span class="indicator"></span> -->
        </div>
        <div class="nav-item" id="nav-previously-borrowed-books" data-link="korabban_kivett" onclick="showSection(this); SetUrlToOpenSection(this);">
            Korábban kivett <span>könyvek</span> 
            <!-- <span class="indicator"></span> -->
        </div>
        <div class="nav-item" id="nav-books-on-shelf" data-link="polc" onclick="showSection(this); SetUrlToOpenSection(this);">
            Könyves polc 
            <!-- <span class="indicator"></span> -->
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
                <div class="change-password-holder">
                    <div class="inputbox">
                        <img src="/web/imgs/eye-off-line.png" id="eyeicon" onclick="TogglePasswordVisibility(this, 'currentPassword');" alt="Toggle Password Visibility">
                        <input type="password" placeholder=" " id="currentPassword" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
                        <span for="currentPassword">Jelenlegi jelszó:</span>
                        <i></i>
                    </div>
                    <div class="inputbox">
                        <img src="/web/imgs/eye-off-line.png" id="eyeicon" onclick="TogglePasswordVisibility(this, 'newPassword');" alt="Toggle Password Visibility">
                        <input type="password" placeholder=" " id="newPassword" oninput="ValidatePassword(this.value);" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
                        <span for="newPassword">Új jelszó:</span>
                        <i></i>
                    </div>
                    <?php require("new_password_error_messages.html");?>

                    <div class="inputbox">
                        <input type="password" placeholder=" " id="newPasswordAgain" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'changePasswordButton');">
                        <span for="newPasswordAgain">Új jelszó újra:</span>
                        <i></i>
                    </div>
                    <input type="button" id="changePasswordButton" value="Módosítás" onclick="ChangePassword();">
                    
                </div>
                <div class="logout-container">
                    <button id="logoutButton" onclick="Kijelentkezés();">Kijelentkezés</button>
                </div>
            </div>
        </div>

        <div class="section" id="reserved-books">
            <?php if(count($reserved_books) > 0): ?>
                <h3>Előjegyzett könyvek</h3>
                <?php foreach ($reserved_books as $reserved_books_data): ?>
                    <div class="book-item">
                        <div class="book-details_container">
                            <a href="/web/konyveink/<?= $reserved_books_data['ISBN'] ?>"><?= $reserved_books_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $reserved_books_data['authors']) ?></span>
                        </div>

                        <div class="button_container">
                            <button class="book_action_button" onclick="CancelReservationOrBooking('cancelReservation', this)" data-id="<?= $reserved_books_data['id'] ?>">Lemondás</button>
                        </div>
                        
                    </div>
                <?php endforeach; ?>
            <?php else: ?>
                <p>Nincs előjegyzett könyve!</p>
            <?php endif; ?>
        </div>

        <div class="section" id="booked-books">
            <?php if(count($booked_books) > 0): ?>
                <h3>Lefoglalt könyvek</h3>
                <?php foreach ($booked_books as $booked_books_data): ?>
                    <div class="book-item">
                        <div class="book-details_container">
                            <a href="/web/konyveink/<?= $booked_books_data['ISBN'] ?>"><?= $booked_books_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $booked_books_data['authors']) ?></span>
                            <span class="return-date"><?= $booked_books_data['end_date'] ?></span>
                        </div>

                        <div class="button_container">
                            <button class="book_action_button" onclick="CancelReservationOrBooking('cancelBooking', this)" data-id="<?= $booked_books_data['id'] ?>">Lemondás</button>
                        </div>
                        
                    </div>
                <?php endforeach; ?>
            <?php else: ?>
                <p>Nincs lefoglalt könyve!</p>

            <?php endif; ?>
        </div>

        <div class="section" id="borrowed-books">
            <?php if(count($borrowed_books) > 0): ?>
                <h3>Jelenlegi kivett könyvek</h3>
                <?php foreach ($borrowed_books as $borrowed_book_data): ?>
                    <div class="book-item">
                        <div class="book-details_container">
                            <a href="/web/konyveink/<?= $borrowed_book_data['ISBN'] ?>"><?= $borrowed_book_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $borrowed_book_data['authors']) ?></span>
                            <span class="return-date"><?= $borrowed_book_data['end_date'] ?></span>
                        </div>

                        <?php if(IsItExtendable($_SESSION["user_id"], $borrowed_book_data["book_id"])):?>
                            <div class="button_container">
                                <button class="book_action_button" data-book-id="<?= $borrowed_book_data['book_id'] ?>" onclick="Meghosszabbitas(this)">Meghosszabbítás</button>
                            </div>
                        <?php endif; ?>
                    </div>
                <?php endforeach; ?>

            <?php else: ?>
                <p>Nincs kivett könyve!</p>
            <?php endif; ?>
        </div>

        <div class="section" id="previously-borrowed-books">
            <?php if(count($previously_borrowed_books) > 0): ?>
                <h3>Korábban kivett könyvek</h3>
                <?php foreach ($previously_borrowed_books as $previously_borrowed_book_data): ?>
                    <div class="book-item">
                        <div class="book-details_container">
                            <a href="/web/konyveink/<?= $previously_borrowed_book_data['ISBN'] ?>"><?= $previously_borrowed_book_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $previously_borrowed_book_data['authors']) ?></span>
                            <span class="return-date"><?= $previously_borrowed_book_data['end_date'] ?></span>
                        </div>

                    </div>
                <?php endforeach; ?>
            <?php else: ?>
                <p>Még nem hozott vissza könyvet!</p>
            <?php endif; ?>
        </div>

        <div class="section" id="books-on-shelf">
            <?php if(count($books_on_shelf) > 0): ?>
                <h3>Polcon levő könyvek</h3>
                <?php foreach ($books_on_shelf as $book_data): ?>
                    <div class="book-item">
                        <div class="book-details_container">
                            <a href="/web/konyveink/<?= $book_data['ISBN'] ?>"><?= $book_data['title'] ?></a>
                            <span class="book-author"><?= str_replace(",", ", ", $book_data['authors']) ?></span>
                        </div>
                    </div>
                <?php endforeach;?>

            <?php else: ?>
                <p>Még nem tett könyvet a polcára! A könyvek részletes oldalán tud hozzáadni egy könyvet!</p>
            <?php endif; ?>
        </div>

        
    </div>
</main>

<script defer src="/web/userDetailed.js"></script>
<script defer src="/web/passwordValidation.js"></script>


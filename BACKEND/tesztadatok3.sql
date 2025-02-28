INSERT INTO languages (lang_id, lang) VALUES
(1, 'magyar'),
(2, 'angol'),
(3, 'német');

INSERT INTO publishers (publisher_id, name, phone, email, webpage) VALUES
(1, 'Fapadoskonyv.hu', '+36 1 234 5678', 'info@fapadoskonyv.hu', 'https://fapadoskonyv.hu'),
(2, 'Európa Kiadó', '+36 1 876 5432', 'info@europakiado.hu', 'https://europakiado.hu'),
(3, 'Libri', '+36 1 345 6789', 'info@libri.hu', 'https://libri.hu');

INSERT INTO book (ISBN_id, ISBN, title, publisher_id, release_date, lang_id, description, picture_base64) VALUES
(1, '9789633743140', 'A szépirodalom műfajai', 1, '2011-01-01', 1, 'Hegedüs Géza könyve útmutatást nyújt az irodalmi műfajok sokszínű világában.', NULL),
(2, '9789634059646', 'A Mester és Margarita', 2, '1967-01-01', 1, 'Mihail Bulgakov klasszikus regénye, amelyben a sátán Moszkvába érkezik.', NULL),
(3, '9789633102213', '1984', 3, '1949-06-08', 2, 'George Orwell disztópikus regénye a totalitárius társadalomról.', NULL),
(4, '9789632664651', 'Szép új világ', 3, '1932-01-01', 1, 'Aldous Huxley híres disztópiája egy jövőbeli társadalomról.', NULL),
(5, '9789633550472', 'Fahrenheit 451', 3, '1953-10-19', 2, 'Ray Bradbury klasszikus sci-fi regénye a könyvek üldöztetéséről.', NULL),
(6, '9789631438994', 'Tizenegyes állomás', 2, '2014-09-09', 1, 'Emily St. John Mandel posztapokaliptikus regénye a túlélésről és a művészet szerepéről.', NULL),
(7, '9789630798297', 'A szolgálólány meséje', 2, '1985-04-01', 1, 'Margaret Atwood disztópikus regénye egy elnyomó jövőbeli társadalomról.', NULL),
(8, '9789632275437', 'Az alkimista', 3, '1988-01-01', 1, 'Paulo Coelho világhírű regénye az önmegvalósításról.', NULL),
(9, '9789634790792', 'A kis herceg', 2, '1943-04-06', 1, 'Antoine de Saint-Exupéry klasszikus meséje.', NULL),
(10, '9789635051233', 'Az ember tragédiája', 1, '1861-01-01', 1, 'Madách Imre drámai költeménye az emberi lét értelméről.', NULL),
(11, '9789634792756', 'Bűn és bűnhődés', 2, '1866-01-01', 1, 'Fjodor Mihajlovics Dosztojevszkij regénye egy gyilkos lelkiismeretéről.', NULL),
(12, '9789634190782', 'Don Quijote', 3, '1605-01-01', 1, 'Miguel de Cervantes klasszikus regénye az álmodozó lovagról.', NULL),
(13, '9789634382711', 'Háború és béke', 2, '1869-01-01', 1, 'Lev Tolsztoj monumentális történelmi regénye.', NULL),
(14, '9789634863219', 'A varázshegy', 3, '1924-01-01', 1, 'Thomas Mann híres regénye az idő természetéről.', NULL),
(15, '9789636765124', 'A gyűrűk ura', 1, '1954-07-29', 1, 'J.R.R. Tolkien epikus fantasy trilógiája.', NULL),
(16, '9789632276321', 'Harry Potter és a bölcsek köve', 2, '1997-06-26', 1, 'J.K. Rowling mágikus története egy ifjú varázslóról.', NULL),
(17, '9789634792677', 'Az éhezők viadala', 3, '2008-09-14', 1, 'Suzanne Collins disztópikus regénye egy túlélőversenyről.', NULL),
(18, '9789634475212', 'Dűne', 1, '1965-08-01', 1, 'Frank Herbert sci-fi klasszikusa egy sivatagi bolygóról.', NULL),
(19, '9789634447812', 'Görög mitológia', 2, '1955-01-01', 1, 'Robert Graves történelmi munkája az ókori mítoszokról.', NULL),
(20, '9789634560987', 'Shakespeare összes művei', 3, '1623-01-01', 1, 'William Shakespeare drámáinak gyűjteménye.', NULL),
(21, '9789633578902', 'Frankenstein', 1, '1818-01-01', 1, 'Mary Shelley klasszikus gótikus regénye.', NULL),
(22, '9789633467129', 'Drakula', 2, '1897-05-26', 1, 'Bram Stoker híres vámpírregénye.', NULL),
(23, '9789633456783', 'A hobbit', 3, '1937-09-21', 1, 'J.R.R. Tolkien kalandos fantasy története.', NULL),
(24, '9789633987652', 'A Végtelen Történet', 1, '1979-01-01', 1, 'Michael Ende mágikus regénye.', NULL),
(25, '9789633498765', 'Alice Csodaországban', 2, '1865-11-26', 1, 'Lewis Carroll híres gyermekregénye.', NULL);

INSERT INTO books_genres_conn (ISBN_id, genre_id) VALUES
(21, 4), (22, 4), (23, 4), (24, 4), (25, 7);

INSERT INTO books_authors_conn (ISBN_id, author_id) VALUES
(21, 21), (22, 22), (23, 23), (24, 24), (25, 25);


INSERT INTO users (surname, first_name, username, birth_date, membership_end_date, email, phone_number, password, birth_place, address, mother_maiden_name, active) VALUES
('Horti-Nagy', 'Bálint', 'hoba123', '1985-03-15', '2025-03-15', 'hortibalint@gmail.com', '06123456789', PASSWORD('Boronkay01?'), 'Budapest', '123 Main St', 'Nagy Erzsebet', TRUE),
('Bátyi', 'Bence', 'babe123', '1999-10-12', '2025-10-15', 'babence04@gmail.com', '06302166102', PASSWORD('Boronkay01?'), 'Vac', '123 Vaci St', 'Kipuf Ogo', TRUE),
('Szabo', 'Anna', 'szan123', '1990-10-22', '2025-10-22', 'anna.szabo@example.com', '06789123456', PASSWORD('Boronkay01?'), 'Debrecen', '456 High St', 'Kiss Julia', TRUE);

INSERT INTO inventory (ISBN_id, book_id,available) VALUES
(1,1,TRUE),(2,2,TRUE),(3,3,TRUE),(4,4,TRUE),(5,5,TRUE),(6,6,TRUE),(7,7,TRUE),(8,8,TRUE),(9,9,TRUE),(10,10,TRUE),(11,11,TRUE),(12,12,TRUE),(13,13,TRUE),(14,14,TRUE),(15,15,TRUE),(16,16,TRUE),(17,17,TRUE),(18,18,TRUE),(19,19,TRUE),(20,20,TRUE),(21,21,TRUE),(22,22,TRUE),(23,23,TRUE),(24,24,TRUE),(25,25,TRUE);

INSERT INTO employees (empl_name, empl_uname, password, active, admin) VALUES
('Bátyi Bence', 'AABBC', '*2470C0C06DEE42FD1618BB99005ADCA2EC9D1E19', 1, 1),
('Nagy Laszlo', 'BBCCD', '*2470C0C06DEE42FD1618BB99005ADCA2EC9D1E19', 1, 1);

INSERT INTO reservation (ISBN_id, user_id) VALUES
(1, 1),
(2, 1),
(3, 1),
(1, 3),
(2, 2),
(3, 2);

INSERT INTO booking (book_id, user_id, end_date) VALUES
(1, 2, '2025-02-01'),
(2, 2, '2025-02-01'),
(4, 3, '2025-02-01'),
(5, 3, '2025-02-01'),
(6, 1, '2025-02-15');

INSERT INTO borrowings (book_id, user_id, empl_e, start_date, end_date, returned) VALUES
(1, 1, 1, '2024-01-01', '2024-01-16', 1),
(1, 1, 1, '2024-02-01', '2024-02-16', 1),
(2, 1, 1, '2024-02-01', '2024-02-16', 1),

(3, 1, 1, '2024-02-03', '2025-02-18', 0),
(4, 1, 1, '2024-10-01', '2024-10-16', 1),
(5, 1, 1, '2024-01-01', '2024-01-16', 1),
(6, 1, 1, '2024-01-01', '2024-01-16', 1),
(7, 1, 1, '2024-02-01', '2024-02-16', 0),
(8, 1, 1, '2024-01-01', '2024-01-16', 0),
(9, 1, 1, '2024-01-01', '2024-01-16', 0),
(10, 1, 1, '2024-03-01', '2024-03-16', 1),
(11, 1, 1, '2024-01-01', '2024-01-16', 1),

(2, 2, 2, '2024-02-01', '2024-02-16', 1);

INSERT INTO system_settings (membership_fee, borrowing_time, lengthening_time, reservation_time, max_reservations, max_lengthenings, latency_fee, reset_token_expiration, login_token_expiration) VALUES
(1000, 30, 15, 10, 5, 2, 500, 24, 30);
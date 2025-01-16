-- Adatok beszúrása a languages táblába
INSERT INTO languages (lang) VALUES
('Magyar'),
('Angol'),
('Német'),
('Francia'),
('Japán');

-- Adatok beszúrása a publishers táblába
INSERT INTO publishers (name, phone, email, webpage) VALUES
('Kossuth Kiadó', '123-456-7890', 'info@kossuth.hu', 'https://www.kossuth.hu'),
('Libri Kiadó', '987-654-3210', 'kapcsolat@libri.hu', 'https://www.libri.hu'),
('Alexandra Kiadó', '555-123-4567', 'ugyfelszolgalat@alexandra.hu', 'https://www.alexandra.hu'),
('Helikon Kiadó', '444-987-1234', 'info@helikon.hu', 'https://www.helikon.hu'),
('Animus Kiadó', '333-555-9876', 'kapcsolat@animus.hu', 'https://www.animus.hu');

-- Adatok beszúrása a genres táblába
INSERT INTO genres (genre) VALUES
('Regény'),
('Tudományos'),
('Sci-fi'),
('Fantasy'),
('Krimi'),
('Romantikus'),
('Horror'),
('Életrajz');

-- Adatok beszúrása az authors táblába
INSERT INTO authors (author) VALUES
('J.K. Rowling'),
('George R.R. Martin'),
('Agatha Christie'),
('Stephen King'),
('Isaac Asimov'),
('Jane Austen'),
('Mark Twain'),
('Ernest Hemingway');

-- Adatok beszúrása a book táblába
INSERT INTO book (ISBN, title, publisher_id, release_date, lang_id, description, picture_base64) VALUES
('9781234567897', 'Book One', 1, '2020-01-15', 1, 'A compelling fictional story.', "https://unsplash.it/300/450"),
('9789876543210', 'Book Two', 2, '2019-07-23', 2, 'An insightful non-fiction book.', "https://unsplash.it/300/450"),
('9785556667778', 'Book Three', 3, '2021-03-05', 3, 'An epic science fiction novel.', "https://unsplash.it/300/450"),
('9784445556667', 'Book Four', 4, '2022-10-12', 4, 'A captivating fantasy tale.', "https://unsplash.it/300/450"),
('9783334445556', 'Book Five', 5, '2018-05-19', 5, 'A thrilling mystery novel.', "https://unsplash.it/300/450"),
('9781111111111', 'Book Six', 2, '2023-01-20', 1, 'A romantic tale that spans continents.', "https://unsplash.it/300/450"),
('9782222222222', 'Book Seven', 4, '2021-09-10', 4, 'A horror novel that keeps you awake at night.', "https://unsplash.it/300/450"),
('9783333333333', 'Book Eight', 1, '2020-06-15', 2, 'A biography of a great historical figure.', "https://unsplash.it/300/450"),
('9784444444444', 'Book Nine', 3, '2019-11-22', 3, 'A science fiction masterpiece about AI.', "https://unsplash.it/300/450"),
('9785555555555', 'Book Ten', 5, '2022-04-05', 5, 'An adventure fantasy set in a magical land.', "https://unsplash.it/300/450"),
('9786666666666', 'Book Eleven', 2, '2018-02-12', 1, 'A thrilling mystery full of twists.', "https://unsplash.it/300/450"),
('9787777777777', 'Book Twelve', 4, '2023-08-18', 3, 'A gripping non-fiction book about space exploration.', "https://unsplash.it/300/450"),
('9788888888888', 'Book Thirteen', 5, '2021-03-29', 4, 'A romance novel filled with heartfelt moments.', "https://unsplash.it/300/450"),
('9789999999999', 'Book Fourteen', 3, '2020-12-10', 2, 'A chilling horror story with supernatural elements.', "https://unsplash.it/300/450"),
('9781010101010', 'Book Fifteen', 1, '2022-07-14', 5, 'A biography of a renowned scientist.', "https://unsplash.it/300/450"),

('9781234567887', 'Első könyv', 1, '2020-01-15', 1, 'Egy lebilincselő regény.', "https://unsplash.it/300/450"),
('9789876541210', 'Második könyv', 2, '2019-07-23', 2, 'Egy gondolatébresztő tudományos könyv.', "https://unsplash.it/300/450"),
('9785556667770', 'Harmadik könyv', 3, '2021-03-05', 3, 'Egy epikus sci-fi történet.', "https://unsplash.it/300/450"),
('2784445556667', 'Negyedik könyv', 4, '2022-10-12', 4, 'Egy lenyűgöző fantasy kaland.', "https://unsplash.it/300/450"),
('9783334445552', 'Ötödik könyv', 5, '2018-05-19', 5, 'Egy izgalmas krimi regény.', "https://unsplash.it/300/450"),
('9781111131111', 'Hatodik könyv', 2, '2023-01-20', 1, 'Egy romantikus történet kontinenseken át.', "https://unsplash.it/300/450"),
('9782222122222', 'Hetedik könyv', 4, '2021-09-10', 4, 'Egy horror történet, ami ébren tart.', "https://unsplash.it/300/450"),
('9783343333333', 'Nyolcadik könyv', 1, '2020-06-15', 2, 'Egy híres történelmi alak életrajza.', "https://unsplash.it/300/450"),
('9784444344444', 'Kilencedik könyv', 3, '2019-11-22', 3, 'Egy sci-fi remekmű a mesterséges intelligenciáról.', "https://unsplash.it/300/450"),
('9785552555555', 'Tizedik könyv', 5, '2022-04-05', 5, 'Egy kalandos fantasy egy varázslatos világban.', "https://unsplash.it/300/450");


-- Adatok beszúrása a books_genres_conn táblába
INSERT INTO books_genres_conn (ISBN_id, genre_id) VALUES
(1, 1), -- Regény
(1, 2),
(1, 3),
(2, 2), -- Tudományos
(3, 3), -- Sci-fi
(4, 4), -- Fantasy
(5, 5), -- Krimi
(6, 6), -- Romantikus
(7, 7), -- Horror
(8, 8), -- Életrajz
(9, 3), -- Sci-fi
(10, 4),
(11, 2),
(12, 2),
(13, 2),
(14, 2),
(15, 2),
(16, 2),
(17, 2),
(18, 2),
(19, 2),
(20, 2),
(21, 2),
(22, 2),
(23, 2),
(24, 2),
(25, 2);

-- Adatok beszúrása a books_authors_conn táblába
INSERT INTO books_authors_conn (ISBN_id, author_id) VALUES
(1, 1), -- J.K. Rowling
(2, 6), -- Jane Austen
(3, 5), -- Isaac Asimov
(4, 2), -- George R.R. Martin
(5, 3), -- Agatha Christie
(6, 7), -- Mark Twain
(7, 4), -- Stephen King
(8, 6), -- Jane Austen
(9, 5), -- Isaac Asimov
(10, 2),
(10, 3),
(10, 4),
(10, 5),
(10, 6),
(11, 2),
(12, 2),
(13, 2),
(14, 2),
(15, 2),
(16, 2),
(17, 2),
(18, 2),
(19, 2),
(20, 2),
(21, 2),
(22, 2),
(23, 2),
(24, 2),
(25, 2); -- George R.R. Martin


INSERT INTO system_settings (membership_fee, borrowing_time, lengthening_time, reservation_time, max_reservations, max_lengthenings, latency_fee) VALUES
(1000, 30, 15, 10, 5, 2, 500);


INSERT INTO users (surname, first_name, username, birth_date, membership_end_date, email, phone_number, password, birth_place, address, mother_maiden_name, active) VALUES
('Kovács', 'János', '7584937648', '1985-03-15', '2025-03-15', 'janos.kovacs@example.com', '06123456789', 'password', 'Budapest', '123 Main St', 'Nagy Erzsébet', TRUE),
('K.', 'Anna', '0123456789', '1999-10-12', '2025-10-15', 'k.anna@gmail.com', '06302166102', 'password', 'Vác', '123 Váci St', 'Kipuf Ogó', TRUE),
('Szabó', 'Anna', '6453957465', '1990-10-22', '2025-10-22', 'anna.szabo@example.com', '06789123456', 'password', 'Debrecen', '456 High St', 'Kiss Júlia', TRUE);

INSERT INTO inventory (ISBN_id, book_id,available) VALUES
(1,1,TRUE),(2,2,TRUE),(3,3,TRUE),(4,4,TRUE),(5,5,TRUE),(6,6,TRUE),(7,7,TRUE),(8,8,TRUE),(9,9,TRUE),(10,10,TRUE),(11,11,TRUE),(12,12,TRUE),(13,13,TRUE),(14,14,TRUE),(15,15,TRUE),(16,16,TRUE),(17,17,TRUE),(18,18,TRUE),(19,19,TRUE),(20,20,TRUE),(21,21,TRUE),(22,22,TRUE),(23,23,TRUE),(24,24,TRUE),(25,25,TRUE);

INSERT INTO employees (empl_name, empl_uname, password) VALUES
('Tóth Péter', 'AABBC', '*2470C0C06DEE42FD1618BB99005ADCA2EC9D1E19'),
('Nagy László', 'BBCCD', '*2470C0C06DEE42FD1618BB99005ADCA2EC9D1E19');

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
(3, 3, '2025-02-01'),
(4, 3, '2025-02-01'),
(5, 3, '2025-02-01'),
(6, 1, '2025-02-15');

INSERT INTO borrowings (book_id, user_id, empl_e, start_date, end_date, returned) VALUES
(1, 1, 1, '2024-01-01', '2024-01-16', 1),
(1, 1, 1, '2024-02-01', '2024-02-16', 1),

(3, 1, 1, '2024-02-03', '2024-02-18', 0),
(4, 1, 1, '2024-10-01', '2024-10-16', 0),
(5, 1, 1, '2024-01-01', '2024-01-16', 0),
(6, 1, 1, '2024-01-01', '2024-01-16', 0),
(7, 1, 1, '2024-02-01', '2024-02-16', 0),
(8, 1, 1, '2024-01-01', '2024-01-16', 0),
(9, 1, 1, '2024-01-01', '2024-01-16', 0),
(10, 1, 1, '2024-03-01', '2024-03-16', 1),
(11, 1, 1, '2024-01-01', '2024-01-16', 1),

(2, 2, 2, '2024-02-01', '2024-02-16', 1);
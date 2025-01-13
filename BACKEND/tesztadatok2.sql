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

('9781234567897', 'Első könyv', 1, '2020-01-15', 1, 'Egy lebilincselő regény.', "https://unsplash.it/300/450"),
('9789876543210', 'Második könyv', 2, '2019-07-23', 2, 'Egy gondolatébresztő tudományos könyv.', "https://unsplash.it/300/450"),
('9785556667778', 'Harmadik könyv', 3, '2021-03-05', 3, 'Egy epikus sci-fi történet.', "https://unsplash.it/300/450"),
('9784445556667', 'Negyedik könyv', 4, '2022-10-12', 4, 'Egy lenyűgöző fantasy kaland.', "https://unsplash.it/300/450"),
('9783334445556', 'Ötödik könyv', 5, '2018-05-19', 5, 'Egy izgalmas krimi regény.', "https://unsplash.it/300/450"),
('9781111111111', 'Hatodik könyv', 2, '2023-01-20', 1, 'Egy romantikus történet kontinenseken át.', "https://unsplash.it/300/450"),
('9782222222222', 'Hetedik könyv', 4, '2021-09-10', 4, 'Egy horror történet, ami ébren tart.', "https://unsplash.it/300/450"),
('9783333333333', 'Nyolcadik könyv', 1, '2020-06-15', 2, 'Egy híres történelmi alak életrajza.', "https://unsplash.it/300/450"),
('9784444444444', 'Kilencedik könyv', 3, '2019-11-22', 3, 'Egy sci-fi remekmű a mesterséges intelligenciáról.', "https://unsplash.it/300/450"),
('9785555555555', 'Tizedik könyv', 5, '2022-04-05', 5, 'Egy kalandos fantasy egy varázslatos világban.', "https://unsplash.it/300/450");


-- Adatok beszúrása a books_genres_conn táblába
INSERT INTO books_genres_conn (ISBN_id, genre_id) VALUES
(1, 1), -- Regény
(2, 2), -- Tudományos
(3, 3), -- Sci-fi
(4, 4), -- Fantasy
(5, 5), -- Krimi
(6, 6), -- Romantikus
(7, 7), -- Horror
(8, 8), -- Életrajz
(9, 3), -- Sci-fi
(10, 4); -- Fantasy

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
(10, 2); -- George R.R. Martin


INSERT INTO system_settings (membership_fee, borrowing_time, lengthening_time, reservation_time, max_reservations, max_lengthenings, latency_fee) VALUES
(1000, 30, 15, 10, 5, 2, 500);


INSERT INTO users (surname, first_name, username, birth_date, membership_end_date, email, phone_number, password, birth_place, address, mother_maiden_name, active) VALUES
('Kovács', 'János', '7584937648', '1985-03-15', '2025-03-15', 'janos.kovacs@example.com', '06123456789', 'password', 'Budapest', '123 Main St', 'Nagy Erzsébet', TRUE),
('Szabó', 'Anna', '6453957465', '1990-10-22', '2025-10-22', 'anna.szabo@example.com', '06789123456', 'password', 'Debrecen', '456 High St', 'Kiss Júlia', TRUE);

INSERT INTO inventory (ISBN_id, available) VALUES
(1, TRUE),
(1, TRUE),
(1, TRUE),
(1, TRUE),
(1, TRUE),
(1, TRUE),
(3, TRUE),
(1, TRUE),
(1, TRUE),
(6, TRUE),
(1, TRUE),
(1, TRUE),
(1, TRUE),
(1, TRUE),
(4, TRUE),
(1, TRUE),
(1, TRUE),
(1, TRUE),
(1, TRUE),
(5, TRUE),
(1, TRUE),
(7, TRUE),

(2, TRUE),
(1,TRUE),(2,TRUE),(3,TRUE),(4,TRUE),(5,TRUE),(6,TRUE),(7,TRUE),(8,TRUE),(9,TRUE),(10,TRUE),(11,TRUE),(12,TRUE),(13,TRUE),(14,TRUE),(15,TRUE),(16,TRUE),(17,TRUE),(18,TRUE),(19,TRUE),(20,TRUE),(21,TRUE),(22,TRUE),(23,TRUE),(24,TRUE),(25,TRUE)
;
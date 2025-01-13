INSERT INTO publishers (name, phone, email, webpage) VALUES
('Book Publishing Co.', '123-456-7890', 'contact@bookpub.com', 'www.bookpub.com'),
('Novel House', '987-654-3210', 'info@novelhouse.com', 'www.novelhouse.com');

INSERT INTO languages (lang) VALUES
('Hungarian'),
('English'),
('German');

INSERT INTO book (ISBN, title, publisher_id, release_date, lang_id, description, picture_base64) VALUES
('9783161484100', 'Learning SQL', 1, '2020-08-15', 2, 'A guide to learning SQL', "https://unsplash.it/300/450"),
('9783161484201', 'Mastering Databases', 2, '2019-05-21', 1, 'Comprehensive guide to databases', "https://unsplash.it/300/450");

INSERT INTO genres (genre) VALUES
('Science Fiction'),
('Fantasy'),
('Non-fiction');

INSERT INTO authors (author) VALUES
('John Doe'),
('Jane Smith'),
('Mark Johnson');

INSERT INTO books_genres_conn (ISBN_id, genre_id) VALUES
(1, 1),
(2, 3);

INSERT INTO books_authors_conn (ISBN_id, author_id) VALUES
(1, 1),
(1, 3),
(2, 2);

INSERT INTO inventory (ISBN_id, available) VALUES
(1, TRUE),
(2, FALSE);

INSERT INTO users (surname, first_name, username, birth_date, membership_end_date, email, phone_number, password, birth_place, address, mother_maiden_name, active) VALUES
('Kovács', 'János', '7584937648', '1985-03-15', '2025-03-15', 'janos.kovacs@example.com', '06123456789', 'password', 'Budapest', '123 Main St', 'Nagy Erzsébet', TRUE),
('Szabó', 'Anna', '6453957465', '1990-10-22', '2025-10-22', 'anna.szabo@example.com', '06789123456', 'password', 'Debrecen', '456 High St', 'Kiss Júlia', TRUE);

INSERT INTO reservation (ISBN_id, user_id) VALUES
(1, 1),
(2, 2);

INSERT INTO employees (empl_name, empl_uname, password) VALUES
('Tóth Péter', 'AABBC', 'password'),
('Nagy László', 'BBCCD', 'password');

INSERT INTO borrowings (book_id, user_id, empl_e, start_date, end_date, returned) VALUES
(1, 1, 1, '2024-01-01', '2024-01-15', 1),
(2, 2, 2, '2024-02-01', '2024-02-15', 1);

INSERT INTO booking (book_id, user_id, end_date) VALUES
(1, 1, '2024-03-01'),
(2, 2, '2024-03-15');

INSERT INTO votes (author, book_title) VALUES
('John Doe', 'Learning SQL'),
('Jane Smith', 'Mastering Databases');

INSERT INTO users_votes_conn (user_id, vote_id) VALUES
(1, 1),
(2, 2);

INSERT INTO system_settings (membership_fee, borrowing_time, lengthening_time, reservation_time, max_reservations, max_lengthenings, latency_fee) VALUES
(1000, 30, 15, 10, 5, 2, 500);


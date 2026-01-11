USE library;
DROP PROCEDURE IF EXISTS P_login;
DROP PROCEDURE IF EXISTS SP_addbooks;
DROP PROCEDURE IF EXISTS ViewBooks;
DROP PROCEDURE IF EXISTS sp_addStudents;
DROP PROCEDURE IF EXISTS ViewStudents;
DROP PROCEDURE IF EXISTS sp_getbooks;
DROP PROCEDURE IF EXISTS sp_addissuebook;
DROP PROCEDURE IF EXISTS ViewIssueBook;
DROP PROCEDURE IF EXISTS Updateissuebook;
DROP PROCEDURE IF EXISTS ViewBookReport;
DROP TABLE IF EXISTS issue_book;
DROP TABLE IF EXISTS students;
DROP TABLE IF EXISTS tbl_books;
DROP TABLE IF EXISTS login;


create table login (
usernameID INT AUTO_INCREMENT primary key,
username varchar(60),
password varchar(60)
);

CREATE TABLE tbl_books (
    BookID INT AUTO_INCREMENT PRIMARY KEY,
    BookName VARCHAR(60),
    BookQuantity VARCHAR(60),
    PurchaseDate varchar(60)
);

CREATE TABLE students (
    studentname VARCHAR(60),
    KTP VARCHAR(60) primary key,
    Address VARCHAR(60),
    ContactNumber VARCHAR(60)
);

CREATE TABLE issue_book (
    Issue_ID INT AUTO_INCREMENT PRIMARY KEY,
    Student_Name VARCHAR(60),
    KTP VARCHAR(60),
    Address VARCHAR(60),
    ContactNumber VARCHAR(60),
    BookName VARCHAR(60),
    IssueDate varchar(60),
    ReturnDate varchar(60),
    BookID int,
    usernameID int,
    CONSTRAINT fk_issue_student
        FOREIGN KEY (KTP) REFERENCES students(KTP),
	CONSTRAINT fk_issue_tbl_books
        FOREIGN KEY (BookID) REFERENCES tbl_books(BookID),
	CONSTRAINT fk_issue_login
        FOREIGN KEY (usernameID) REFERENCES login(usernameID)
);

insert into login(usernameid,username,password) values
(001,'ken',123);

select * from login;
select* from tbl_books;
select* from students;
select*from issue_book;

DELIMITER $$

CREATE FUNCTION fn_login(
    p_username VARCHAR(60),
    p_password VARCHAR(60)
)
RETURNS INT
DETERMINISTIC
BEGIN
    DECLARE v_userid INT;

    SELECT usernameID
    INTO v_userid
    FROM login
    WHERE username = p_username
      AND password = p_password
    LIMIT 1;

    RETURN v_userid;
END$$

DELIMITER ;


DELIMITER $$

CREATE PROCEDURE SP_addbooks (
    IN p_BookName VARCHAR(60),
    IN p_BookQuantity VARCHAR(60),
    IN p_PurchaseDate varchar(60)
)
BEGIN
    INSERT INTO tbl_books (
        BookName,
        BookQuantity,
        PurchaseDate
    )
    VALUES (
        p_BookName,
        p_BookQuantity,
        p_PurchaseDate
    );
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE ViewBooks(
    IN p_BookName VARCHAR(60)
)
BEGIN
    IF p_BookName = '' OR p_BookName IS NULL THEN
        SELECT * FROM tbl_books;
    ELSE
        SELECT * 
        FROM tbl_books 
        WHERE BookName = p_BookName;
    END IF;
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE sp_addStudents (
    IN p_studentname VARCHAR(60),
    IN p_ktp VARCHAR(60),
    IN p_address VARCHAR(60),
    IN p_contactnumber VARCHAR(60)
)
BEGIN
    INSERT INTO students (
        studentname,
        KTP,
        Address,
        ContactNumber
    )
    VALUES (
        p_studentname,
        p_ktp,
        p_address,
        p_contactnumber
    );
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE ViewStudents(
    IN p_ktp VARCHAR(60)
)
BEGIN
    IF p_ktp = '' OR p_ktp IS NULL THEN
        SELECT * FROM students;
    ELSE
        SELECT * 
        FROM students 
        WHERE KTP = p_ktp;
    END IF;
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE sp_getbooks()
BEGIN
    SELECT BookName,BookID FROM tbl_books;
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE sp_addissuebook (
    IN p_Student_Name VARCHAR(60),
    IN p_KTP VARCHAR(60),
    IN p_Address VARCHAR(60),
    IN p_ContactNumber VARCHAR(60),
    IN p_BookName VARCHAR(60),
    IN p_IssueDate VARCHAR(60),
    IN p_ReturnDate VARCHAR(60),
    IN p_BookID VARCHAR(60),
    IN p_usernameID VARCHAR(60)
)
BEGIN
    -- Cek stok buku dulu
    IF EXISTS (
        SELECT 1 
        FROM tbl_books 
        WHERE BookName = p_BookName 
          AND BookQuantity > 0
    ) THEN

        -- Insert ke issue_book
        INSERT INTO issue_book (
            Student_Name,
            KTP,
            Address,
            ContactNumber,
            BookName,
            IssueDate,
            ReturnDate,
            BookID,
            usernameID
        )
        VALUES (
            p_Student_Name,
            p_KTP,
            p_Address,
            p_ContactNumber,
            p_BookName,
            p_IssueDate,
            p_ReturnDate,
            p_BookID,
            p_usernameID
        );

        -- Kurangi stok buku 1
        UPDATE tbl_books
        SET BookQuantity = BookQuantity - 1
        WHERE BookName = p_BookName;

    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Book stock is empty';
    END IF;
END$$

DELIMITER ;


DELIMITER $$

CREATE PROCEDURE ViewIssueBook(
    IN p_ktp VARCHAR(60)
)
BEGIN
    IF p_ktp = '' OR p_ktp IS NULL THEN
        SELECT * FROM issue_book;
    ELSE
        SELECT * 
        FROM issue_book 
        WHERE KTP = p_ktp and ReturnDate='';
    END IF;
END$$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE Updateissuebook (
    IN p_ID INT,
    IN p_ReturnDate VARCHAR(60)
)
BEGIN
    DECLARE v_BookName VARCHAR(60);

    -- Ambil nama buku dari issue_book
    SELECT BookName
    INTO v_BookName
    FROM issue_book
    WHERE Issue_ID = p_ID;

    -- Update tanggal pengembalian
    UPDATE issue_book
    SET ReturnDate = p_ReturnDate
    WHERE Issue_ID = p_ID;

    -- Tambah stok buku +1
    UPDATE tbl_books
    SET BookQuantity = BookQuantity + 1
    WHERE BookName = v_BookName;

END$$

DELIMITER ;


DELIMITER $$

CREATE PROCEDURE ViewBookReport(
    IN p_BookName VARCHAR(60)
)
BEGIN
    IF p_BookName = '' OR p_BookName IS NULL THEN
        SELECT * FROM issue_book;
    ELSE
        SELECT * 
        FROM issue_book 
        WHERE BookName = p_BookName;
    END IF;
END$$

DELIMITER ;

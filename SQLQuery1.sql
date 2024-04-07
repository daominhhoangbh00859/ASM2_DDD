
-- Tạo bảng User
CREATE TABLE  UserTable (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255),
    email VARCHAR(255),
    password VARCHAR(255),
    address VARCHAR(255),
    gender INT,
    role CHAR,
	
);

-- Tạo bảng Author
CREATE TABLE  Author (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255)
);

-- Tạo bảng Category
CREATE TABLE  Category (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255)
);

-- Tạo bảng Book
CREATE TABLE  Book (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255),
    authorID INT,
    publicationDate DATETIME,
    categoryID INT,
    FOREIGN KEY (authorID) REFERENCES Author(id),
    FOREIGN KEY (categoryID) REFERENCES Category(id)
);

INSERT INTO UserTable (name, email, password, address, gender, role)
VALUES 
('John Doe', 'john@example.com', 'password123', '123 Main St', 1, 'A'),
('Jane Smith', 'jane@example.com', 'password456', '456 Elm St', 2, 'B'),
('Michael Johnson', 'michael@example.com', 'password789', '789 Oak St', 1, 'C'),
('Emily Davis', 'emily@example.com', 'password123', '456 Pine St', 2, 'A'),
('Chris Brown', 'chris@example.com', 'password456', '789 Cedar St', 1, 'B'),
('Emma Wilson', 'emma@example.com', 'password789', '123 Maple St', 2, 'C'),
('David Martinez', 'david@example.com', 'password123', '456 Birch St', 1, 'A'),
('Sophia Taylor', 'sophia@example.com', 'password456', '789 Walnut St', 2, 'B'),
('James Anderson', 'james@example.com', 'password789', '123 Spruce St', 1, 'C'),
('Olivia Hernandez', 'olivia@example.com', 'password123', '456 Fir St', 2, 'A');

INSERT INTO Author (name)
VALUES 
('Stephen King'),
('J.K. Rowling'),
('George Orwell'),
('Agatha Christie'),
('Ernest Hemingway'),
('Toni Morrison'),
('Gabriel Garcia Marquez'),
('Harper Lee'),
('Mark Twain'),
('J.R.R. Tolkien');
 INSERT INTO Category (name)
VALUES 
('Horror'),
('Fantasy'),
('Dystopian'),
('Mystery'),
('Classic'),
('Historical'),
('Romance'),
('Science Fiction'),
('Thriller'),
('Biography');

INSERT INTO Book (name, authorID, publicationDate, categoryID)
VALUES 
('It', 1, '1986-09-15', 1),
('Harry Potter and the Philosopher''s Stone', 2, '1997-06-26', 2),
('1984', 3, '1949-06-08', 3),
('Murder on the Orient Express', 4, '1934-01-01', 4),
('The Old Man and the Sea', 5, '1952-09-01', 5),
('Beloved', 6, '1987-09-02', 6),
('One Hundred Years of Solitude', 7, '1967-05-30', 7),
('To Kill a Mockingbird', 8, '1960-07-11', 8),
('The Adventures of Huckleberry Finn', 9, '1884-12-10', 9),
('The Hobbit', 10, '1937-09-21', 2);


-- create
CREATE TABLE Classmates (
  id INTEGER PRIMARY KEY,
  name TEXT NOT NULL,
  age INTEGER NOT NULL,
  address TEXT NULL
);

-- insert
INSERT INTO Classmates VALUES (1, 'Богдан', '26', 'Хабаровск');
INSERT INTO Classmates VALUES (2, 'Софья', '22', 'Хабаровск');
INSERT INTO Classmates VALUES (3, 'Андрей', '26', 'Москва');
INSERT INTO Classmates VALUES (4, 'Константин', '25', 'Москва');
INSERT INTO Classmates VALUES (5, 'Никита', '27', 'Дальнереченск');

-- fetch 
SELECT name FROM Classmates WHERE age >= 18 and age < 30 and address = 'Москва' ;
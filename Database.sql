use [master]
GO
DROP DATABASE IF EXISTS [SoftwareAccounting];
GO

CREATE DATABASE [SoftwareAccounting];
GO

USE [SoftwareAccounting];
GO

CREATE TABLE UserTypes
(
	Id INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(40)
)

INSERT INTO UserTypes VALUES (1, 'Главный Администратор')
INSERT INTO UserTypes VALUES (3, 'Пользователь')

CREATE TABLE Positions
(
	Id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[Name] NVARCHAR(40)
)

INSERT INTO Positions VALUES ('Junior Программист')
INSERT INTO Positions VALUES ('Middle Программист')
INSERT INTO Positions VALUES ('Senior Программист')

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Fullname NVARCHAR(50),
	Email NVARCHAR(35),
	Password NVARCHAR(20),
	
	PositionFK INT,
	UserTypeFK INT
	FOREIGN KEY (PositionFK) REFERENCES Positions(Id),
	FOREIGN KEY (UserTypeFK) REFERENCES UserTypes(Id),
)

--Главный Администратор
INSERT INTO Employees VALUES('Admin', 'admin@gmail.com', 'qwerty', 3, 1)
INSERT INTO Employees VALUES('Дмитрий', 'user@gmail.com', 'qwerty', 1, 3) 


CREATE TABLE Projects
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	[Name] NVARCHAR(50)
)


CREATE TABLE ProgressStatuses
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	[Name] NVARCHAR(50)
)

INSERT INTO ProgressStatuses VALUES('Начальная')
INSERT INTO ProgressStatuses VALUES('В активной разработке')
INSERT INTO ProgressStatuses VALUES('Завершен') 

CREATE TABLE Software
(
	Id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[Name] NVARCHAR(50),
	BeginDateTime DateTime,
	LastUpdateDateTime DateTime,
	SourceURL varchar(100),

	ProjectFK INT,
	AuthorFK INT,
	ProgressStatusFK INT,
	FOREIGN KEY (AuthorFK) REFERENCES Employees(Id),
	FOREIGN KEY (ProjectFK) REFERENCES Projects(Id),
	FOREIGN KEY (ProgressStatusFK) REFERENCES ProgressStatuses(Id),

)

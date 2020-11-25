CREATE DATABASE QuanLySinhVien

-- CREATE TABLE Faculty
CREATE TABLE Faculty(
	id_faculty varchar(10) not null,
	name nvarchar(100),
	PRIMARY KEY(id_faculty)
)

-- CREATE TABLE Class
CREATE TABLE Class(
	id_class varchar(10) not null,
	id_faculty varchar(10),
	name nvarchar(100),
	PRIMARY KEY(id_class)
)

-- CREATE TABLE Users
CREATE TABLE Users (
	id_user varchar(10) not null,
	name nvarchar(100),
	permission tinyint,
	birthday smalldatetime,
	course varchar(10),
	id_class varchar(10),
	PRIMARY KEY(id_user)
)

-- CREATE TABLE Subjects
CREATE TABLE Subjects (
	id_subjects varchar(10) not null,
	name nvarchar(100),
	credit int,
	PRIMARY KEY(id_subjects)
)

-- CREATE TABLE Register_Users_Subjects
CREATE TABLE Register_Users_Subjects (
	id_user varchar(10) not null,
	id_subjects varchar(10) not null,
	PRIMARY KEY(id_user, id_subjects)
)

-- ADD FOREIGN KEY
ALTER TABLE Class
ADD CONSTRAINT FK01_Class FOREIGN KEY (id_faculty) REFERENCES Faculty;

ALTER TABLE Users
ADD CONSTRAINT FK01_Users FOREIGN KEY (id_class) REFERENCES Class;

ALTER TABLE Register_Users_Subjects
ADD CONSTRAINT FK01_Register FOREIGN KEY (id_user) REFERENCES Users;

ALTER TABLE Register_Users_Subjects
ADD CONSTRAINT FK02_Register FOREIGN KEY (id_subjects) REFERENCES Subjects;

-- INSERT INTO
INSERT INTO Faculty
VALUES ('FA1', N'Công Nghệ Thông Tin'),
		('FA2', N'Công Nghệ Tự Động'),
		('FA3', N'Tiếng Hàn')

INSERT INTO Class
VALUES ('CL1', 'FA1', N'CD19TT2'),
		('CL2', 'FA2', N'CD19TD3'),
		('CL3', 'FA3', N'CD19TH5')

INSERT INTO Users
VALUES ('AD6537', 'Admin', 9, null, null, null),
		('SD6537', 'Trong Hieu', 0, '2001-12-20', 'K19', 'CL1'),
		('SD4322', 'Ngoc Truong', 9, '2001-01-15', 'K19', 'CL3')

INSERT INTO Subjects
VALUES ('SJ1', 'Nhập Môn Lập Trình', 3),
		('SJ2', 'Lập Trình Ứng Dụng', 4),
		('SJ3', 'Tiếng Hàn Cơ Bản', 3)

INSERT INTO Register_Users_Subjects
VALUES ('SD6537', 'SJ1'),
		('SD6537', 'SJ2'),
		('SD4322', 'SJ3')

-- RESET
-- DROP CONSTRAINT
ALTER TABLE Class
DROP CONSTRAINT FK01_Class;

ALTER TABLE Users
DROP CONSTRAINT FK01_Users;

ALTER TABLE Register_Users_Subjects
DROP CONSTRAINT FK01_Register;

ALTER TABLE Register_Users_Subjects
DROP CONSTRAINT FK02_Register;

-- TRUNCATE TABLE
TRUNCATE TABLE Faculty
TRUNCATE TABLE Class
TRUNCATE TABLE Subjects
TRUNCATE TABLE Users
TRUNCATE TABLE Register_Users_Subjects

-- DROP TABLE
DROP TABLE Faculty
DROP TABLE Class
DROP TABLE Subjects
DROP TABLE Users
DROP TABLE Register_Users_Subjects


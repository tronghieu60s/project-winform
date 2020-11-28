-- CREATE DATABASE QuanLySinhVien

-- CREATE TABLE Course
GO
CREATE TABLE Course(
	id_course varchar(10) not null,
	name nvarchar(100),
	PRIMARY KEY(id_course)
)

-- CREATE TABLE Faculty
GO
CREATE TABLE Faculty(
	id_faculty varchar(10) not null,
	name nvarchar(100),
	PRIMARY KEY(id_faculty)
)

-- CREATE TABLE Class
GO
CREATE TABLE Class(
	id_class varchar(10) not null,
	id_faculty varchar(10),
	id_course varchar(10),
	name nvarchar(100),
	PRIMARY KEY(id_class)
)

-- CREATE TABLE Users
GO
CREATE TABLE Users (
	id_user varchar(10) not null,
	password varchar(250) not null,
	name nvarchar(100),
	permission tinyint,
	birthday smalldatetime,
	course varchar(10),
	id_class varchar(10),
	PRIMARY KEY(id_user)
)

-- CREATE TABLE Subjects
GO
CREATE TABLE Subjects (
	id_subjects varchar(10) not null,
	name nvarchar(100),
	credit int,
	PRIMARY KEY(id_subjects)
)

-- CREATE TABLE Register_Users_Subjects
GO
CREATE TABLE Register_Users_Subjects (
	id_user varchar(10) not null,
	id_subjects varchar(10) not null,
	PRIMARY KEY(id_user, id_subjects)
)

-- ADD FOREIGN KEY
GO
ALTER TABLE Class
ADD CONSTRAINT FK01_Class FOREIGN KEY (id_faculty) REFERENCES Faculty;

GO
ALTER TABLE Class
ADD CONSTRAINT FK02_Class FOREIGN KEY (id_course) REFERENCES Course;

GO
ALTER TABLE Users
ADD CONSTRAINT FK01_Users FOREIGN KEY (id_class) REFERENCES Class;

GO
ALTER TABLE Register_Users_Subjects
ADD CONSTRAINT FK01_Register FOREIGN KEY (id_user) REFERENCES Users;

GO
ALTER TABLE Register_Users_Subjects
ADD CONSTRAINT FK02_Register FOREIGN KEY (id_subjects) REFERENCES Subjects;

-- INSERT INTO
GO
INSERT INTO Course
VALUES ('CS1', 'K18'),
		('CS2', 'K19'),
		('CS3', 'K20')

GO
INSERT INTO Faculty
VALUES 
('FA1', N'Công Nghệ Thông Tin'),
('FA2', N'Công Nghệ Tự Động'),
('FA3', N'Tiếng Hàn')

GO
INSERT INTO Class
VALUES
('CL1', 'FA1', 'CS1', N'CD19TT2'),
('CL2', 'FA2', 'CS2', N'CD19TD3'),
('CL3', 'FA3', 'CS2', N'CD19TH5')

GO
INSERT INTO Users
VALUES
('AD6537', '123456', 'Admin', 9, null, null, null),
('SD6537', '123456', 'Trong Hieu', 0, '2001-12-20', 'K19', 'CL1'),
('SD4322', '123456', 'Ngoc Truong', 9, '2001-01-15', 'K19', 'CL3')

GO
INSERT INTO Subjects
VALUES
('SJ1', 'Nhập Môn Lập Trình', 3),
('SJ2', 'Lập Trình Ứng Dụng', 4),
('SJ3', 'Tiếng Hàn Cơ Bản', 3)

GO
INSERT INTO Register_Users_Subjects
VALUES
('SD6537', 'SJ1'),
('SD6537', 'SJ2'),
('SD4322', 'SJ3')

-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 18, 2020 lúc 02:40 AM
-- Phiên bản máy phục vụ: 10.4.11-MariaDB
-- Phiên bản PHP: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `studentsmanagement`
--

DELIMITER $$
--
-- Thủ tục
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `createClass` (IN `id_class` VARCHAR(10), IN `id_course` VARCHAR(10), IN `id_faculty` VARCHAR(10), IN `class_name` VARCHAR(100))  NO SQL
INSERT INTO `classes`(`id_class`, `id_course`, `id_faculty`, `class_name`) VALUES (id_class, id_course, id_faculty, class_name)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `createCourse` (IN `id_course` VARCHAR(10), IN `course_name` VARCHAR(100))  NO SQL
INSERT INTO `courses`(`id_course`, `course_name`) VALUES (id_course, course_name)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `createFaculty` (IN `id_faculty` VARCHAR(10), IN `faculty_name` VARCHAR(100))  NO SQL
INSERT INTO `faculties`(`id_faculty`, `faculty_name`) VALUES (id_faculty, faculty_name)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `createRegisterSubject` (IN `id_user` VARCHAR(10), IN `id_subject` VARCHAR(10))  NO SQL
INSERT INTO `registers_user_subject`(`id_user`, `id_subject`) VALUES (id_user, id_subject)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `createSubject` (IN `id_subjects` VARCHAR(10), IN `subject_name` VARCHAR(100), IN `credit` INT, IN `information` TEXT, IN `lecturer_name` VARCHAR(200), IN `start_day` DATETIME, IN `end_day` DATETIME, IN `id_course` VARCHAR(10), IN `id_faculty` VARCHAR(10))  NO SQL
INSERT INTO `subjects`(`id_subjects`, `subject_name`, `credit`, `information`, `lecturer_name`, `start_day`, `end_day`, `id_course`, `id_faculty`) VALUES (id_subjects, subject_name, credit, information, lecturer_name, start_day, end_day, id_course, id_faculty)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `createUser` (IN `id_user` VARCHAR(10), IN `textpassword` TEXT, IN `name` VARCHAR(100), IN `birthday` DATE, IN `id_class` VARCHAR(10))  NO SQL
INSERT INTO `users`(`id_user`, `password`, `name`, `birthday`, `id_class`) VALUES (id_user, textpassword, name, birthday, id_class)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteClassWithId` (IN `id_class` VARCHAR(10))  NO SQL
DELETE FROM `classes` WHERE `classes`.`id_class` = id_class$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteCourseWithId` (IN `id_course` VARCHAR(10))  NO SQL
DELETE FROM `courses` WHERE `courses`.`id_course` = id_course$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteFacultyWithId` (IN `id_faculty` VARCHAR(10))  NO SQL
DELETE FROM `faculties` WHERE `faculties`.`id_faculty` = id_faculty$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteRegisterSubjectWithId` (IN `id_userFROM ``registers_user_subject`` WHERE ``registers_user_subject``.``id_user`` = @id_user AND ``registers_user_subject``.``id_subject`` = @id_subject` VARCHAR(10), IN `id_subject` VARCHAR(10))  NO SQL
DELETE FROM `registers_user_subject` WHERE `registers_user_subject`.`id_user` = id_user AND `registers_user_subject`.`id_subject` = id_subject$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteSubjectWithId` (IN `id_subjects` VARCHAR(10))  NO SQL
DELETE FROM `subjects` WHERE `subjects`.`id_subjects` = id_subjects$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteUserWithId` (IN `id_user` VARCHAR(10))  NO SQL
DELETE FROM `users` WHERE `users`.`id_user` = id_user$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getClasses` ()  BEGIN 
SELECT * FROM `classes` LEFT JOIN `faculties` ON `faculties`.`id_faculty`= `classes`.`id_faculty` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` ORDER BY `classes`.`date` DESC; 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getClassesWithIdCourseAndIdFaculty` (IN `id_course` VARCHAR(10), IN `id_faculty` VARCHAR(10))  NO SQL
SELECT * FROM `classes` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` WHERE `courses`.`id_course` = id_course AND `faculties`.`id_faculty` = id_faculty$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getClassWithClassName` (IN `class_name` VARCHAR(100))  NO SQL
SELECT * FROM `classes` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` WHERE `classes`.`class_name` = class_name$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getCourses` ()  NO SQL
SELECT * FROM `courses` ORDER BY date DESC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getFaculties` ()  NO SQL
SELECT * FROM `faculties` ORDER BY date DESC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getSubjects` ()  NO SQL
SELECT * FROM `subjects` LEFT JOIN `courses` ON `courses`.`id_course` = `subjects`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `subjects`.`id_faculty` ORDER BY `subjects`.`date` DESC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getSubjectsWithRegisterIdUser` (IN `id_user` VARCHAR(10))  NO SQL
SELECT * FROM `registers_user_subject` LEFT JOIN `users` ON `users`.`id_user` = `registers_user_subject`.`id_user` LEFT JOIN `subjects` ON `subjects`.`id_subjects` = `registers_user_subject`.`id_subject` WHERE `registers_user_subject`.`id_user` = id_user ORDER BY `registers_user_subject`.`date` DESC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getUsers` ()  NO SQL
SELECT * FROM `users` LEFT JOIN `classes` ON `classes`.`id_class`= `users`.`id_class` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` ORDER BY `users`.`date` DESC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getUserWithId` (IN `id_user` VARCHAR(10))  NO SQL
SELECT *  FROM `users` LEFT JOIN `classes` ON `classes`.`id_class`= `users`.`id_class` LEFT JOIN `courses` ON `courses`.`id_course` = `classes`.`id_course` LEFT JOIN `faculties` ON `faculties`.`id_faculty` = `classes`.`id_faculty` WHERE `users`.`id_user` = id_user$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateClassWithId` (IN `v_id_class` VARCHAR(10), IN `id_course` VARCHAR(10), IN `id_faculty` VARCHAR(10), IN `class_name` VARCHAR(100))  NO SQL
UPDATE `classes` SET `id_course`= id_course,`id_faculty`= id_faculty,`class_name`= class_name WHERE `id_class`= v_id_class$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateCourseWithId` (IN `v_id_course` VARCHAR(10), IN `course_name` VARCHAR(100))  NO SQL
UPDATE `courses` SET `course_name`= course_name WHERE `id_course`= v_id_course$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateFacultyWithId` (IN `v_id_faculty` VARCHAR(10), IN `faculty_name` VARCHAR(100))  NO SQL
UPDATE `faculties` SET `faculty_name`= faculty_name WHERE `id_faculty` = v_id_faculty$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateSubjectWithId` (IN `v_id_subjects` VARCHAR(10), IN `subject_name` VARCHAR(100), IN `credit` INT, IN `information` TEXT, IN `lecturer_name` VARCHAR(200), IN `start_day` DATETIME, IN `end_day` DATETIME, IN `id_course` VARCHAR(10), IN `id_faculty` VARCHAR(10))  NO SQL
UPDATE `subjects` SET `subject_name`= subject_name,`credit`= credit,`information`= information,`lecturer_name`= lecturer_name,`start_day`= start_day,`end_day`= end_day,`id_course`= id_course,`id_faculty`= id_faculty
WHERE `id_subjects` = v_id_subjects$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateUserFromAdminWithId` (IN `v_id_user` VARCHAR(10), IN `name` VARCHAR(100), IN `birthday` DATE, IN `id_class` VARCHAR(10))  NO SQL
UPDATE `users` SET `name`= name,`birthday`= birthday, `id_class`= id_class WHERE `id_user`= v_id_user$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateUserWithId` (IN `v_id_user` VARCHAR(10), IN `textpassword` TEXT, IN `name` VARCHAR(100), IN `birthday` DATE, IN `id_class` VARCHAR(10))  NO SQL
UPDATE `users` SET `password`= textpassword, `name`= name,`birthday`= birthday, `id_class`= id_class WHERE `id_user`= v_id_user$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `classes`
--

CREATE TABLE `classes` (
  `id_class` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_course` varchar(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `id_faculty` varchar(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `class_name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `date` int(11) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `classes`
--

INSERT INTO `classes` (`id_class`, `id_course`, `id_faculty`, `class_name`, `date`) VALUES
('CD18TN3', 'K18', 'FA03', 'CD18TN3', 2147483647),
('CD19TA1', 'K19', 'FA01', 'CD19TA1', 2147483647),
('CD19TA2', 'K19', 'FA01', 'CD19TA2', 2147483647),
('CD19TA3', 'K19', 'FA01', 'CD19TA3', 2147483647),
('CD19TA4', 'K19', 'FA01', 'CD19TA4', 2147483647),
('CD19TA5', 'K19', 'FA01', 'CD19TA5', 2147483647),
('CD19TH1', 'K19', 'FA02', 'CD19TH1', 2147483647),
('CD19TH2', 'K19', 'FA02', 'CD19TH2', 2147483647),
('CD19TH3', 'K19', 'FA02', 'CD19TH3', 2147483647),
('CD19TH4', 'K19', 'FA02', 'CD19TH4', 2147483647),
('CD19TN1', 'K19', 'FA03', 'CD19TN1', 2147483647),
('CD20TA3', 'K20', 'FA01', 'CD20TA3', 2147483647),
('CD20TH1', 'K20', 'FA02', 'CD20TH1', 2147483647),
('CD20TH3', 'K20', 'FA02', 'CD20TH3', 2147483647),
('CD20TN1', 'K20', 'FA03', 'CD20TN1', 2147483647),
('CD20TN2', 'K20', 'FA03', 'CD20TN2', 2147483647),
('CD20TN3', 'K20', 'FA03', 'CD20TN3', 2147483647),
('CD20TN4', 'K20', 'FA03', 'CD20TN4', 2147483647),
('CD20TN5', 'K20', 'FA03', 'CD20TN5', 2147483647),
('CD20TN6', 'K20', 'FA03', 'CD20TN6', 2147483647);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `courses`
--

CREATE TABLE `courses` (
  `id_course` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `course_name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `date` int(11) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `courses`
--

INSERT INTO `courses` (`id_course`, `course_name`, `date`) VALUES
('K18', 'Khóa 18', 2147483647),
('K19', 'Khóa 19', 2147483647),
('K20', 'Khóa 20', 2147483647);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `faculties`
--

CREATE TABLE `faculties` (
  `id_faculty` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `faculty_name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `date` int(11) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `faculties`
--

INSERT INTO `faculties` (`id_faculty`, `faculty_name`, `date`) VALUES
('FA01', 'Tiếng Anh', 2147483647),
('FA02', 'Tiếng Hàn', 2147483647),
('FA03', 'Tiếng Nhật', 2147483647);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `registers_user_subject`
--

CREATE TABLE `registers_user_subject` (
  `id_user` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_subject` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `date` int(11) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `subjects`
--

CREATE TABLE `subjects` (
  `id_subjects` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `subject_name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `credit` int(11) DEFAULT NULL,
  `information` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `lecturer_name` varchar(200) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `start_day` datetime DEFAULT NULL,
  `end_day` datetime DEFAULT NULL,
  `id_course` varchar(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `id_faculty` varchar(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `date` int(11) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `subjects`
--

INSERT INTO `subjects` (`id_subjects`, `subject_name`, `credit`, `information`, `lecturer_name`, `start_day`, `end_day`, `id_course`, `id_faculty`, `date`) VALUES
('43224', '', 0, '', '', '2020-12-18 00:00:00', '2020-12-18 00:00:00', 'K18', 'FA01', 2147483647),
('dfgfgdg', 'anh chào em', 0, '', '', '2020-12-18 00:00:00', '2020-12-18 00:00:00', 'K19', 'FA02', 2147483647),
('dsadsad', '', 0, '', '', '2020-12-18 00:00:00', '2020-12-18 00:00:00', 'K18', 'FA01', 2147483647);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `id_user` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `birthday` date DEFAULT NULL,
  `id_class` varchar(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `users`
--

INSERT INTO `users` (`id_user`, `password`, `name`, `birthday`, `id_class`, `date`) VALUES
('ADMIN', 'DVOZUIQnznlVbNpxkYAgwejRW1M=', 'Trần Trọng Hiếu', '2020-12-17', NULL, '2020-11-30 21:53:48'),
('SD11089', 'DVOZUIQnznlVbNpxkYAgwejRW1M=', 'Sử Bình', '2020-12-01', 'CD19TA3', '2020-12-05 20:40:10'),
('SD11529', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Ung Khúc Lan', '2020-12-01', 'CD20TN6', '2020-12-05 20:43:20'),
('SD11993', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Lục Nhật Minh', '2020-12-01', 'CD19TA3', '2020-12-05 20:40:24'),
('SD17436', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Lục Thảo', '2020-12-01', 'CD20TH1', '2020-12-05 20:41:00'),
('SD17833', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Bình Hạ', '2020-12-01', 'CD19TA1', '2020-12-05 20:39:47'),
('SD22440', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Âu Nguyệt', '2020-12-01', 'CD20TA3', '2020-12-05 20:43:33'),
('SD29707', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Trần Diễm Chiêu', '2020-12-01', 'CD20TN4', '2020-12-05 20:42:19'),
('SD30440', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Bạch Uyên Diễm', '2020-12-01', 'CD20TN5', '2020-12-05 20:42:55'),
('SD40763', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Âu Nguyệt', '2020-12-01', 'CD20TN1', '2020-12-05 20:41:52'),
('SD42648', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Khuất Phúc', '2020-12-01', 'CD19TA1', '2020-12-05 20:39:34'),
('SD63382', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Lô Hải Lam', '2020-12-01', 'CD20TN4', '2020-12-05 20:42:25'),
('SD69074', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Bình Hạ', '2020-12-01', 'CD19TA1', '2020-12-05 20:39:54'),
('SD70101', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Đặng Uyển Nhi', '2020-12-01', 'CD20TN5', '2020-12-05 20:43:02'),
('SD74038', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Phi Xuân Mai', '2020-12-01', 'CD19TA4', '2020-12-05 20:40:37'),
('SD74836', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Khúc Lan', '2020-12-01', 'CD20TN3', '2020-12-05 20:42:02'),
('SD79060', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Liễu Đài', '2020-12-01', 'CD20TA3', '2020-12-05 20:42:09'),
('SD83814', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Nhâm Kiếm', '2020-12-01', 'CD20TN6', '2020-12-05 20:41:25'),
('SD84969', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Ngô Hợp', '2020-12-01', 'CD20TH1', '2020-12-05 20:41:06'),
('SD86310', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Cái Liên', '2020-12-01', 'CD20TN3', '2020-12-05 20:43:13'),
('SD91688', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Lã Cảnh Ẩn', '2020-12-01', 'CD20TN2', '2020-12-05 20:41:43'),
('SD92446', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Lâm Huynh', '2020-12-01', 'CD20TN2', '2020-12-05 20:41:19'),
('SD95015', 'btWDPPNShuv4Zit7WUnw10K77D8=', 'Vũ Đan', '2020-12-01', 'CD20TN2', '2020-12-05 20:41:36');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `classes`
--
ALTER TABLE `classes`
  ADD PRIMARY KEY (`id_class`),
  ADD KEY `FK01_Class` (`id_faculty`),
  ADD KEY `FK01_classes` (`id_course`);

--
-- Chỉ mục cho bảng `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`id_course`);

--
-- Chỉ mục cho bảng `faculties`
--
ALTER TABLE `faculties`
  ADD PRIMARY KEY (`id_faculty`);

--
-- Chỉ mục cho bảng `registers_user_subject`
--
ALTER TABLE `registers_user_subject`
  ADD PRIMARY KEY (`id_user`,`id_subject`),
  ADD KEY `FK02_Register` (`id_subject`);

--
-- Chỉ mục cho bảng `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id_subjects`),
  ADD KEY `FK01_subjects` (`id_course`),
  ADD KEY `FK02_subjects` (`id_faculty`);

--
-- Chỉ mục cho bảng `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`),
  ADD KEY `FK01_Users` (`id_class`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `FK01_Class` FOREIGN KEY (`id_faculty`) REFERENCES `faculties` (`id_faculty`),
  ADD CONSTRAINT `FK01_classes` FOREIGN KEY (`id_course`) REFERENCES `courses` (`id_course`);

--
-- Các ràng buộc cho bảng `registers_user_subject`
--
ALTER TABLE `registers_user_subject`
  ADD CONSTRAINT `FK01_Register` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`),
  ADD CONSTRAINT `FK02_Register` FOREIGN KEY (`id_subject`) REFERENCES `subjects` (`id_subjects`),
  ADD CONSTRAINT `FK03_Register` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`);

--
-- Các ràng buộc cho bảng `subjects`
--
ALTER TABLE `subjects`
  ADD CONSTRAINT `FK01_subjects` FOREIGN KEY (`id_course`) REFERENCES `courses` (`id_course`),
  ADD CONSTRAINT `FK02_subjects` FOREIGN KEY (`id_faculty`) REFERENCES `faculties` (`id_faculty`);

--
-- Các ràng buộc cho bảng `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `FK01_Users` FOREIGN KEY (`id_class`) REFERENCES `classes` (`id_class`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

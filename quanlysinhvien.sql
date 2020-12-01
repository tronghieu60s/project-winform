-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 01, 2020 lúc 05:13 PM
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
-- Cơ sở dữ liệu: `quanlysinhvien`
--

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
('CL1', 'K19', 'FA1', 'CD19TT2', 2147483647),
('CL2', 'K19', 'FA2', 'CD19TD3', 2147483647),
('CL3', 'K20', 'FA3', 'CD19TH5', 2147483647),
('CL4', 'K20', 'FA3', 'CD19TH6', 2147483647),
('CL5', 'K20', 'FA3', 'CD19TH7', 2147483647);

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
('FA1', 'Công Nghệ Thông Tin', 2147483647),
('FA2', 'Công Nghệ Tự Động', 2147483647),
('FA3', 'Tiếng Hàn', 2147483647);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `registers_user_subject`
--

CREATE TABLE `registers_user_subject` (
  `id_user` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_subjects` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `date` int(11) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `subjects`
--

CREATE TABLE `subjects` (
  `id_subjects` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `credit` int(11) DEFAULT NULL,
  `date` int(11) NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `subjects`
--

INSERT INTO `subjects` (`id_subjects`, `name`, `credit`, `date`) VALUES
('SJ1', 'Nhập Môn Lập Trình', 3, 2147483647),
('SJ2', 'Lập Trình Ứng Dụng', 4, 2147483647),
('SJ3', 'Tiếng Hàn Cơ Bản', 3, 2147483647);

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
('ADMIN', '123456', 'Trần Trọng Hiếu', '2020-12-17', NULL, '2020-11-30 21:53:48'),
('SD12831', '123456', 'Nguyễn Ngọc Trường', '2001-01-18', 'CL3', '2020-12-01 18:55:09'),
('SD19901', '123456', 'Trọng Hiếu', '2001-12-02', 'CL1', '2020-12-01 11:58:12'),
('SD22742', '123456', 'Nguyễn Ngọc Trường', '2001-01-18', 'CL3', '2020-12-01 11:58:12'),
('SD24765', '123456', 'Trọng Hiếu', '2001-12-02', 'CL1', '2020-12-01 18:54:39'),
('SD32679', '123456', 'Nguyễn Ngọc Trường', '2001-01-18', 'CL3', '2020-12-01 18:40:08'),
('SD67812', '123456', 'Trọng Hiếu', '2001-12-02', 'CL1', '2020-12-01 18:40:08'),
('SD79631', '123456', 'Nguyễn Ngọc Trường', '2001-01-18', 'CL3', '2020-12-01 18:54:39'),
('SD94982', '123456', 'Trọng Hiếu', '2001-12-02', 'CL1', '2020-12-01 18:55:09');

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
  ADD PRIMARY KEY (`id_user`,`id_subjects`),
  ADD KEY `FK02_Register` (`id_subjects`);

--
-- Chỉ mục cho bảng `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id_subjects`);

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
  ADD CONSTRAINT `FK02_Register` FOREIGN KEY (`id_subjects`) REFERENCES `subjects` (`id_subjects`);

--
-- Các ràng buộc cho bảng `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `FK01_Users` FOREIGN KEY (`id_class`) REFERENCES `classes` (`id_class`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

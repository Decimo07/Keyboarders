-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2023 at 07:47 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbook`
--

CREATE TABLE `tblbook` (
  `accession_no` int(11) NOT NULL,
  `qrcodeno` int(11) DEFAULT NULL,
  `call_no` varchar(45) DEFAULT NULL,
  `title` varchar(45) DEFAULT NULL,
  `author` varchar(45) DEFAULT NULL,
  `year_published` varchar(45) DEFAULT NULL,
  `ISBN` varchar(45) DEFAULT NULL,
  `Notes` varchar(45) DEFAULT NULL,
  `Subject` varchar(45) DEFAULT NULL,
  `Series` varchar(45) DEFAULT NULL,
  `Price` decimal(18,2) DEFAULT NULL,
  `Publisher` varchar(45) DEFAULT NULL,
  `cid` int(11) DEFAULT NULL,
  `qrcode` blob DEFAULT NULL,
  `book_image` blob DEFAULT NULL,
  `qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE `tblcategory` (
  `id` int(11) NOT NULL,
  `category` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`id`, `category`) VALUES
(1, 'Fiction'),
(2, 'Romance'),
(3, 'History');

-- --------------------------------------------------------

--
-- Table structure for table `tblfaculty`
--

CREATE TABLE `tblfaculty` (
  `employee_id` varchar(45) NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `contatcno` varchar(45) DEFAULT NULL,
  `penalty` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblissuedreturn`
--

CREATE TABLE `tblissuedreturn` (
  `transno` int(11) NOT NULL,
  `borrower_id` varchar(45) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `accession_no` int(11) NOT NULL,
  `title` varchar(45) DEFAULT NULL,
  `author` varchar(45) DEFAULT NULL,
  `date_borrowed` date DEFAULT NULL,
  `Due_Date` date DEFAULT NULL,
  `Penalty` decimal(18,2) DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  `Issuedby` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblstudent`
--

CREATE TABLE `tblstudent` (
  `school_id` varchar(45) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `contactno` varchar(45) DEFAULT NULL,
  `guardian` varchar(45) DEFAULT NULL,
  `penalty` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `Employee_ID` varchar(45) NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `secretquestion` varchar(45) DEFAULT NULL,
  `secretanswer` varchar(45) DEFAULT NULL,
  `role` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`Employee_ID`, `firstname`, `middlename`, `lastname`, `username`, `password`, `secretquestion`, `secretanswer`, `role`) VALUES
('00001', 'darren', 'b', 'jamison', 'admin', 'admin', 'what is your pet name?', 'sky', 'administrator'),
('00002', 'Juan', 'Santos', 'Dela Cruz', 'staff', 'staff', 'what is your pet name?', 'sky', 'standard');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbook`
--
ALTER TABLE `tblbook`
  ADD PRIMARY KEY (`accession_no`);

--
-- Indexes for table `tblcategory`
--
ALTER TABLE `tblcategory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblfaculty`
--
ALTER TABLE `tblfaculty`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `tblissuedreturn`
--
ALTER TABLE `tblissuedreturn`
  ADD PRIMARY KEY (`transno`,`accession_no`,`borrower_id`,`Issuedby`);

--
-- Indexes for table `tblstudent`
--
ALTER TABLE `tblstudent`
  ADD PRIMARY KEY (`school_id`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`Employee_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbook`
--
ALTER TABLE `tblbook`
  MODIFY `accession_no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=789457;

--
-- AUTO_INCREMENT for table `tblcategory`
--
ALTER TABLE `tblcategory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

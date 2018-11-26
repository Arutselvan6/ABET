-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2018 at 03:57 AM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hdms`
--

-- --------------------------------------------------------

--
-- Table structure for table `device`
--

CREATE TABLE `device` (
  `DEVICENAME` varchar(20) NOT NULL,
  `DEVICETYPE` varchar(15) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `MANUFACTURER` varchar(20) NOT NULL,
  `PURCHASEDATE` date NOT NULL,
  `DEVICEID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `devicereq`
--

CREATE TABLE `devicereq` (
  `DEVICENAME` varchar(20) NOT NULL,
  `USERNAME` varchar(20) NOT NULL,
  `QUANTITY` bigint(20) NOT NULL,
  `APPOINTMENT` date NOT NULL,
  `USAGEDURATION` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `doctors`
--

CREATE TABLE `doctors` (
  `FIRST_NAME` char(20) NOT NULL,
  `LAST_NAME` char(20) NOT NULL,
  `DOCTORID` varchar(10) NOT NULL,
  `PASSWORD` varchar(10) NOT NULL,
  `TYPES` char(20) NOT NULL,
  `GENDER` char(10) NOT NULL,
  `SPECIALISATION` char(20) NOT NULL,
  `EMAILID` varchar(20) NOT NULL,
  `ADDRESS` varchar(10) NOT NULL,
  `PHONE` varchar(30) NOT NULL,
  `CITY` char(20) NOT NULL,
  `STATES` varchar(20) NOT NULL,
  `COUNTRY` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `doctors`
--

INSERT INTO `doctors` (`FIRST_NAME`, `LAST_NAME`, `DOCTORID`, `PASSWORD`, `TYPES`, `GENDER`, `SPECIALISATION`, `EMAILID`, `ADDRESS`, `PHONE`, `CITY`, `STATES`, `COUNTRY`) VALUES
('Arutselvan', 'M', 'D01', 'asd', 'Doctor', 'male', 'Heart Surgeon', 'sanarut8@gmail.com', 'Chennai', '1231231', 'Chennai', 'Tamil Nadu', 'India');

-- --------------------------------------------------------

--
-- Table structure for table `findept`
--

CREATE TABLE `findept` (
  `FINANCEDEPTID` varchar(20) NOT NULL,
  `FINANCERNAME` char(20) NOT NULL,
  `PASSWORD` varchar(10) NOT NULL,
  `QUALIFICATIONS` varchar(20) NOT NULL,
  `CONTACT` varchar(10) NOT NULL,
  `EXPERIENCE` int(11) NOT NULL,
  `ADDRESS` varchar(30) NOT NULL,
  `WORKHOUR` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `medperson`
--

CREATE TABLE `medperson` (
  `MPNAME` char(20) NOT NULL,
  `MPID` varchar(20) NOT NULL,
  `PASSWORD` varchar(10) NOT NULL,
  `DOB` date NOT NULL,
  `QUALIFICATION` char(20) NOT NULL,
  `CONTACT` varchar(10) NOT NULL,
  `ADDRESS` varchar(30) NOT NULL,
  `GENDER` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `USERNAME` varchar(15) NOT NULL,
  `PASSWORD` varchar(10) NOT NULL,
  `TYPES` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`USERNAME`, `PASSWORD`, `TYPES`) VALUES
('D01', 'asd', 'Doctor');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `device`
--
ALTER TABLE `device`
  ADD PRIMARY KEY (`DEVICEID`);

--
-- Indexes for table `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`DOCTORID`);

--
-- Indexes for table `findept`
--
ALTER TABLE `findept`
  ADD PRIMARY KEY (`FINANCEDEPTID`);

--
-- Indexes for table `medperson`
--
ALTER TABLE `medperson`
  ADD PRIMARY KEY (`MPID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`USERNAME`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

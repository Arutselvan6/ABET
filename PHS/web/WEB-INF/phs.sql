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
-- Database: `phs`
--

-- --------------------------------------------------------

--
-- Table structure for table `addmitting`
--

CREATE TABLE `addmitting` (
  `PATIENTNAME` char(10) NOT NULL,
  `FATHERNAME` char(10) NOT NULL,
  `GENDER` char(8) NOT NULL,
  `ADDRESS` char(100) NOT NULL,
  `AGE` int(11) NOT NULL,
  `CONTECTNUMBER` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

CREATE TABLE `billing` (
  `PATIENTNAME` char(10) NOT NULL,
  `REGISTRATION_ID` varchar(15) NOT NULL,
  `TOTAL_AMMOUNT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `FIRST_NAME` char(10) NOT NULL,
  `LAST_NAME` char(10) NOT NULL,
  `AGE` int(11) NOT NULL,
  `ADDRESS` char(100) NOT NULL,
  `STATE` char(10) NOT NULL,
  `CITY` char(10) NOT NULL,
  `PIN_CODE` int(11) NOT NULL,
  `CONTACT_NO` int(11) NOT NULL,
  `EMAIL_ID` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `PATIENT_NAME` char(10) NOT NULL,
  `REGISTRATION_ID` varchar(15) NOT NULL,
  `PREFER_DOCTOR` char(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `doctor`
--

CREATE TABLE `doctor` (
  `WARD_ALLOTMENT` char(20) NOT NULL,
  `TEST_FOR_PATIENT` char(10) NOT NULL,
  `REPORT` char(200) NOT NULL,
  `PRESCRIPTION` char(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `feed`
--

CREATE TABLE `feed` (
  `USER_NAME` char(10) NOT NULL,
  `EMAIL_ID` varchar(20) NOT NULL,
  `PASSWORD` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `USERNAME` char(15) NOT NULL,
  `PASSWORD` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 16, 2021 at 07:35 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `movie`
--

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE `movie` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Genre` varchar(255) NOT NULL,
  `Duration` varchar(255) NOT NULL,
  `ReleaseDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `movie`
--

INSERT INTO `movie` (`Id`, `Name`, `Genre`, `Duration`, `ReleaseDate`) VALUES
(1, 'Bad Boys for Life', 'Action/Comedy', '2h 5 mins', '2020-01-23 00:00:00'),
(2, 'John Wick', 'Action/Thriller', '1h 41 mins', '2014-10-24 00:00:00'),
(3, 'The Martian', 'Sci-fi/Drama', '2h 31 mins', '2015-10-02 00:00:00'),
(4, 'How to Train Your Dragon: The Hidden World', 'Animation/Family', '1h 45 mins', '2019-02-22 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movie`
--
ALTER TABLE `movie`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

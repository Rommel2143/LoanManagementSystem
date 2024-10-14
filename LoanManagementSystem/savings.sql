-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 14, 2024 at 04:46 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lms`
--

-- --------------------------------------------------------

--
-- Table structure for table `savings`
--

CREATE TABLE `savings` (
  `id` int(30) NOT NULL,
  `referenceno` varchar(15) NOT NULL,
  `account_no` varchar(20) NOT NULL,
  `date_transac` date NOT NULL,
  `time` time NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `status` text NOT NULL,
  `teller` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `savings`
--

INSERT INTO `savings` (`id`, `referenceno`, `account_no`, `date_transac`, `time`, `amount`, `status`, `teller`) VALUES
(2, 'DAUC-348244-24', '03200730', '2024-10-14', '00:00:00', 1000.63, 'D', '03200728'),
(3, 'DJFA-330036-24', '03200730', '2024-10-14', '00:00:00', 1000.63, 'D', '03200728'),
(4, 'DFVG-818153-24', '03200728', '2024-10-14', '00:00:00', 1.00, 'D', '03200728'),
(5, 'D-XYR676-24', '03200729', '2024-10-14', '00:00:00', 123.00, 'D', '03200728'),
(6, 'D-EAS549-24', '03200730', '2024-10-14', '00:00:00', 1000.00, 'D', '03200728'),
(7, 'W-MFW769-24', '03200730', '2024-10-14', '00:00:00', 2000.00, 'W', '03200728'),
(8, 'D-VHL943-24', '03200730', '2024-10-14', '00:00:00', 1000.00, 'D', '03200728'),
(9, 'W-UKU759-24', '03200730', '2024-10-14', '00:00:00', 1.26, 'W', '03200728'),
(10, 'D-UDO756-24', '03200730', '2024-10-14', '00:00:00', 1000.00, 'D', '03200728'),
(12, 'W-LOL033-24', '03200730', '2024-10-14', '00:00:00', 12.00, 'W', '03200728'),
(13, 'D-WRP886-24', '03200730', '2024-10-14', '22:23:00', 12.00, 'D', '03200728'),
(14, 'W-TKE848-24', '03200730', '2024-10-14', '22:25:00', 3000.00, 'W', '03200728'),
(15, 'D-HXI471-24', '03200730', '2024-10-14', '22:25:00', 12.00, 'D', '03200728'),
(16, 'W-TWK886-24', '03200730', '2024-10-14', '22:26:00', 9.00, 'W', '03200728'),
(17, 'D-LAM321-24', '03200730', '2024-10-14', '22:30:00', 9999999.99, 'D', '03200728'),
(18, 'D-ECR028-24', '03200730', '2024-10-14', '22:31:00', 99999999.99, 'D', '03200728');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `savings`
--
ALTER TABLE `savings`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `savings`
--
ALTER TABLE `savings`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

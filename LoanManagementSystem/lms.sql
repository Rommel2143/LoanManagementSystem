-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 17, 2024 at 10:40 AM
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
-- Table structure for table `collateral_types`
--

CREATE TABLE `collateral_types` (
  `id` int(11) NOT NULL,
  `collateral` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `collateral_types`
--

INSERT INTO `collateral_types` (`id`, `collateral`) VALUES
(1, 'Real State'),
(2, 'Vehicle'),
(3, 'Insurance');

-- --------------------------------------------------------

--
-- Table structure for table `computer_location`
--

CREATE TABLE `computer_location` (
  `id` int(6) NOT NULL,
  `PCname` varchar(150) NOT NULL,
  `PCmac` varchar(150) NOT NULL,
  `location` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `computer_location`
--

INSERT INTO `computer_location` (`id`, `PCname`, `PCmac`, `location`) VALUES
(2, 'PTI-029', '48210B6016EA', ''),
(3, 'PTI-029', 'E40D3606AB03', ''),
(4, 'DESKTOP-50NOBGC', 'AC198E0D0BDD', ''),
(5, 'DESKTOP-50NOBGC', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `loan_app`
--

CREATE TABLE `loan_app` (
  `id` int(200) NOT NULL,
  `referenceno` varchar(100) NOT NULL,
  `account_no` varchar(100) NOT NULL,
  `amount` decimal(9,2) NOT NULL,
  `ammortization` decimal(8,2) NOT NULL,
  `interest_rate` decimal(5,2) NOT NULL,
  `service_fee` decimal(8,2) NOT NULL,
  `interest` decimal(8,2) NOT NULL,
  `date_apply` date NOT NULL,
  `date_approved` date DEFAULT NULL,
  `date_start` date DEFAULT NULL,
  `months_count` int(4) NOT NULL,
  `teller` varchar(100) NOT NULL,
  `teller_approved` varchar(100) NOT NULL,
  `mode` varchar(30) NOT NULL,
  `purpose` varchar(30) NOT NULL,
  `collateral` varchar(100) NOT NULL,
  `comaker_1` varchar(100) NOT NULL,
  `comaker_2` varchar(100) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loan_app`
--

INSERT INTO `loan_app` (`id`, `referenceno`, `account_no`, `amount`, `ammortization`, `interest_rate`, `service_fee`, `interest`, `date_apply`, `date_approved`, `date_start`, `months_count`, `teller`, `teller_approved`, `mode`, `purpose`, `collateral`, `comaker_1`, `comaker_2`, `status`) VALUES
(13, 'LPOV-335280-24', '03200728', 10000.00, 1740.34, 0.15, 150.00, 442.04, '2024-09-16', NULL, NULL, 6, '03200728', '', 'Check', 'Car Loan', 'Real State', '', '', 0),
(14, 'LBQZ-773016-24', '03200728', 10000.00, 902.58, 0.15, 300.00, 830.96, '2024-09-16', NULL, NULL, 12, '03200728', '', 'Cash', 'Car Loan', 'Real State', '', '', 0),
(15, 'LKMR-581126-24', '03200728', 100000.00, 4848.66, 0.15, 3000.00, 16367.84, '2024-09-16', NULL, NULL, 24, '03200728', '', 'Bank Transfer', 'Car Loan', 'Real State', '03200728', '03200728', 0),
(16, 'LHUM-454259-24', '03200728', 1000.00, 1012.50, 0.15, 15.00, 12.50, '2024-09-16', NULL, NULL, 1, '03200728', '', '', 'Car Loan', 'Real State', '03200728', '03200728', 0);

-- --------------------------------------------------------

--
-- Table structure for table `loan_types`
--

CREATE TABLE `loan_types` (
  `id` int(11) NOT NULL,
  `type` varchar(100) NOT NULL,
  `interest` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loan_types`
--

INSERT INTO `loan_types` (`id`, `type`, `interest`) VALUES
(1, 'Car Loan', 0.15),
(2, 'Education Loan', 0.17),
(3, 'House Loan', 0.20);

-- --------------------------------------------------------

--
-- Table structure for table `member_profile`
--

CREATE TABLE `member_profile` (
  `id` int(20) NOT NULL,
  `account_no` varchar(20) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `birthdate` date NOT NULL,
  `civilstatus` varchar(30) NOT NULL,
  `gender` varchar(3) NOT NULL,
  `place_birth` varchar(200) NOT NULL,
  `present_address` varchar(200) NOT NULL,
  `contact1` varchar(100) NOT NULL,
  `contact2` varchar(100) NOT NULL,
  `emp_status` varchar(20) NOT NULL,
  `idtype` varchar(20) NOT NULL,
  `idtype_no` varchar(20) NOT NULL,
  `sharecap` int(30) NOT NULL,
  `savings` int(100) NOT NULL,
  `image` blob NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `member_profile`
--

INSERT INTO `member_profile` (`id`, `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `gender`, `place_birth`, `present_address`, `contact1`, `contact2`, `emp_status`, `idtype`, `idtype_no`, `sharecap`, `savings`, `image`, `status`) VALUES
(21, '03200728', 'Rommel', 'Cueto', 'Magnaye', '2024-04-03', 'S', 'M', '', '', '', '', '', '', '', 0, 0, '', 1);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `account_no` varchar(20) NOT NULL,
  `username` varchar(100) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `level` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `account_no`, `username`, `pass`, `level`) VALUES
(1, '03200728', 'momel', '123', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `collateral_types`
--
ALTER TABLE `collateral_types`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `computer_location`
--
ALTER TABLE `computer_location`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `loan_app`
--
ALTER TABLE `loan_app`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `referenceno` (`referenceno`);

--
-- Indexes for table `loan_types`
--
ALTER TABLE `loan_types`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `member_profile`
--
ALTER TABLE `member_profile`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `collateral_types`
--
ALTER TABLE `collateral_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `computer_location`
--
ALTER TABLE `computer_location`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `loan_app`
--
ALTER TABLE `loan_app`
  MODIFY `id` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `loan_types`
--
ALTER TABLE `loan_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `member_profile`
--
ALTER TABLE `member_profile`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

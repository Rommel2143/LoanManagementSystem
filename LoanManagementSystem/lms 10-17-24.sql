-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2024 at 04:35 PM
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
(3, 'Insurance'),
(4, 'Other');

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
  `insurance_fee` decimal(8,2) NOT NULL,
  `interest` decimal(8,2) NOT NULL,
  `date_apply` date NOT NULL,
  `date_approved` date DEFAULT NULL,
  `date_release` date DEFAULT NULL,
  `date_start` date DEFAULT NULL,
  `months_count` int(4) NOT NULL,
  `teller` varchar(100) NOT NULL,
  `teller_approved` varchar(100) NOT NULL,
  `teller_release` varchar(30) NOT NULL,
  `mode` varchar(30) NOT NULL,
  `purpose` varchar(30) NOT NULL,
  `collateral` varchar(100) NOT NULL,
  `collateral_value` decimal(9,2) NOT NULL,
  `comaker_1` varchar(100) NOT NULL,
  `comaker_2` varchar(100) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loan_app`
--

INSERT INTO `loan_app` (`id`, `referenceno`, `account_no`, `amount`, `ammortization`, `interest_rate`, `service_fee`, `insurance_fee`, `interest`, `date_apply`, `date_approved`, `date_release`, `date_start`, `months_count`, `teller`, `teller_approved`, `teller_release`, `mode`, `purpose`, `collateral`, `collateral_value`, `comaker_1`, `comaker_2`, `status`) VALUES
(30, 'LPCA-387584-24', '03200728', 10000.00, 192.97, 0.15, 300.00, 0.00, 6209.48, '2024-09-19', '2024-09-19', '2024-09-22', NULL, 84, '03200728', '03200728', '03200728', 'Cash', 'Car Loan', 'Real State', 10000.00, '', '', 2),
(31, 'LUOE-139920-24', '03200729', 100000.00, 9025.83, 0.15, 3000.00, 100.00, 8309.96, '2024-09-18', '2024-09-18', '2024-09-22', NULL, 12, '03200728', '03200728', '03200728', 'Cash', 'Car Loan', 'Vehicle', 10000.00, '', '', 2),
(32, 'LEZS-746075-24', '03200728', 1000000.00, 27830.75, 0.15, 30000.00, 0.00, 335876.00, '2024-09-19', NULL, '2024-09-22', NULL, 48, '03200728', '', '03200728', 'Cash', 'Car Loan', 'Real State', 10000.00, '', '', 2),
(33, 'LPAN-256661-24', '03200728', 0.00, 0.00, 0.15, 0.00, 0.00, 0.00, '2024-09-20', NULL, '2024-09-22', NULL, 1, '03200728', '', '03200728', 'Cash', 'Car Loan', 'Vehicle', 0.00, '', '', 2),
(34, 'LCDR-331142-24', '03200728', 10000.00, 484.87, 0.15, 300.00, 0.00, 1636.88, '2024-09-20', '2024-09-22', '2024-09-22', NULL, 24, '03200728', '03200728', '03200728', 'Cash', 'Car Loan', 'Insurance', 0.00, '', '', 2),
(35, 'LCKS-022983-24', '03200728', 10000.00, 902.58, 0.15, 300.00, 0.00, 830.96, '2024-10-14', NULL, NULL, NULL, 12, '03200728', '', '', 'Cash', 'Car Loan', 'Real State', 100000.00, '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `loan_collection`
--

CREATE TABLE `loan_collection` (
  `id` int(11) NOT NULL,
  `referenceno` varchar(15) NOT NULL,
  `account_no` varchar(20) NOT NULL,
  `date_month` date NOT NULL,
  `ammortization` decimal(8,2) NOT NULL,
  `due_fines` decimal(8,2) NOT NULL,
  `teller` varchar(15) NOT NULL,
  `date_paid` date DEFAULT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loan_collection`
--

INSERT INTO `loan_collection` (`id`, `referenceno`, `account_no`, `date_month`, `ammortization`, `due_fines`, `teller`, `date_paid`, `status`) VALUES
(205, 'LPCA-387584-24', '03200728', '2024-10-22', 192.97, 0.00, '', '2024-09-22', 1),
(206, 'LPCA-387584-24', '03200728', '2024-11-22', 192.97, 0.00, '', '2024-09-22', 1),
(207, 'LPCA-387584-24', '03200728', '2024-12-22', 192.97, 0.00, '', '2024-09-22', 1),
(208, 'LPCA-387584-24', '03200728', '2025-01-22', 192.97, 0.00, '', '2024-09-22', 1),
(209, 'LPCA-387584-24', '03200728', '2025-02-22', 192.97, 0.00, '', '2024-09-22', 1),
(210, 'LPCA-387584-24', '03200728', '2025-03-22', 192.97, 0.00, '', '2024-09-22', 1),
(211, 'LPCA-387584-24', '03200728', '2025-04-22', 192.97, 0.00, '', '2024-09-22', 1),
(212, 'LPCA-387584-24', '03200728', '2025-05-22', 192.97, 0.00, '', '2024-09-22', 1),
(213, 'LPCA-387584-24', '03200728', '2025-06-22', 192.97, 0.00, '', '2024-09-22', 1),
(214, 'LPCA-387584-24', '03200728', '2025-07-22', 192.97, 0.00, '', '2024-09-22', 1),
(215, 'LPCA-387584-24', '03200728', '2025-08-22', 192.97, 0.00, '', '2024-09-22', 1),
(216, 'LPCA-387584-24', '03200728', '2025-09-22', 192.97, 0.00, '', '2024-09-22', 1),
(217, 'LPCA-387584-24', '03200728', '2025-10-22', 192.97, 0.00, '', '2024-09-22', 1),
(218, 'LPCA-387584-24', '03200728', '2025-11-22', 192.97, 0.00, '', '2024-09-22', 1),
(219, 'LPCA-387584-24', '03200728', '2025-12-22', 192.97, 0.00, '', '2024-09-22', 1),
(220, 'LPCA-387584-24', '03200728', '2026-01-22', 192.97, 0.00, '', '2024-09-22', 1),
(221, 'LPCA-387584-24', '03200728', '2026-02-22', 192.97, 0.00, '', '2024-09-22', 1),
(222, 'LPCA-387584-24', '03200728', '2026-03-22', 192.97, 0.00, '', '2024-09-22', 1),
(223, 'LPCA-387584-24', '03200728', '2026-04-22', 192.97, 0.00, '', '2024-09-22', 1),
(224, 'LPCA-387584-24', '03200728', '2026-05-22', 192.97, 0.00, '', '2024-09-22', 1),
(225, 'LPCA-387584-24', '03200728', '2026-06-22', 192.97, 0.00, '', '2024-09-22', 1),
(226, 'LPCA-387584-24', '03200728', '2026-07-22', 192.97, 0.00, '', '2024-09-22', 1),
(227, 'LPCA-387584-24', '03200728', '2026-08-22', 192.97, 0.00, '', '2024-09-22', 1),
(228, 'LPCA-387584-24', '03200728', '2026-09-22', 192.97, 0.00, '', '2024-09-22', 1),
(229, 'LPCA-387584-24', '03200728', '2026-10-22', 192.97, 0.00, '', '2024-09-22', 1),
(230, 'LPCA-387584-24', '03200728', '2026-11-22', 192.97, 0.00, '', '2024-09-22', 1),
(231, 'LPCA-387584-24', '03200728', '2026-12-22', 192.97, 0.00, '', '2024-09-22', 1),
(232, 'LPCA-387584-24', '03200728', '2027-01-22', 192.97, 0.00, '', '2024-09-22', 1),
(233, 'LPCA-387584-24', '03200728', '2027-02-22', 192.97, 0.00, '', '2024-09-22', 1),
(234, 'LPCA-387584-24', '03200728', '2027-03-22', 192.97, 0.00, '', '2024-09-22', 1),
(235, 'LPCA-387584-24', '03200728', '2027-04-22', 192.97, 0.00, '', '2024-09-22', 1),
(236, 'LPCA-387584-24', '03200728', '2027-05-22', 192.97, 0.00, '', '2024-09-22', 1),
(237, 'LPCA-387584-24', '03200728', '2027-06-22', 192.97, 0.00, '', '2024-10-14', 1),
(238, 'LPCA-387584-24', '03200728', '2027-07-22', 192.97, 0.00, '', '2024-10-14', 1),
(239, 'LPCA-387584-24', '03200728', '2027-08-22', 192.97, 0.00, '', NULL, 0),
(240, 'LPCA-387584-24', '03200728', '2027-09-22', 192.97, 0.00, '', NULL, 0),
(241, 'LPCA-387584-24', '03200728', '2027-10-22', 192.97, 0.00, '', NULL, 0),
(242, 'LPCA-387584-24', '03200728', '2027-11-22', 192.97, 0.00, '', NULL, 0),
(243, 'LPCA-387584-24', '03200728', '2027-12-22', 192.97, 0.00, '', NULL, 0),
(244, 'LPCA-387584-24', '03200728', '2028-01-22', 192.97, 0.00, '', NULL, 0),
(245, 'LPCA-387584-24', '03200728', '2028-02-22', 192.97, 0.00, '', NULL, 0),
(246, 'LPCA-387584-24', '03200728', '2028-03-22', 192.97, 0.00, '', NULL, 0),
(247, 'LPCA-387584-24', '03200728', '2028-04-22', 192.97, 0.00, '', NULL, 0),
(248, 'LPCA-387584-24', '03200728', '2028-05-22', 192.97, 0.00, '', NULL, 0),
(249, 'LPCA-387584-24', '03200728', '2028-06-22', 192.97, 0.00, '', NULL, 0),
(250, 'LPCA-387584-24', '03200728', '2028-07-22', 192.97, 0.00, '', NULL, 0),
(251, 'LPCA-387584-24', '03200728', '2028-08-22', 192.97, 0.00, '', NULL, 0),
(252, 'LPCA-387584-24', '03200728', '2028-09-22', 192.97, 0.00, '', NULL, 0),
(253, 'LPCA-387584-24', '03200728', '2028-10-22', 192.97, 0.00, '', NULL, 0),
(254, 'LPCA-387584-24', '03200728', '2028-11-22', 192.97, 0.00, '', NULL, 0),
(255, 'LPCA-387584-24', '03200728', '2028-12-22', 192.97, 0.00, '', NULL, 0),
(256, 'LPCA-387584-24', '03200728', '2029-01-22', 192.97, 0.00, '', NULL, 0),
(257, 'LPCA-387584-24', '03200728', '2029-02-22', 192.97, 0.00, '', NULL, 0),
(258, 'LPCA-387584-24', '03200728', '2029-03-22', 192.97, 0.00, '', NULL, 0),
(259, 'LPCA-387584-24', '03200728', '2029-04-22', 192.97, 0.00, '', NULL, 0),
(260, 'LPCA-387584-24', '03200728', '2029-05-22', 192.97, 0.00, '', NULL, 0),
(261, 'LPCA-387584-24', '03200728', '2029-06-22', 192.97, 0.00, '', NULL, 0),
(262, 'LPCA-387584-24', '03200728', '2029-07-22', 192.97, 0.00, '', NULL, 0),
(263, 'LPCA-387584-24', '03200728', '2029-08-22', 192.97, 0.00, '', NULL, 0),
(264, 'LPCA-387584-24', '03200728', '2029-09-22', 192.97, 0.00, '', NULL, 0),
(265, 'LPCA-387584-24', '03200728', '2029-10-22', 192.97, 0.00, '', NULL, 0),
(266, 'LPCA-387584-24', '03200728', '2029-11-22', 192.97, 0.00, '', NULL, 0),
(267, 'LPCA-387584-24', '03200728', '2029-12-22', 192.97, 0.00, '', NULL, 0),
(268, 'LPCA-387584-24', '03200728', '2030-01-22', 192.97, 0.00, '', NULL, 0),
(269, 'LPCA-387584-24', '03200728', '2030-02-22', 192.97, 0.00, '', NULL, 0),
(270, 'LPCA-387584-24', '03200728', '2030-03-22', 192.97, 0.00, '', NULL, 0),
(271, 'LPCA-387584-24', '03200728', '2030-04-22', 192.97, 0.00, '', NULL, 0),
(272, 'LPCA-387584-24', '03200728', '2030-05-22', 192.97, 0.00, '', NULL, 0),
(273, 'LPCA-387584-24', '03200728', '2030-06-22', 192.97, 0.00, '', NULL, 0),
(274, 'LPCA-387584-24', '03200728', '2030-07-22', 192.97, 0.00, '', NULL, 0),
(275, 'LPCA-387584-24', '03200728', '2030-08-22', 192.97, 0.00, '', NULL, 0),
(276, 'LPCA-387584-24', '03200728', '2030-09-22', 192.97, 0.00, '', NULL, 0),
(277, 'LPCA-387584-24', '03200728', '2030-10-22', 192.97, 0.00, '', NULL, 0),
(278, 'LPCA-387584-24', '03200728', '2030-11-22', 192.97, 0.00, '', NULL, 0),
(279, 'LPCA-387584-24', '03200728', '2030-12-22', 192.97, 0.00, '', NULL, 0),
(280, 'LPCA-387584-24', '03200728', '2031-01-22', 192.97, 0.00, '', NULL, 0),
(281, 'LPCA-387584-24', '03200728', '2031-02-22', 192.97, 0.00, '', NULL, 0),
(282, 'LPCA-387584-24', '03200728', '2031-03-22', 192.97, 0.00, '', NULL, 0),
(283, 'LPCA-387584-24', '03200728', '2031-04-22', 192.97, 0.00, '', NULL, 0),
(284, 'LPCA-387584-24', '03200728', '2031-05-22', 192.97, 0.00, '', NULL, 0),
(285, 'LPCA-387584-24', '03200728', '2031-06-22', 192.97, 0.00, '', NULL, 0),
(286, 'LPCA-387584-24', '03200728', '2031-07-22', 192.97, 0.00, '', NULL, 0),
(287, 'LPCA-387584-24', '03200728', '2031-08-22', 192.97, 0.00, '', NULL, 0),
(288, 'LUOE-139920-24', '03200729', '2024-10-22', 9025.83, 0.00, '', '2024-09-22', 1),
(289, 'LUOE-139920-24', '03200729', '2024-11-22', 9025.83, 0.00, '', '2024-09-22', 1),
(290, 'LUOE-139920-24', '03200729', '2024-12-22', 9025.83, 0.00, '', '2024-09-22', 1),
(291, 'LUOE-139920-24', '03200729', '2025-01-22', 9025.83, 0.00, '', '2024-09-22', 1),
(292, 'LUOE-139920-24', '03200729', '2025-02-22', 9025.83, 0.00, '', '2024-09-22', 1),
(293, 'LUOE-139920-24', '03200729', '2025-03-22', 9025.83, 0.00, '', '2024-09-22', 1),
(294, 'LUOE-139920-24', '03200729', '2025-04-22', 9025.83, 0.00, '', '2024-09-22', 1),
(295, 'LUOE-139920-24', '03200729', '2025-05-22', 9025.83, 0.00, '', '2024-09-22', 1),
(296, 'LUOE-139920-24', '03200729', '2025-06-22', 9025.83, 0.00, '', '2024-09-22', 1),
(297, 'LUOE-139920-24', '03200729', '2025-07-22', 9025.83, 0.00, '', '2024-09-22', 1),
(298, 'LUOE-139920-24', '03200729', '2025-08-22', 9025.83, 0.00, '', '2024-09-22', 1);

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
  `sharecap` decimal(9,2) NOT NULL,
  `savings` decimal(9,2) NOT NULL,
  `image` blob NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `member_profile`
--

INSERT INTO `member_profile` (`id`, `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `gender`, `place_birth`, `present_address`, `contact1`, `contact2`, `emp_status`, `idtype`, `idtype_no`, `sharecap`, `savings`, `image`, `status`) VALUES
(21, '03200728', 'Rommel', 'Cueto', 'Magnaye', '1998-04-03', 'S', 'M', '', '', '', '', '', '', '', 0.00, 0.00, '', 1),
(22, '03200729', 'Juan', 'De la', 'Cruz', '2000-04-03', 'S', 'M', '', '', '', '', '', '', '', 0.00, 0.00, '', 1),
(23, '03200730', 'Maria', 'De la', 'Clara', '1968-04-03', 'S', 'F', '', '', '', '', '', '', '', 0.00, 0.00, '', 1);

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
(19, 'D-FHG580-24', '03200728', '2024-10-17', '20:47:00', 1000.00, 'ID', '03200728'),
(20, 'D-ZLK763-24', '03200728', '2024-10-17', '20:47:00', 1000.00, 'CD', '03200728'),
(21, 'D-DSI095-24', '03200728', '2024-10-17', '20:47:00', 1000.00, 'CHKD', '03200728'),
(22, 'W-LZD672-24', '03200728', '2024-10-17', '20:52:00', 1000.00, 'CW', '03200728'),
(23, 'W-JYP629-24', '03200728', '2024-10-17', '20:54:00', 1000.00, 'CW', '03200728'),
(26, 'W-UZE188-24', '03200728', '2024-10-17', '21:00:00', 1000.00, 'CHKW', '03200728'),
(27, 'D-EJG722-24', '03200728', '2024-10-17', '21:10:00', 1000.00, 'CD', '03200728');

-- --------------------------------------------------------

--
-- Table structure for table `sharecap`
--

CREATE TABLE `sharecap` (
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
-- Dumping data for table `sharecap`
--

INSERT INTO `sharecap` (`id`, `referenceno`, `account_no`, `date_transac`, `time`, `amount`, `status`, `teller`) VALUES
(10, 'SC-VQC713-24', '03200728', '2024-10-17', '22:09:00', 1000.00, 'CA', '03200728'),
(11, 'SC-NFO855-24', '03200728', '2024-10-17', '22:09:00', 10000.00, 'ID', '03200728'),
(12, 'SC-QPW412-24', '03200728', '2024-10-17', '22:19:00', 10000.00, 'CA', '03200728'),
(13, 'SC-KPN194-24', '03200728', '2024-10-17', '22:24:00', 2342467.00, 'ID', '03200728');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `account_no` varchar(20) NOT NULL,
  `username` varchar(100) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `level` int(3) NOT NULL,
  `loan_apply` int(1) NOT NULL DEFAULT 0,
  `loan_approve` int(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `account_no`, `username`, `pass`, `level`, `loan_apply`, `loan_approve`) VALUES
(1, '03200728', 'momel', '123', 0, 0, 0);

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
-- Indexes for table `loan_collection`
--
ALTER TABLE `loan_collection`
  ADD PRIMARY KEY (`id`);

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
-- Indexes for table `savings`
--
ALTER TABLE `savings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sharecap`
--
ALTER TABLE `sharecap`
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `computer_location`
--
ALTER TABLE `computer_location`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `loan_app`
--
ALTER TABLE `loan_app`
  MODIFY `id` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `loan_collection`
--
ALTER TABLE `loan_collection`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=299;

--
-- AUTO_INCREMENT for table `loan_types`
--
ALTER TABLE `loan_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `member_profile`
--
ALTER TABLE `member_profile`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `savings`
--
ALTER TABLE `savings`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `sharecap`
--
ALTER TABLE `sharecap`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

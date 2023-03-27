-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 27, 2023 at 08:59 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vehicle_spareparts_shop`
--

-- --------------------------------------------------------

--
-- Table structure for table `bike_product`
--

CREATE TABLE `bike_product` (
  `id` int(50) NOT NULL,
  `name` varchar(250) NOT NULL,
  `image` varchar(1000) NOT NULL,
  `price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bike_product`
--

INSERT INTO `bike_product` (`id`, `name`, `image`, `price`) VALUES
(1, 'bajaj wheel sockets', 'bajaj wheel sockets.jpg', 2000),
(2, 'bajaj wheel choke caable', 'bajaj wheel choke caable.jpg', 3000),
(3, 'Head Light', 'head lights.jpeg', 2000),
(4, 'Bajaj Wheel Tail Light', 'bajaj wheel tail lights.jpg', 2300),
(5, 'Bajaj Sockets', 'bajaj wheel sockets.jpg', 1700),
(6, 'Mud Guard', 'mud guard.jpg', 1500),
(7, 'Three Wheel Seat', 'three wheel seat.jpg', 2100),
(8, 'Bajaj Pivot Pin', 'bajaj pivot pin.jpg', 1800),
(9, 'Side Mirror', 'x9.jpg', 2700);

-- --------------------------------------------------------

--
-- Table structure for table `catagory_detail`
--

CREATE TABLE `catagory_detail` (
  `catagory_id` int(11) NOT NULL,
  `catagory_name` varchar(250) NOT NULL,
  `description` varchar(450) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `catagory_detail`
--

INSERT INTO `catagory_detail` (`catagory_id`, `catagory_name`, `description`) VALUES
(1, 'bike', 'all bike spareparts'),
(3, 'threewheel', 'all thereweel parts');

-- --------------------------------------------------------

--
-- Table structure for table `customer_detail`
--

CREATE TABLE `customer_detail` (
  `cus_reg_id` int(11) NOT NULL,
  `cus_name` varchar(250) NOT NULL,
  `cus_address` varchar(450) NOT NULL,
  `cus_phone` int(11) NOT NULL,
  `cus_email` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer_detail`
--

INSERT INTO `customer_detail` (`cus_reg_id`, `cus_name`, `cus_address`, `cus_phone`, `cus_email`) VALUES
(4, 'Tharangani', 'galle', 764591149, 'tharangani@gmail.com'),
(5, 'kamal', 'galle', 763456778, 'kamal@gmail.com'),
(7, 'nimal', 'matara', 764567789, 'nimal@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `employee_detail`
--

CREATE TABLE `employee_detail` (
  `employee_id` varchar(50) NOT NULL,
  `employee_name` varchar(250) NOT NULL,
  `employee_email` varchar(150) NOT NULL,
  `employee_address` varchar(400) NOT NULL,
  `employee_contact` int(11) NOT NULL,
  `role_name` varchar(100) NOT NULL,
  `role_description` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_detail`
--

INSERT INTO `employee_detail` (`employee_id`, `employee_name`, `employee_email`, `employee_address`, `employee_contact`, `role_name`, `role_description`) VALUES
('E001', 'admin', 'admin@gmail.com', 'galle', 764598867, 'admin', 'manage all task'),
('E002', 'tharangani', 'tharangani@gmail.com', 'galle', 764572234, 'stock keper', 'manage stock'),
('E003', 'hansani', 'hansani@gmail.com', 'galle', 786547890, 'stock keeper', 'manage stock');

-- --------------------------------------------------------

--
-- Table structure for table `employee_login_detail`
--

CREATE TABLE `employee_login_detail` (
  `emp_id` varchar(50) NOT NULL,
  `emp_user_name` varchar(250) NOT NULL,
  `emp_password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_login_detail`
--

INSERT INTO `employee_login_detail` (`emp_id`, `emp_user_name`, `emp_password`) VALUES
('E001', 'admin', 'admin'),
('E002', 'tharangani', 'tharangani@123'),
('E003', 'hansani', 'hansani@123');

-- --------------------------------------------------------

--
-- Table structure for table `online_customer_detail`
--

CREATE TABLE `online_customer_detail` (
  `cus_id` int(11) NOT NULL,
  `cus_name` varchar(250) NOT NULL,
  `cus_address` varchar(300) NOT NULL,
  `cus_phone` bigint(20) NOT NULL,
  `cus_email` varchar(150) NOT NULL,
  `cus_user_name` varchar(150) NOT NULL,
  `cus_password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `online_customer_detail`
--

INSERT INTO `online_customer_detail` (`cus_id`, `cus_name`, `cus_address`, `cus_phone`, `cus_email`, `cus_user_name`, `cus_password`) VALUES
(1, 'tharangani', 'galle', 764591147, 'tharangani@gmail.com', 'tharangani', 'tharangani@123'),
(4, 'kamal', 'galle', 764591147, 'kamal@gmai.com', 'kamal', 'kamal'),
(6, 'hansani', 'galle', 764591147, 'hansani@gmail.com', 'hansani', 'hansani@123');

-- --------------------------------------------------------

--
-- Table structure for table `online_order_details`
--

CREATE TABLE `online_order_details` (
  `id` int(11) NOT NULL,
  `cus_fullname` varchar(250) NOT NULL,
  `cus_email` varchar(200) NOT NULL,
  `cus_address` varchar(400) NOT NULL,
  `cus_city` varchar(150) NOT NULL,
  `name_on_card` varchar(150) NOT NULL,
  `credit_card_number` varchar(150) NOT NULL,
  `exp_month` varchar(30) NOT NULL,
  `exp_year` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `online_order_details`
--

INSERT INTO `online_order_details` (`id`, `cus_fullname`, `cus_email`, `cus_address`, `cus_city`, `name_on_card`, `credit_card_number`, `exp_month`, `exp_year`) VALUES
(1, 'uu', 'uu', 'uu', 'uu', 'ii', 'ii', 'ii', 'ii'),
(2, 'gg', 'tharangijayamuthu@gmail.com', 'jjj', 'Matara', 'jj', 'pp', 'pp', 'pp');

-- --------------------------------------------------------

--
-- Table structure for table `order_detail`
--

CREATE TABLE `order_detail` (
  `order_id` int(11) NOT NULL,
  `order_type` varchar(100) NOT NULL,
  `order_date` varchar(100) NOT NULL,
  `total_quantity` int(11) NOT NULL,
  `cus_reg_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order_detail`
--

INSERT INTO `order_detail` (`order_id`, `order_type`, `order_date`, `total_quantity`, `cus_reg_id`) VALUES
(4, 'offline', '10/22/2021 8:36:38 AM', 4, 4),
(8, 'offline', '25-10-2021', 3, 5),
(10, 'offline', '26-10-2021', 2, 7);

-- --------------------------------------------------------

--
-- Table structure for table `order_item_detail`
--

CREATE TABLE `order_item_detail` (
  `order_detail_id` int(11) NOT NULL,
  `pro_name` varchar(255) NOT NULL,
  `quantity` double NOT NULL,
  `discount` double NOT NULL,
  `order_id` int(11) NOT NULL,
  `pro_id` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order_item_detail`
--

INSERT INTO `order_item_detail` (`order_detail_id`, `pro_name`, `quantity`, `discount`, `order_id`, `pro_id`) VALUES
(6, 'bike tire', 2, 1000, 4, 'P1'),
(7, 'bike horn', 1, 0, 4, 'P2'),
(8, 'choke cable', 1, 10, 4, 'P3'),
(9, 'wheel tire', 1, 1000, 4, 'P4'),
(10, 'choke cable', 1, 0, 8, 'P3'),
(11, 'bike tire', 1, 200, 8, 'P1'),
(12, 'bike horn', 2, 100, 8, 'P2'),
(13, 'choke cable', 1, 0, 10, 'P3'),
(14, 'wheel tire', 1, 1000, 10, 'P4');

-- --------------------------------------------------------

--
-- Table structure for table `order_payment_detail`
--

CREATE TABLE `order_payment_detail` (
  `pay_id` int(11) NOT NULL,
  `pay_ammount` double NOT NULL,
  `pay_type` varchar(100) NOT NULL,
  `date` varchar(100) NOT NULL,
  `order_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order_payment_detail`
--

INSERT INTO `order_payment_detail` (`pay_id`, `pay_ammount`, `pay_type`, `date`, `order_id`) VALUES
(5, 20000, 'Cash', '26-10-2021', 4),
(6, 15000, 'Card', '26-10-2021', 8),
(7, 10000, 'Cash', '26-10-2021', 10);

-- --------------------------------------------------------

--
-- Table structure for table `product_detail`
--

CREATE TABLE `product_detail` (
  `pro_id` varchar(50) NOT NULL,
  `model_no` varchar(150) NOT NULL,
  `model_name` varchar(300) NOT NULL,
  `total_quantity` double NOT NULL,
  `size` varchar(150) NOT NULL,
  `unit_price` double NOT NULL,
  `catagory_id` int(11) NOT NULL,
  `supply_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product_detail`
--

INSERT INTO `product_detail` (`pro_id`, `model_no`, `model_name`, `total_quantity`, `size`, `unit_price`, `catagory_id`, `supply_id`) VALUES
('P1', '789u', 'bike tire', 40, 'large', 6000, 1, 1),
('P2', 'H456', 'bike horn', 30, 'medium', 290, 1, 3),
('P3', 'C457', 'choke cable', 20, 'small', 789, 3, 4),
('P4', 'W890', 'wheel tire', 10, 'large', 8900, 3, 4);

-- --------------------------------------------------------

--
-- Table structure for table `supply_detail`
--

CREATE TABLE `supply_detail` (
  `supply_id` int(11) NOT NULL,
  `suppiy_name` varchar(250) NOT NULL,
  `supply_phone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supply_detail`
--

INSERT INTO `supply_detail` (`supply_id`, `suppiy_name`, `supply_phone`) VALUES
(1, 'kamal', 786547789),
(3, 'nimal', 765453345),
(4, 'perera', 786546678);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product`
--

CREATE TABLE `tbl_product` (
  `id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL,
  `price` double NOT NULL,
  `image` varchar(10000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_product`
--

INSERT INTO `tbl_product` (`id`, `name`, `price`, `image`) VALUES
(1, 'CT100 Headlight', 4500, 'ct100 headlight.jpg'),
(3, 'Bajaj DPMC', 200, 'bajaj DPMC.jpg'),
(4, 'Bajaj Pivot Pin', 232, 'bajaj pivot pin.jpg'),
(5, 'Horn', 500, 'horn.jpg'),
(6, 'Spot Light', 1600, 'sport light.jpg'),
(7, 'CT100 Petral Tank', 3100, 'ct100petraltank.jpg'),
(8, 'CT 100 TilePannel', 3000, 'ct100tilepannel.jpg'),
(9, 'CT100 Speedometer', 3200, 'ct100speedmeter.jpg'),
(10, 'Signal Light', 2200, '2.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bike_product`
--
ALTER TABLE `bike_product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `catagory_detail`
--
ALTER TABLE `catagory_detail`
  ADD PRIMARY KEY (`catagory_id`);

--
-- Indexes for table `customer_detail`
--
ALTER TABLE `customer_detail`
  ADD PRIMARY KEY (`cus_reg_id`);

--
-- Indexes for table `employee_detail`
--
ALTER TABLE `employee_detail`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `employee_login_detail`
--
ALTER TABLE `employee_login_detail`
  ADD PRIMARY KEY (`emp_id`),
  ADD UNIQUE KEY `emp_password` (`emp_password`);

--
-- Indexes for table `online_customer_detail`
--
ALTER TABLE `online_customer_detail`
  ADD PRIMARY KEY (`cus_id`),
  ADD UNIQUE KEY `cus_password` (`cus_password`);

--
-- Indexes for table `online_order_details`
--
ALTER TABLE `online_order_details`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `order_detail`
--
ALTER TABLE `order_detail`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `order_item_detail`
--
ALTER TABLE `order_item_detail`
  ADD PRIMARY KEY (`order_detail_id`);

--
-- Indexes for table `order_payment_detail`
--
ALTER TABLE `order_payment_detail`
  ADD PRIMARY KEY (`pay_id`);

--
-- Indexes for table `product_detail`
--
ALTER TABLE `product_detail`
  ADD PRIMARY KEY (`pro_id`);

--
-- Indexes for table `supply_detail`
--
ALTER TABLE `supply_detail`
  ADD PRIMARY KEY (`supply_id`);

--
-- Indexes for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bike_product`
--
ALTER TABLE `bike_product`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `catagory_detail`
--
ALTER TABLE `catagory_detail`
  MODIFY `catagory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `customer_detail`
--
ALTER TABLE `customer_detail`
  MODIFY `cus_reg_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `online_customer_detail`
--
ALTER TABLE `online_customer_detail`
  MODIFY `cus_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `online_order_details`
--
ALTER TABLE `online_order_details`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `order_detail`
--
ALTER TABLE `order_detail`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `order_item_detail`
--
ALTER TABLE `order_item_detail`
  MODIFY `order_detail_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `order_payment_detail`
--
ALTER TABLE `order_payment_detail`
  MODIFY `pay_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `supply_detail`
--
ALTER TABLE `supply_detail`
  MODIFY `supply_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_product`
--
ALTER TABLE `tbl_product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

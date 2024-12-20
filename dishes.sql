-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 14, 2024 at 07:49 PM
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
-- Database: `dishes`
--

-- --------------------------------------------------------

--
-- Table structure for table `DeliveryPoint`
--

CREATE TABLE `DeliveryPoint` (
  `DeliveryPointID` int(11) NOT NULL,
  `Address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `DeliveryPoint`
--

INSERT INTO `DeliveryPoint` (`DeliveryPointID`, `Address`) VALUES
(1, '344288, г. Краснокаменск, ул. Чехова, 1'),
(2, '614164, г.Краснокаменск,  ул. Степная, 30'),
(3, '394242, г. Краснокаменск, ул. Коммунистическая, 43'),
(4, '660540, г. Краснокаменск, ул. Солнечная, 25'),
(5, '125837, г. Краснокаменск, ул. Шоссейная, 40'),
(6, '125703, г. Краснокаменск, ул. Партизанская, 49'),
(7, '625283, г. Краснокаменск, ул. Победы, 46'),
(8, '614611, г. Краснокаменск, ул. Молодежная, 50'),
(9, '454311, г.Краснокаменск, ул. Новая, 19'),
(10, '660007, г.Краснокаменск, ул. Октябрьская, 19'),
(11, '603036, г. Краснокаменск, ул. Садовая, 4'),
(12, '450983, г.Краснокаменск, ул. Комсомольская, 26'),
(13, '394782, г. Краснокаменск, ул. Чехова, 3'),
(14, '603002, г. Краснокаменск, ул. Дзержинского, 28'),
(15, '450558, г. Краснокаменск, ул. Набережная, 30'),
(16, '394060, г.Краснокаменск, ул. Фрунзе, 43'),
(17, '410661, г. Краснокаменск, ул. Школьная, 50'),
(18, '625590, г. Краснокаменск, ул. Коммунистическая, 20'),
(19, '625683, г. Краснокаменск, ул. 8 Марта'),
(20, '400562, г. Краснокаменск, ул. Зеленая, 32'),
(21, '614510, г. Краснокаменск, ул. Маяковского, 47'),
(22, '410542, г. Краснокаменск, ул. Светлая, 46'),
(23, '620839, г. Краснокаменск, ул. Цветочная, 8'),
(24, '443890, г. Краснокаменск, ул. Коммунистическая, 1'),
(25, '603379, г. Краснокаменск, ул. Спортивная, 46'),
(26, '603721, г. Краснокаменск, ул. Гоголя, 41'),
(27, '410172, г. Краснокаменск, ул. Северная, 13'),
(28, '420151, г. Краснокаменск, ул. Вишневая, 32'),
(29, '125061, г. Краснокаменск, ул. Подгорная, 8'),
(30, '630370, г. Краснокаменск, ул. Шоссейная, 24'),
(31, '614753, г. Краснокаменск, ул. Полевая, 35'),
(32, '426030, г. Краснокаменск, ул. Маяковского, 44'),
(33, '450375, г. Краснокаменск ул. Клубная, 44'),
(34, '625560, г. Краснокаменск, ул. Некрасова, 12'),
(35, '630201, г. Краснокаменск, ул. Комсомольская, 17'),
(36, '190949, г. Краснокаменск, ул. Мичурина, 26');

-- --------------------------------------------------------

--
-- Table structure for table `Order1`
--

CREATE TABLE `Order1` (
  `OrderID` int(11) NOT NULL,
  `OrderStatus` text NOT NULL,
  `OrderDate` datetime NOT NULL,
  `OrderDeliveryDate` datetime NOT NULL,
  `OrderPickupPoint` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `Order1`
--

INSERT INTO `Order1` (`OrderID`, `OrderStatus`, `OrderDate`, `OrderDeliveryDate`, `OrderPickupPoint`) VALUES
(1, 'Завершен', '2022-05-05 00:00:00', '2022-05-11 00:00:00', 13),
(2, 'Новый ', '2022-05-05 00:00:00', '2022-05-11 00:00:00', 12),
(3, 'Завершен', '2022-05-06 00:00:00', '2022-05-12 00:00:00', 13),
(4, 'Завершен', '2022-05-07 00:00:00', '2022-05-13 00:00:00', 14),
(5, 'Новый ', '2022-05-09 00:00:00', '2022-05-15 00:00:00', 15),
(6, 'Новый ', '2022-05-09 00:00:00', '2022-05-15 00:00:00', 16),
(7, 'Завершен', '2022-05-10 00:00:00', '2022-05-16 00:00:00', 16),
(8, 'Завершен', '2022-05-11 00:00:00', '2022-05-17 00:00:00', 18),
(9, 'Новый ', '2022-05-12 00:00:00', '2022-05-18 00:00:00', 20),
(10, 'Завершен', '2022-05-12 00:00:00', '2022-05-18 00:00:00', 20);

-- --------------------------------------------------------

--
-- Table structure for table `OrderProduct`
--

CREATE TABLE `OrderProduct` (
  `OrderID` int(11) NOT NULL,
  `ProductArticleNumber` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `OrderProduct`
--

INSERT INTO `OrderProduct` (`OrderID`, `ProductArticleNumber`) VALUES
(1, 'D548T5'),
(1, 'А112Т4');

-- --------------------------------------------------------

--
-- Table structure for table `Product`
--

CREATE TABLE `Product` (
  `ProductArticleNumber` varchar(100) NOT NULL,
  `ProductName` text NOT NULL,
  `ProductDescription` text NOT NULL,
  `ProductCategory` text NOT NULL,
  `ProductPhoto` blob NOT NULL,
  `ProductManufacturer` text NOT NULL,
  `ProductCost` decimal(19,4) NOT NULL,
  `ProductDiscountAmount` tinyint(4) DEFAULT NULL,
  `ProductQuantityInStock` int(11) NOT NULL,
  `ProductStatus` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `Product`
--

INSERT INTO `Product` (`ProductArticleNumber`, `ProductName`, `ProductDescription`, `ProductCategory`, `ProductPhoto`, `ProductManufacturer`, `ProductCost`, `ProductDiscountAmount`, `ProductQuantityInStock`, `ProductStatus`) VALUES
('A395T3', 'Набор кастрюль', 'Набор кастрюль Эмаль Дача 2-3194/4 белый', 'Кастрюли', '', 'Эмаль', 2150.0000, 2, 13, 'да'),
('C367R6', 'Набор кастрюль', 'Набор кастрюль Webber BE-336/6 6 пр. серебристый', 'Кастрюли', '', 'Webber', 3600.0000, 3, 7, 'да'),
('C425F8', 'Набор посуды', 'Набор обеденной посуды Mason Cash Classic 12 предметов серый', 'Посуда', '', 'Нева', 5990.0000, 5, 9, 'да'),
('C432H7', 'Набор посуды', 'Набор посуды Tefal Ingenio Red 04162820 3 пр. красный', 'Посуда', '', 'Tefal', 2700.0000, 4, 6, 'да'),
('D026R4', 'Сковорода', 'Сковорода НЕВА МЕТАЛЛ ПОСУДА Карелия 2328, 28 см', 'Сковорода', '', 'Нева', 1800.0000, 4, 2, 'да'),
('D036H2', 'Сковорода', 'Сковорода НЕВА МЕТАЛЛ ПОСУДА Алтай индукционная, 26 см', 'Сковорода', 0x4430333648322e6a7067, 'Нева', 1960.0000, 5, 12, 'да'),
('D548T5', 'Столовый сервиз', 'Столовый сервиз Luminarc Every Day G0566, 6 персон, 18 предм.', 'Сервиз', 0x4435343854352e6a7067, 'Luminarc', 1700.0000, 4, 10, 'да'),
('D630H5', 'Набор кастрюль', 'Набор кастрюль Webber BE-621/6 стальной', 'Кастрюли', '', 'Webber', 2000.0000, 3, 8, 'да'),
('D644G3', 'Набор кастрюль', 'Набор кастрюль Webber ВЕ-620/8 8 пр. стальной', 'Кастрюли', 0x4436343447332e6a7067, 'Webber', 3500.0000, 3, 8, 'да'),
('F735F5', 'Сковорода', 'Сковорода НЕВА МЕТАЛЛ ПОСУДА Домашняя 7424, съемная ручка, 24 см', 'Сковорода', 0x4637333546352e6a7067, 'Нева', 1270.0000, 2, 4, 'да'),
('F835F5', 'Набор посуды', 'Набор посуды SOLARIS S1605: 6 тарелок 180мм в контейнере', 'Сервиз', 0x4638333546352e6a7067, 'Solaris', 732.0000, 2, 9, 'да'),
('F835H6', 'Кастрюля для запекания', 'Кастрюля эмалированная, цветок Розы', 'Кастрюли', '', 'Нева', 2130.0000, 2, 5, 'да'),
('F836E5', 'Набор сковород', 'Набор сковород Tefal Ingenio Chef Red L6598672 3 пр. бордовый', 'Сковорода', 0x4638333645352e6a7067, 'Tefal', 4600.0000, 2, 6, 'да'),
('F934E5', 'Сервировочное блюдо', 'Сервировочное блюдо ROSSI для подачи из керамики 28х18 см ', 'Посуда', '', 'Нева', 1200.0000, 3, 5, 'да'),
('G405K9', 'Набор посуды', 'Набор посуды SOLARIS S1607: 6 стаканов 0,1л в контейнере', 'Посуда', '', 'Solaris', 240.0000, 4, 23, 'да'),
('H482Y6', 'Столовый сервиз', 'Столовый сервиз Luminarc Cadix L0300, 6 персон, 19 предм.', 'Сервиз', 0x4834383259362e6a7067, 'Luminarc', 2300.0000, 5, 12, 'да'),
('J468K6', 'Набор сковород', 'Набор сковород GALAXY GL9801 2 пр. синий', 'Сковорода', '', 'Galaxy', 1390.0000, 2, 13, 'да'),
('K036S3', 'Набор посуды', 'Набор посуды GALAXY GL9507 6 пр. коричневый', 'Сервиз', '', 'Galaxy', 2990.0000, 5, 15, 'да'),
('K935B6', 'Салатник', 'Салатник «Кото», 0,19 л 10 см красный, фарфор', 'Посуда', '', 'Нева', 1200.0000, 3, 9, 'да'),
('L346D4', 'Набор кружек', 'Набор кружек Pasabahce Basic, 370 мл, 2 предм., 2 персоны', 'Посуда', '', 'Нева', 329.0000, 5, 18, 'да'),
('M045H6', 'Набор кастрюль', 'Набор кастрюль СтальЭмаль 1с33/1 6 пр. белоснежный /маки ', 'Кастрюли', '', 'Эмаль', 1499.0000, 4, 7, 'да'),
('M527Y7', 'Казан', 'Казан 5 л Наша Посуда антипригарный', 'Кастрюли', '', 'Нева', 1999.0000, 3, 6, 'да'),
('N835D4', 'Набор кастрюль', 'Набор кастрюль GALAXY GL9512 4 пр. фиолетовый', 'Кастрюли', 0x4e38333544342e6a7067, 'Galaxy', 2100.0000, 3, 5, 'да'),
('N835F5', 'Кастрюля для запекания', 'Кастрюля для запекания Tefal 208AC00/1043, 2.3 л, 23 см', 'Кастрюли', 0x4e38333546352e6a7067, 'Tefal', 744.0000, 3, 13, 'да'),
('S257G5', 'Набор посуды', 'Набор посуды для выпечки O CUISINE 333SA95/6142', 'Посуда', '', 'Tefal', 2300.0000, 4, 8, 'да'),
('S306J8', 'Ковш', 'Ковш б/деколи(палевый) 17,5х8 см 1,5 л', 'Посуда', '', 'Tefal', 409.0000, 2, 14, 'да'),
('S413D4', 'Набор кастрюль', 'Набор кастрюль СтальЭмаль 7DA025S 6 пр. слоновая кость', 'Кастрюли', '', 'Эмаль', 4500.0000, 3, 15, 'да'),
('S835H6', 'Кастрюля для запекания', 'Кастрюля Scovo Expert СЭ-008, 4.5 л', 'Кастрюли', '', 'Tefal', 1600.0000, 4, 13, 'да'),
('V493H5', 'Набор посуды', 'Набор посуды Tefal Ingenio RED 9 предметов ', 'Посуда', '', 'Tefal', 6000.0000, 4, 18, 'да'),
('А112Т4', 'Набор кастрюль', 'Набор кастрюль Webber BE-335/6 6 пр. серебристый', 'Кастрюли', 0xd090313132d0a2342e6a7067, 'Webber', 2600.0000, 4, 6, 'да');

-- --------------------------------------------------------

--
-- Table structure for table `Role`
--

CREATE TABLE `Role` (
  `RoleID` int(11) NOT NULL,
  `RoleName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `Role`
--

INSERT INTO `Role` (`RoleID`, `RoleName`) VALUES
(1, 'Администратор'),
(2, 'Менеджер'),
(3, 'Клиент');

-- --------------------------------------------------------

--
-- Table structure for table `User`
--

CREATE TABLE `User` (
  `UserID` int(11) NOT NULL,
  `UserSurname` varchar(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `UserPatronymic` varchar(100) NOT NULL,
  `UserLogin` text NOT NULL,
  `UserPassword` text NOT NULL,
  `UserRole` int(11) NOT NULL DEFAULT 3
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `User`
--

INSERT INTO `User` (`UserID`, `UserSurname`, `UserName`, `UserPatronymic`, `UserLogin`, `UserPassword`, `UserRole`) VALUES
(3, 'Федоров', 'Глеб', 'Михайлович', 'o@outlook.com', '2L6KZG', 1),
(4, 'Семенова', 'Софья', 'Дмитриевна', 'hr6zdl@yandex.ru', 'uzWC67', 1),
(5, 'Васильев', 'Егор', 'Германович', 'kaft93x@outlook.com', '8ntwUp', 1),
(6, 'Смирнова', 'Ирина', 'Александровна', 'dcu@yandex.ru', 'YOyhfR', 2),
(7, 'Петров', 'Андрей', 'Владимирович', '19dn@outlook.com', 'RSbvHv', 2),
(8, 'Егоров', 'Максим', 'Андреевич', 'pa5h@mail.ru', 'rwVDh9', 2),
(9, 'Никитин', 'Артур', 'Алексеевич', '281av0@gmail.com', 'LdNyos', 3),
(10, 'Киселев', 'Максим', 'Сергеевич', '8edmfh@outlook.com', 'gynQMT', 3),
(11, 'Борисов', 'Тимур', 'Егорович', 'sfn13i@mail.ru', 'AtnDjr', 3),
(12, 'Климов', 'Арсений', 'Тимурович', 'g0orc3x1@outlook.com', 'JlFRCZ', 3),
(13, '1', '1', '1', '1', '1', 3),
(14, '1', '1', '1', '1', '1', 3),
(15, '????????', '????????', '????????????', 'test', 'testpassword', 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `DeliveryPoint`
--
ALTER TABLE `DeliveryPoint`
  ADD PRIMARY KEY (`DeliveryPointID`);

--
-- Indexes for table `Order1`
--
ALTER TABLE `Order1`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `fucker123gg` (`OrderPickupPoint`);

--
-- Indexes for table `OrderProduct`
--
ALTER TABLE `OrderProduct`
  ADD PRIMARY KEY (`OrderID`,`ProductArticleNumber`),
  ADD KEY `ProductArticleNumber` (`ProductArticleNumber`);

--
-- Indexes for table `Product`
--
ALTER TABLE `Product`
  ADD PRIMARY KEY (`ProductArticleNumber`);

--
-- Indexes for table `Role`
--
ALTER TABLE `Role`
  ADD PRIMARY KEY (`RoleID`);

--
-- Indexes for table `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`UserID`),
  ADD KEY `UserRole` (`UserRole`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `DeliveryPoint`
--
ALTER TABLE `DeliveryPoint`
  MODIFY `DeliveryPointID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `Order1`
--
ALTER TABLE `Order1`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `Role`
--
ALTER TABLE `Role`
  MODIFY `RoleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `User`
--
ALTER TABLE `User`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Order1`
--
ALTER TABLE `Order1`
  ADD CONSTRAINT `fucker123gg` FOREIGN KEY (`OrderPickupPoint`) REFERENCES `DeliveryPoint` (`DeliveryPointID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `OrderProduct`
--
ALTER TABLE `OrderProduct`
  ADD CONSTRAINT `OrderProduct_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `Order1` (`OrderID`),
  ADD CONSTRAINT `OrderProduct_ibfk_2` FOREIGN KEY (`ProductArticleNumber`) REFERENCES `Product` (`ProductArticleNumber`);

--
-- Constraints for table `User`
--
ALTER TABLE `User`
  ADD CONSTRAINT `User_ibfk_1` FOREIGN KEY (`UserRole`) REFERENCES `Role` (`RoleID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

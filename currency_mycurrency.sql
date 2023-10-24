-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: currency
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `mycurrency`
--

DROP TABLE IF EXISTS `mycurrency`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mycurrency` (
  `ValueCurrency` varchar(45) NOT NULL,
  `Date` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mycurrency`
--

LOCK TABLES `mycurrency` WRITE;
/*!40000 ALTER TABLE `mycurrency` DISABLE KEYS */;
INSERT INTO `mycurrency` VALUES ('96,0762 USD','22.09.2023'),('102,3606 EUR','22.09.2023'),('96,0419 USD','23.09.2023'),('102,2485 EUR','23.09.2023'),('96,0419 USD','24.09.2023'),('102,2485 EUR','24.09.2023'),('96,0419 USD','25.09.2023'),('102,2485 EUR','25.09.2023'),('96,1456 USD','26.09.2023'),('102,2453 EUR','26.09.2023'),('96,2378 USD','27.09.2023'),('101,9888 EUR','27.09.2023'),('96,5000 USD','28.09.2023'),('101,9780 EUR','28.09.2023'),('97,0018 USD','29.09.2023'),('102,0979 EUR','29.09.2023'),('97,4147 USD','30.09.2023'),('103,1631 EUR','30.09.2023'),('97,4147 USD','01.10.2023'),('103,1631 EUR','01.10.2023'),('97,4147 USD','02.10.2023'),('103,1631 EUR','02.10.2023'),('98,4785 USD','03.10.2023'),('103,8680 EUR','03.10.2023'),('99,2677 USD','04.10.2023'),('104,0621 EUR','04.10.2023'),('99,4555 USD','05.10.2023'),('104,3024 EUR','05.10.2023'),('99,6762 USD','06.10.2023'),('104,7877 EUR','06.10.2023'),('100,4911 USD','07.10.2023'),('106,0100 EUR','07.10.2023'),('100,4911 USD','08.10.2023'),('106,0100 EUR','08.10.2023'),('100,4911 USD','09.10.2023'),('106,0100 EUR','09.10.2023'),('101,3598 USD','10.10.2023'),('107,0322 EUR','10.10.2023'),('99,9349 USD','11.10.2023'),('105,6864 EUR','11.10.2023'),('99,9808 USD','12.10.2023'),('105,9544 EUR','12.10.2023'),('96,9948 USD','13.10.2023'),('103,0350 EUR','13.10.2023'),('97,3075 USD','14.10.2023'),('102,5523 EUR','14.10.2023'),('97,3075 USD','15.10.2023'),('102,5523 EUR','15.10.2023'),('97,3075 USD','16.10.2023'),('102,5523 EUR','16.10.2023'),('97,2865 USD','17.10.2023'),('102,5200 EUR','17.10.2023'),('97,3458 USD','18.10.2023'),('102,7527 EUR','18.10.2023'),('97,3724 USD','19.10.2023'),('102,9059 EUR','19.10.2023'),('97,3074 USD','20.10.2023'),('102,6255 EUR','20.10.2023'),('95,9053 USD','21.10.2023'),('101,4257 EUR','21.10.2023'),('95,9053 USD','22.10.2023'),('101,4257 EUR','22.10.2023'),('95,9053 USD','23.10.2023'),('101,4257 EUR','23.10.2023'),('94,7081 USD','24.10.2023'),('100,3030 EUR','24.10.2023');
/*!40000 ALTER TABLE `mycurrency` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-24 11:39:37
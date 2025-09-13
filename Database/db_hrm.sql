-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: db_hrm
-- ------------------------------------------------------
-- Server version	8.4.6

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
-- Table structure for table `tblaccount`
--

DROP TABLE IF EXISTS `tblaccount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblaccount` (
  `EmployeeID` varchar(10) NOT NULL,
  `Fname` varchar(50) NOT NULL,
  `Mname` varchar(50) DEFAULT NULL,
  `Lname` varchar(50) NOT NULL,
  `Suffix` varchar(10) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  `Sex` enum('Male','Female') NOT NULL,
  `CivilStatus` enum('Single','Married','Divorced','Widowed') NOT NULL,
  `BirthDate` date NOT NULL,
  `UserType` varchar(50) DEFAULT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  PRIMARY KEY (`EmployeeID`),
  UNIQUE KEY `Username_UNIQUE` (`Username`),
  CONSTRAINT `tblaccount_chk_1` CHECK (((`Age` >= 1) and (`Age` <= 100)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblaccount`
--

LOCK TABLES `tblaccount` WRITE;
/*!40000 ALTER TABLE `tblaccount` DISABLE KEYS */;
REPLACE INTO `tblaccount` VALUES ('2','Martha Nicole','M.','Exala',NULL,21,'Female','Single','2004-09-13','Manager','martha','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ='),('202501','Veronica','S.','Pavia',NULL,20,'Female','Single','2025-09-13','Manager','nica','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ='),('4','Mean','J.','Lego',NULL,20,'Female','Single','2005-06-24','Manager','mean','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ='),('6','Mean Dianne','J.','Lego',NULL,20,'Female','Single','2025-09-13','Manager','minmin','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=');
/*!40000 ALTER TABLE `tblaccount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblemployee`
--

DROP TABLE IF EXISTS `tblemployee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblemployee` (
  `Employee ID` int NOT NULL,
  `Full Name` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Contact Number` varchar(45) DEFAULT NULL,
  `Emergency ContactN` varchar(45) DEFAULT NULL,
  `Email Address` varchar(45) DEFAULT NULL,
  `BirthDate` varchar(45) DEFAULT NULL,
  `Age` varchar(45) DEFAULT NULL,
  `Sex` varchar(45) DEFAULT NULL,
  `Civil Status` varchar(45) DEFAULT NULL,
  `Job Title` varchar(45) DEFAULT NULL,
  `Position` varchar(45) DEFAULT NULL,
  `Date Hired` varchar(45) DEFAULT NULL,
  `Employment Status` varchar(45) DEFAULT NULL,
  `Contract Type` varchar(45) DEFAULT NULL,
  `Attendance Status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Employee ID`),
  UNIQUE KEY `Employee ID_UNIQUE` (`Employee ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblemployee`
--

LOCK TABLES `tblemployee` WRITE;
/*!40000 ALTER TABLE `tblemployee` DISABLE KEYS */;
REPLACE INTO `tblemployee` VALUES (1234,'Juan Dela Cruz',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tblemployee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltesting`
--

DROP TABLE IF EXISTS `tbltesting`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltesting` (
  `idtbltesting` int NOT NULL,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`idtbltesting`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltesting`
--

LOCK TABLES `tbltesting` WRITE;
/*!40000 ALTER TABLE `tbltesting` DISABLE KEYS */;
REPLACE INTO `tbltesting` VALUES (1234,'Juan'),(22344,'Maria');
/*!40000 ALTER TABLE `tbltesting` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-13 12:25:08

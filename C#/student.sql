-- MariaDB dump 10.17  Distrib 10.4.8-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: student
-- ------------------------------------------------------
-- Server version	10.4.8-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `student_table`
--

DROP TABLE IF EXISTS `student_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student_table` (
  `student_id` int(10) NOT NULL AUTO_INCREMENT,
  `student_name` varchar(50) NOT NULL,
  `student_father_name` varchar(50) NOT NULL,
  `student_age` int(2) NOT NULL,
  `subjects` int(2) NOT NULL,
  `class` int(2) NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_table`
--

LOCK TABLES `student_table` WRITE;
/*!40000 ALTER TABLE `student_table` DISABLE KEYS */;
INSERT INTO `student_table` VALUES (1,'aung aung','u koko',15,1,1),(2,'mg mg','u hla',22,2,2),(3,'moe moe','u aye',22,1,2),(4,'soe soe','u naung',21,2,2),(5,'koko','u yoe',12,1,1),(6,'koko','u yoe',12,1,1);
/*!40000 ALTER TABLE `student_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student_tb`
--

DROP TABLE IF EXISTS `student_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student_tb` (
  `student_id` int(5) NOT NULL AUTO_INCREMENT,
  `student_name` varchar(50) NOT NULL,
  `student_phone` varchar(15) DEFAULT NULL,
  `student_address` varchar(50) DEFAULT NULL,
  `student_gmail` varchar(50) DEFAULT NULL,
  `course` varchar(20) NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_tb`
--

LOCK TABLES `student_tb` WRITE;
/*!40000 ALTER TABLE `student_tb` DISABLE KEYS */;
/*!40000 ALTER TABLE `student_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sub1_student`
--

DROP TABLE IF EXISTS `sub1_student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sub1_student` (
  `student_id` int(2) NOT NULL AUTO_INCREMENT,
  `student_name` varchar(20) NOT NULL,
  `student_father_name` varchar(20) NOT NULL,
  `student_age` int(2) NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sub1_student`
--

LOCK TABLES `sub1_student` WRITE;
/*!40000 ALTER TABLE `sub1_student` DISABLE KEYS */;
INSERT INTO `sub1_student` VALUES (1,'aung aung','u koko',15),(3,'moe moe','u aye',22);
/*!40000 ALTER TABLE `sub1_student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sub2_student`
--

DROP TABLE IF EXISTS `sub2_student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sub2_student` (
  `student_id` int(2) NOT NULL,
  `student_name` varchar(20) NOT NULL,
  `student_father_name` varchar(20) NOT NULL,
  `student_age` int(2) NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sub2_student`
--

LOCK TABLES `sub2_student` WRITE;
/*!40000 ALTER TABLE `sub2_student` DISABLE KEYS */;
INSERT INTO `sub2_student` VALUES (2,'mg mg','u hla',22),(4,'soe soe','u naung',21);
/*!40000 ALTER TABLE `sub2_student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sub2_student2`
--

DROP TABLE IF EXISTS `sub2_student2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sub2_student2` (
  `student_id` int(2) NOT NULL,
  `student_name` varchar(20) NOT NULL,
  `student_father_name` varchar(20) NOT NULL,
  `student_age` int(2) NOT NULL,
  `subjects` int(2) NOT NULL,
  `class` int(2) NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sub2_student2`
--

LOCK TABLES `sub2_student2` WRITE;
/*!40000 ALTER TABLE `sub2_student2` DISABLE KEYS */;
INSERT INTO `sub2_student2` VALUES (2,'mg mg','u hla',22,2,2),(4,'soe soe','u naung',21,2,2);
/*!40000 ALTER TABLE `sub2_student2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_tb`
--

DROP TABLE IF EXISTS `user_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_tb` (
  `uid` int(5) NOT NULL AUTO_INCREMENT,
  `uname` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_tb`
--

LOCK TABLES `user_tb` WRITE;
/*!40000 ALTER TABLE `user_tb` DISABLE KEYS */;
INSERT INTO `user_tb` VALUES (1,'aung','123'),(2,'maung','456'),(3,'koko','789');
/*!40000 ALTER TABLE `user_tb` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-01-08 20:10:07

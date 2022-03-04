-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: salesdb
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `tabelavendas`
--

DROP TABLE IF EXISTS `tabelavendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tabelavendas` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Loja_Id` int NOT NULL,
  `Funcionario_Id` int NOT NULL,
  `Produto_Id` int NOT NULL,
  `Lucro` varchar(45) NOT NULL,
  `Data_Venda` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `FK_TV_Lojas_idx` (`Loja_Id`),
  KEY `FK_TV_Funcionarios_idx` (`Funcionario_Id`),
  KEY `FK_TV_Produto_idx` (`Produto_Id`),
  CONSTRAINT `FK_TV_Funcionarios` FOREIGN KEY (`Funcionario_Id`) REFERENCES `funcionarios` (`Id`),
  CONSTRAINT `FK_TV_Lojas` FOREIGN KEY (`Loja_Id`) REFERENCES `lojas` (`Id`),
  CONSTRAINT `FK_TV_Produto` FOREIGN KEY (`Produto_Id`) REFERENCES `produto` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tabelavendas`
--

LOCK TABLES `tabelavendas` WRITE;
/*!40000 ALTER TABLE `tabelavendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tabelavendas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-03 21:51:42

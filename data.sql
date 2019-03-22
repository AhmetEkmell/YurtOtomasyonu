-- MySQL dump 10.16  Distrib 10.1.26-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: db
-- ------------------------------------------------------
-- Server version	10.1.26-MariaDB-0+deb9u1

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
-- Table structure for table `dbo.Bolum`
--

DROP TABLE IF EXISTS `dbo.Bolum`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Bolum` (
  `Id` int(11) DEFAULT NULL,
  `Ad` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Bolum`
--

LOCK TABLES `dbo.Bolum` WRITE;
/*!40000 ALTER TABLE `dbo.Bolum` DISABLE KEYS */;
INSERT INTO `dbo.Bolum` VALUES (1,'Bilgisayar Mühensiği'),(2,'Yazılım Mühendisliği'),(3,'İnşaat Mühendisliği'),(4,'Kimya Mühendisliği'),(5,'Jeoloji Mühendisliği'),(6,'Makine Mühendisliği'),(7,'Mekatronik Mühendisliği'),(8,'Elektrik-Elektronik Mühendisliği'),(9,'İlahiyat'),(10,'Fizik'),(11,'Kimya'),(12,'Biyoloji'),(13,'Matematik'),(14,'Tıp'),(15,'Veterinerlik'),(16,'İktisat'),(17,'İşletme'),(18,'Diş Hekimliği'),(19,'Bankacılık ve Finans'),(20,'Bankacılık ve Sigortacılık');
/*!40000 ALTER TABLE `dbo.Bolum` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Gider`
--

DROP TABLE IF EXISTS `dbo.Gider`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Gider` (
  `Id` int(11) DEFAULT NULL,
  `Tur` varchar(6) DEFAULT NULL,
  `Deger` varchar(14) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Gider`
--

LOCK TABLES `dbo.Gider` WRITE;
/*!40000 ALTER TABLE `dbo.Gider` DISABLE KEYS */;
INSERT INTO `dbo.Gider` VALUES (1,'Fatura','Elektrik'),(2,'Fatura','Su'),(3,'Fatura','Doğalgaz'),(4,'Fatura','Internet'),(5,'Fatura','Gida'),(6,'Maas','MudurMaas'),(7,'Mass','MemurMaas'),(8,'Maas','TemizlikciMaas');
/*!40000 ALTER TABLE `dbo.Gider` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.GiderOdeme`
--

DROP TABLE IF EXISTS `dbo.GiderOdeme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.GiderOdeme` (
  `Id` text,
  `Tarih` text,
  `GiderId` text,
  `Miktar` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.GiderOdeme`
--

LOCK TABLES `dbo.GiderOdeme` WRITE;
/*!40000 ALTER TABLE `dbo.GiderOdeme` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.GiderOdeme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Kart`
--

DROP TABLE IF EXISTS `dbo.Kart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Kart` (
  `KartNo` int(11) DEFAULT NULL,
  `KartSahibiTc` varchar(0) DEFAULT NULL,
  `SonGiris` varchar(0) DEFAULT NULL,
  `SonCikis` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Kart`
--

LOCK TABLES `dbo.Kart` WRITE;
/*!40000 ALTER TABLE `dbo.Kart` DISABLE KEYS */;
INSERT INTO `dbo.Kart` VALUES (2147483647,'','','');
/*!40000 ALTER TABLE `dbo.Kart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Oda`
--

DROP TABLE IF EXISTS `dbo.Oda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Oda` (
  `No` int(11) DEFAULT NULL,
  `Kapasite` int(11) DEFAULT NULL,
  `Mevcut` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Oda`
--

LOCK TABLES `dbo.Oda` WRITE;
/*!40000 ALTER TABLE `dbo.Oda` DISABLE KEYS */;
INSERT INTO `dbo.Oda` VALUES (101,1,0),(102,1,0),(103,1,0),(104,1,0),(105,1,0),(201,2,0),(202,2,0),(203,2,0),(204,2,0),(205,2,0),(301,3,0),(302,3,0),(303,3,0),(304,3,0),(305,3,0),(401,4,0),(402,4,0),(403,4,0),(404,4,0),(405,4,0);
/*!40000 ALTER TABLE `dbo.Oda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Odeme`
--

DROP TABLE IF EXISTS `dbo.Odeme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Odeme` (
  `Id` text,
  `OgrenciTc` text,
  `Tarih` text,
  `Miktar` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Odeme`
--

LOCK TABLES `dbo.Odeme` WRITE;
/*!40000 ALTER TABLE `dbo.Odeme` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.Odeme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Ogrenci`
--

DROP TABLE IF EXISTS `dbo.Ogrenci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Ogrenci` (
  `Tc` text,
  `Ad` text,
  `Soyad` text,
  `DogumTarihi` text,
  `Fotograf` text,
  `Telefon` text,
  `Mail` text,
  `BolumId` text,
  `OdaNo` text,
  `KalanBorc` text,
  `VeliAd` text,
  `VeliSoyad` text,
  `VeliTelefon` text,
  `VeliAdres` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Ogrenci`
--

LOCK TABLES `dbo.Ogrenci` WRITE;
/*!40000 ALTER TABLE `dbo.Ogrenci` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.Ogrenci` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.OgrenciTakip`
--

DROP TABLE IF EXISTS `dbo.OgrenciTakip`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.OgrenciTakip` (
  `Id` text,
  `KartNo` text,
  `IslemZamani` text,
  `IslemTuru` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.OgrenciTakip`
--

LOCK TABLES `dbo.OgrenciTakip` WRITE;
/*!40000 ALTER TABLE `dbo.OgrenciTakip` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.OgrenciTakip` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Personel`
--

DROP TABLE IF EXISTS `dbo.Personel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Personel` (
  `Tc` int(11) DEFAULT NULL,
  `Ad` varchar(5) DEFAULT NULL,
  `Soyad` varchar(5) DEFAULT NULL,
  `Departman` varchar(5) DEFAULT NULL,
  `Maas` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Personel`
--

LOCK TABLES `dbo.Personel` WRITE;
/*!40000 ALTER TABLE `dbo.Personel` DISABLE KEYS */;
INSERT INTO `dbo.Personel` VALUES (2147483647,'Admin','Admin','Admin',10000);
/*!40000 ALTER TABLE `dbo.Personel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Yonetici`
--

DROP TABLE IF EXISTS `dbo.Yonetici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Yonetici` (
  `personelTc` int(11) DEFAULT NULL,
  `KullaniciAd` varchar(5) DEFAULT NULL,
  `Sifre` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Yonetici`
--

LOCK TABLES `dbo.Yonetici` WRITE;
/*!40000 ALTER TABLE `dbo.Yonetici` DISABLE KEYS */;
INSERT INTO `dbo.Yonetici` VALUES (2147483647,'admin',123456);
/*!40000 ALTER TABLE `dbo.Yonetici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.sysdiagrams`
--

DROP TABLE IF EXISTS `dbo.sysdiagrams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.sysdiagrams` (
  `name` varchar(7) DEFAULT NULL,
  `principal_id` int(11) DEFAULT NULL,
  `diagram_id` int(11) DEFAULT NULL,
  `version` int(11) DEFAULT NULL,
  `definition` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.sysdiagrams`
--

LOCK TABLES `dbo.sysdiagrams` WRITE;
/*!40000 ALTER TABLE `dbo.sysdiagrams` DISABLE KEYS */;
INSERT INTO `dbo.sysdiagrams` VALUES ('Diagram',1,2,1,'');
/*!40000 ALTER TABLE `dbo.sysdiagrams` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-09-08 22:53:52

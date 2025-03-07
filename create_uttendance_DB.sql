-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               11.7.2-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.10.0.7000
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for uttendance
CREATE DATABASE IF NOT EXISTS `uttendance` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_uca1400_ai_ci */;
USE `uttendance`;

-- Dumping structure for table uttendance.attends
CREATE TABLE IF NOT EXISTS `attends` (
  `FK_UTDID` int(11) NOT NULL,
  `FK_CourseNum` int(11) NOT NULL,
  PRIMARY KEY (`FK_UTDID`,`FK_CourseNum`),
  KEY `FK_CourseNum` (`FK_CourseNum`),
  CONSTRAINT `attends_ibfk_1` FOREIGN KEY (`FK_UTDID`) REFERENCES `student` (`UTDID`),
  CONSTRAINT `attends_ibfk_2` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.attends: ~0 rows (approximately)

-- Dumping structure for table uttendance.class
CREATE TABLE IF NOT EXISTS `class` (
  `CourseNum` int(11) NOT NULL,
  `SectionNum` int(11) DEFAULT NULL,
  `ClassSubject` varchar(5) DEFAULT NULL,
  `ClassNum` int(11) DEFAULT NULL,
  `ClassName` varchar(40) DEFAULT NULL,
  `FK_ImageID` int(11) DEFAULT NULL,
  PRIMARY KEY (`CourseNum`),
  KEY `FK_ImageID` (`FK_ImageID`),
  CONSTRAINT `class_ibfk_1` FOREIGN KEY (`FK_ImageID`) REFERENCES `images` (`ImageID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.class: ~0 rows (approximately)

-- Dumping structure for table uttendance.form
CREATE TABLE IF NOT EXISTS `form` (
  `FormID` int(11) NOT NULL,
  `PassWd` varchar(40) DEFAULT NULL,
  `ReleaseDataTime` varchar(10) DEFAULT NULL,
  `CloseDateTime` varchar(10) DEFAULT NULL,
  `FK_CourseNum` int(11) DEFAULT NULL,
  PRIMARY KEY (`FormID`),
  KEY `FK_CourseNum` (`FK_CourseNum`),
  CONSTRAINT `form_ibfk_1` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.form: ~0 rows (approximately)

-- Dumping structure for table uttendance.images
CREATE TABLE IF NOT EXISTS `images` (
  `ImageID` int(11) NOT NULL,
  `ImageBits` varbinary(256) DEFAULT NULL,
  PRIMARY KEY (`ImageID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.images: ~0 rows (approximately)

-- Dumping structure for table uttendance.instructor
CREATE TABLE IF NOT EXISTS `instructor` (
  `INetID` varchar(9) NOT NULL,
  `IFName` varchar(10) DEFAULT NULL,
  `ILName` varchar(10) DEFAULT NULL,
  `IPassword` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`INetID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.instructor: ~1 rows (approximately)
INSERT INTO `instructor` (`INetID`, `IFName`, `ILName`, `IPassword`) VALUES
	('SXH210003', 'Sooyoung', 'Han', 'sunfish');

-- Dumping structure for table uttendance.question
CREATE TABLE IF NOT EXISTS `question` (
  `QuestionID` int(11) NOT NULL,
  `ProblemStatement` varchar(200) DEFAULT NULL,
  `isCorrect` bit(1) DEFAULT NULL,
  `FK_FormID` int(11) DEFAULT NULL,
  PRIMARY KEY (`QuestionID`),
  KEY `FK_FormID` (`FK_FormID`),
  CONSTRAINT `question_ibfk_1` FOREIGN KEY (`FK_FormID`) REFERENCES `form` (`FormID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.question: ~0 rows (approximately)

-- Dumping structure for table uttendance.student
CREATE TABLE IF NOT EXISTS `student` (
  `UTDID` int(11) NOT NULL,
  `SNetID` varchar(9) DEFAULT NULL,
  `SFName` varchar(10) DEFAULT NULL,
  `SLName` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`UTDID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.student: ~7 rows (approximately)
INSERT INTO `student` (`UTDID`, `SNetID`, `SFName`, `SLName`) VALUES
	(2021188666, 'zjd130000', 'Zach', 'Dewey'),
	(2021308444, 'cab160444', 'Chase', 'Burrell'),
	(2021345555, 'nkc160199', 'Kevin', 'Chen'),
	(2021393333, 'sib170121', 'David', 'Barrameda'),
	(2021482111, 'dxa190111', 'Dhanushu', 'Priya'),
	(2021504000, 'axa190000', 'Prakash', 'Acharya'),
	(2021542222, 'nxb200088', 'Darwin', 'Bollepalli');

-- Dumping structure for table uttendance.submission
CREATE TABLE IF NOT EXISTS `submission` (
  `SubmissionID` int(11) NOT NULL,
  `AttendanceStatus` varchar(40) DEFAULT NULL,
  `IFName` varchar(10) DEFAULT NULL,
  `ILName` varchar(10) DEFAULT NULL,
  `IPAddress` varchar(32) DEFAULT NULL,
  `DatTime` varchar(80) DEFAULT NULL,
  `FK_FormID` int(11) DEFAULT NULL,
  `FK_UTDID` int(11) DEFAULT NULL,
  PRIMARY KEY (`SubmissionID`),
  KEY `FK_FormID` (`FK_FormID`),
  KEY `FK_UTDID` (`FK_UTDID`),
  CONSTRAINT `submission_ibfk_1` FOREIGN KEY (`FK_FormID`) REFERENCES `form` (`FormID`),
  CONSTRAINT `submission_ibfk_2` FOREIGN KEY (`FK_UTDID`) REFERENCES `student` (`UTDID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.submission: ~0 rows (approximately)

-- Dumping structure for table uttendance.teaches
CREATE TABLE IF NOT EXISTS `teaches` (
  `FK_INetID` varchar(9) NOT NULL,
  `FK_CourseNum` int(11) NOT NULL,
  PRIMARY KEY (`FK_CourseNum`,`FK_INetID`),
  KEY `FK_INetID` (`FK_INetID`),
  CONSTRAINT `teaches_ibfk_1` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`),
  CONSTRAINT `teaches_ibfk_2` FOREIGN KEY (`FK_INetID`) REFERENCES `instructor` (`INetID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.teaches: ~0 rows (approximately)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

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
CREATE DATABASE IF NOT EXISTS `uttendance` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci */;
USE `uttendance`;

-- Dumping structure for table uttendance.answerchoice
CREATE TABLE IF NOT EXISTS `answerchoice` (
  `AnswerID` int(11) NOT NULL AUTO_INCREMENT,
  `AnswerStatement` varchar(50) DEFAULT NULL,
  `IsCorrect` bit(1) DEFAULT NULL,
  `FK_QuestionID` int(11) DEFAULT NULL,
  PRIMARY KEY (`AnswerID`),
  KEY `FK_QuestionID` (`FK_QuestionID`),
  CONSTRAINT `answerchoice_ibfk_1` FOREIGN KEY (`FK_QuestionID`) REFERENCES `question` (`QuestionID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.answerchoice: ~29 rows 
INSERT INTO `answerchoice` (`AnswerID`, `AnswerStatement`, `IsCorrect`, `FK_QuestionID`) VALUES
	(1, 'sdf', b'1', 1),
	(2, 'sdf', b'0', 1),
	(3, 'test', b'1', 5),
	(4, 'test2', b'0', 5),
	(5, 'A', b'0', 6),
	(6, 'B', b'0', 6),
	(7, 'C', b'1', 6),
	(8, 'D', b'0', 6),
	(9, '-1', b'0', 8),
	(10, '2', b'0', 8),
	(11, '25', b'0', 8),
	(12, '999999999999999999999999999', b'1', 8),
	(13, 'fdssdf', b'1', 9),
	(14, 'sdfsdf', b'0', 9),
	(15, 'the ORV carrd', b'1', 2),
	(16, 'youtube', b'0', 2),
	(17, 'pacific ocean', b'0', 2),
	(18, '3', b'1', 3),
	(19, 'nothing bro :(', b'1', 4),
	(20, 'dfgdfg', b'0', 10),
	(21, 'dfgdfg', b'1', 10),
	(22, 'sdf', b'1', 11),
	(23, 'sdfsdf', b'0', 11),
	(24, 'dfsdfdsf', b'1', 14),
	(25, 'sdfsdf', b'0', 14),
	(26, 'Blue', b'0', 15),
	(27, 'Green', b'0', 15),
	(28, 'Yellow', b'0', 15),
	(29, 'She doesn\'t know', b'1', 15);

-- Dumping structure for table uttendance.answers
CREATE TABLE IF NOT EXISTS `answers` (
  `FK_AnswerID` int(11) NOT NULL,
  `FK_SubmissionID` int(11) NOT NULL,
   PRIMARY KEY(`FK_AnswerID`, `FK_SubmissionID`),
   KEY `FK_AnswerID` (`FK_AnswerID`),
   CONSTRAINT `answers_ibfk_1` FOREIGN KEY (`FK_AnswerID`) REFERENCES `answerchoice` (`AnswerID`),
   CONSTRAINT `answers_ibfk_2` FOREIGN KEY (`FK_SubmissionID`) REFERENCES `submission` (`submissionID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping structure for table uttendance.attends
CREATE TABLE IF NOT EXISTS `attends` (
  `FK_UTDID` int(11) NOT NULL,
  `FK_CourseNum` int(11) NOT NULL,
  PRIMARY KEY (`FK_UTDID`,`FK_CourseNum`),
  KEY `FK_CourseNum` (`FK_CourseNum`),
  CONSTRAINT `attends_ibfk_1` FOREIGN KEY (`FK_UTDID`) REFERENCES `student` (`UTDID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `attends_ibfk_2` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.attends: ~8 rows (approximately)
INSERT INTO `attends` (`FK_UTDID`, `FK_CourseNum`) VALUES
	(2021070921, 123456),
	(2021188666, 123456),
	(2021308444, 123456),
	(2021345555, 123456),
	(2021393333, 123456),
	(2021482111, 123456),
	(2021504000, 123456),
	(2021542222, 123456);

-- Dumping structure for table uttendance.class
CREATE TABLE IF NOT EXISTS `class` (
  `CourseNum` int(11) NOT NULL,
  `SectionNum` int(11) DEFAULT NULL,
  `ClassSubject` varchar(5) DEFAULT NULL,
  `ClassNum` int(11) DEFAULT NULL,
  `ClassName` varchar(40) DEFAULT NULL,
  -- Removed `FK_ImageID` int(11) DEFAULT NULL,
  `ClassStartTime` time DEFAULT NULL,
  `ClassEndTime` time DEFAULT NULL,
  PRIMARY KEY (`CourseNum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.class: ~3 rows (approximately)
INSERT INTO `class` (`CourseNum`, `SectionNum`, `ClassSubject`, `ClassNum`, `ClassName`, `ClassStartTime`, `ClassEndTime`) VALUES
	(12345, 1, 'CS', 4349, 'Advanced Algorithms', '14:30:00', '15:45:00'),
	(123456, 1, 'CS', 4384, 'Operating Systems', '10:00:00', '11:15:00'),
	(999999, 1, 'CS', 9999, 'Test Class', '11:30:00', '12:45:00');

-- Dumping structure for table uttendance.form
CREATE TABLE IF NOT EXISTS `form` (
  `FormID` int(11) NOT NULL AUTO_INCREMENT,
  `PassWd` varchar(40) DEFAULT NULL,
  `ReleaseDateTime` datetime DEFAULT NULL,
  `CloseDateTime` datetime DEFAULT NULL,
  `FK_CourseNum` int(11) DEFAULT NULL,
  PRIMARY KEY (`FormID`),
  KEY `FK_CourseNum` (`FK_CourseNum`),
  CONSTRAINT `form_ibfk_1` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.form: ~5 rows  
INSERT INTO `form` (`FormID`, `PassWd`, `ReleaseDateTime`, `CloseDateTime`, `FK_CourseNum`) VALUES
	(1, 'dfdsf', '2025-04-12 10:00:00', '2025-04-12 11:30:00', 123456),
	(2, 'test', '2025-04-14 10:00:00', '2025-04-14 11:30:00', 123456),
	(3, 'PLEASE WORK', '2025-04-16 10:00:00', '2025-04-16 11:30:00', 123456),
	(4, 'jotest', '2025-05-01 10:00:00', '2025-05-18 11:30:00', 123456),
	(5, 'letest', '2025-05-21 10:00:00', '2025-05-21 11:30:00', 123456);

-- Dumping structure for table uttendance.has
CREATE TABLE IF NOT EXISTS `has` (
  `FK_FormID` int(11) NOT NULL,
  `FK_QuestionID` int(11) NOT NULL,
  PRIMARY KEY (`FK_FormID`,`FK_QuestionID`) USING BTREE,
  KEY `FK__question` (`FK_QuestionID`),
  CONSTRAINT `FK__form` FOREIGN KEY (`FK_FormID`) REFERENCES `form` (`FormID`) ON DELETE CASCADE,
  CONSTRAINT `FK__question` FOREIGN KEY (`FK_QuestionID`) REFERENCES `question` (`QuestionID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci COMMENT='Relationship between Form and Question';

-- Dumping data for table uttendance.has: ~2 rows 
INSERT INTO `has` (`FK_FormID`, `FK_QuestionID`) VALUES
	(3, 3),
	(3, 15);

-- Dumping structure for table uttendance.instructor
CREATE TABLE IF NOT EXISTS `instructor` (
  `INetID` varchar(9) NOT NULL,
  `IFName` varchar(10) DEFAULT NULL,
  `ILName` varchar(10) DEFAULT NULL,
  `IPassword` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`INetID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.instructor: ~2 rows  
INSERT INTO `instructor` (`INetID`, `IFName`, `ILName`, `IPassword`) VALUES
	('mxm123456', 'Meow', 'Meowington', 'password'),
	('SXH210003', 'Sooyoung', 'Han', 'sunfish');

-- Dumping structure for table uttendance.qbank
CREATE TABLE IF NOT EXISTS `qbank` (
  `BankID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `BankTitle` varchar(64) DEFAULT '',
  `FK_INetID` varchar(9) NOT NULL,
  PRIMARY KEY (`BankID`),
  KEY `FK_qbank_instructor` (`FK_INetID`),
  CONSTRAINT `FK_qbank_instructor` FOREIGN KEY (`FK_INetID`) REFERENCES `instructor` (`INetID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci COMMENT='A question bank ';

-- Dumping data for table uttendance.qbank: ~5 rows (approximately)
INSERT INTO `qbank` (`BankID`, `BankTitle`, `FK_INetID`) VALUES
	(1, 'Omnisicient Reader', 'SXH210003'),
	(2, 'Three Ways to Survive in a Ruined World', 'SXH210003'),
	(3, 'I\'m Kim Dokja', 'SXH210003'),
	(4, 'Hehehe', 'mxm123456'),
	(5, 'Kekeke', 'mxm123456');

-- Dumping structure for table uttendance.question
CREATE TABLE IF NOT EXISTS `question` (
  `QuestionID` int(11) NOT NULL AUTO_INCREMENT,
  `ProblemStatement` varchar(200) DEFAULT NULL,
  `FK_BankID` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`QuestionID`),
  KEY `FK_question_qbank` (`FK_BankID`),
  CONSTRAINT `FK_question_qbank` FOREIGN KEY (`FK_BankID`) REFERENCES `qbank` (`BankID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.question: ~15 rows  
INSERT INTO `question` (`QuestionID`, `ProblemStatement`, `FK_BankID`) VALUES
	(1, 'sdf', NULL),
	(2, 'Where can you find the whole ORV webnovel?', 1),
	(3, 'What\'s Kim Dokja\'s Favorite turn?', 3),
	(4, 'What is wrong with you bro?', 1),
	(5, 'dfgdfg', NULL),
	(6, 'test', NULL),
	(7, 'do u like joannas plant', NULL),
	(8, 'what is aendris iq', NULL),
	(9, 'testq', NULL),
	(10, 'indiviudla question', NULL),
	(11, 'sdfsf', NULL),
	(12, 'NEW QUESTION', NULL),
	(13, 'sdf', NULL),
	(14, 'sdf', NULL),
	(15, 'what\'s joanna\'s favorite color', NULL);

-- Dumping structure for table uttendance.student
CREATE TABLE IF NOT EXISTS `student` (
  `UTDID` int(11) NOT NULL,
  `SNetID` varchar(9) DEFAULT NULL,
  `SFName` varchar(10) DEFAULT NULL,
  `SLName` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`UTDID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.student: ~8 rows
INSERT INTO `student` (`UTDID`, `SNetID`, `SFName`, `SLName`) VALUES
	(2021070921, 'jxy123456', 'Yaa', 'Joobie'),
	(2021188666, 'zjd130000', 'Zach', 'Dewey'),
	(2021308444, 'cab160444', 'Chase', 'Burrell'),
	(2021345555, 'nkc160199', 'Kevin', 'Chen'),
	(2021393333, 'sib170121', 'David', 'Barrameda'),
	(2021482111, 'dxa190111', 'Dhanushu', 'Priya'),
	(2021504000, 'axa190000', 'Prakash', 'Acharya'),
	(2021542222, 'nxb200088', 'Darwin', 'Bollepalli');

-- Dumping structure for table uttendance.submission
CREATE TABLE IF NOT EXISTS `submission` (
  `SubmissionID` int(11) NOT NULL AUTO_INCREMENT,
  `AttendanceStatus` varchar(40) DEFAULT NULL,
  `IPAddress` varchar(32) DEFAULT NULL,
  `DateTime` datetime DEFAULT NULL,
  `FK_FormID` int(11) DEFAULT NULL,
  `FK_UTDID` int(11) DEFAULT NULL,
  PRIMARY KEY (`SubmissionID`),
  KEY `FK_FormID` (`FK_FormID`),
  KEY `FK_UTDID` (`FK_UTDID`),
  CONSTRAINT `submission_ibfk_1` FOREIGN KEY (`FK_FormID`) REFERENCES `form` (`FormID`),
  CONSTRAINT `submission_ibfk_2` FOREIGN KEY (`FK_UTDID`) REFERENCES `student` (`UTDID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.submission: ~12 rows
INSERT INTO `submission` (`SubmissionID`, `AttendanceStatus`, `IPAddress`, `DateTime`, `FK_FormID`, `FK_UTDID`) VALUES
	(2, 'E', NULL, NULL, 2, 2021070921),
	(3, 'P', 'utd', NULL, 4, 2021188666),
	(5, 'E', 'utd', NULL, 2, 2021188666),
	(6, 'P', 'utd', NULL, 2, 2021308444),
	(7, 'P', 'utd', NULL, 1, 2021504000),
	(8, 'P', 'utd', NULL, 1, 2021393333),
	(9, 'P', 'utd', NULL, 1, 2021542222),
	(10, 'P', 'utd', NULL, 1, 2021308444),
	(11, 'P', 'utd', NULL, 1, 2021345555),
	(12, 'P', 'utd', NULL, 1, 2021188666),
	(13, 'P', 'utd', NULL, 1, 2021070921),
	(14, 'P', 'utd', NULL, 1, 2021482111);

-- Dumping structure for table uttendance.teaches
CREATE TABLE IF NOT EXISTS `teaches` (
  `FK_INetID` varchar(9) NOT NULL,
  `FK_CourseNum` int(11) NOT NULL,
  PRIMARY KEY (`FK_CourseNum`,`FK_INetID`),
  KEY `FK_INetID` (`FK_INetID`),
  CONSTRAINT `teaches_ibfk_1` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`),
  CONSTRAINT `teaches_ibfk_2` FOREIGN KEY (`FK_INetID`) REFERENCES `instructor` (`INetID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.teaches: ~4 rows (approximately)
INSERT INTO `teaches` (`FK_INetID`, `FK_CourseNum`) VALUES
	('mxm123456', 12345),
	('mxm123456', 123456),
	('SXH210003', 123456),
	('SXH210003', 999999);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

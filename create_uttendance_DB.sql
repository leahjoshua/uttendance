-- Written by Leah Joshua (lej210003) and Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
-- Starting February 27, 2025.
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

-- Dumping structure for table uttendance.answerchoice
CREATE TABLE IF NOT EXISTS `answerchoice` (
  `AnswerID` int(11) NOT NULL AUTO_INCREMENT,
  `AnswerStatement` varchar(50) DEFAULT NULL,
  `IsCorrect` bit(1) DEFAULT NULL,
  `FK_QuestionID` int(11) DEFAULT NULL,
  PRIMARY KEY (`AnswerID`),
  KEY `FK_QuestionID` (`FK_QuestionID`),
  CONSTRAINT `answerchoice_ibfk_1` FOREIGN KEY (`FK_QuestionID`) REFERENCES `question` (`QuestionID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.answerchoice: ~29 rows (approximately)
INSERT INTO `answerchoice` (`AnswerID`, `AnswerStatement`, `IsCorrect`, `FK_QuestionID`) VALUES
	(1, 'Mitochondria', b'1', 1),
	(2, 'Ribbed Cells', b'0', 1),
	(3, 'Cell', b'1', 5),
	(4, 'DNA', b'0', 5),
	(5, 'Cell Membrane', b'0', 6),
	(6, 'Cytoplasm', b'0', 6),
	(7, 'Nucleus', b'1', 6),
	(8, 'Cell Cycle', b'0', 6),
	(9, 'Mitochondrion', b'0', 8),
	(10, 'Ecosystem', b'0', 8),
	(11, 'Adaptation', b'0', 8),
	(12, 'Species', b'1', 8),
	(13, 'Population', b'1', 9),
	(14, 'Taxonomy', b'0', 9),
	(15, 'Phylogeny', b'1', 2),
	(16, 'Biochemistry', b'0', 2),
	(17, 'Genetics', b'0', 2),
	(18, 'Decomposer', b'1', 3),
	(19, 'Drug Base', b'1', 4),
	(20, 'Ectoderm', b'0', 10),
	(21, 'Electrochemical Gradient', b'1', 10),
	(22, 'Electron Acceptor', b'1', 3),
	(23, 'Electron Carrier', b'0', 3),
	(24, 'Electron Donor', b'1', 3),
	(25, 'Jejunum', b'0', 14),
	(26, 'Lipid', b'0', 15),
	(27, 'Pheromone', b'0', 15),
	(28, 'Protist', b'0', 15),
	(29, 'Ribosome', b'1', 15);

-- Dumping structure for table uttendance.answers
CREATE TABLE IF NOT EXISTS `answers` (
  `FK_AnswerID` int(11) NOT NULL,
  `FK_SubmissionID` int(11) NOT NULL,
  PRIMARY KEY (`FK_AnswerID`,`FK_SubmissionID`),
  KEY `FK_AnswerID` (`FK_AnswerID`),
  KEY `answers_ibfk_2` (`FK_SubmissionID`),
  CONSTRAINT `answers_ibfk_1` FOREIGN KEY (`FK_AnswerID`) REFERENCES `answerchoice` (`AnswerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `answers_ibfk_2` FOREIGN KEY (`FK_SubmissionID`) REFERENCES `submission` (`submissionID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.answers: ~4 rows (approximately)
INSERT INTO `answers` (`FK_AnswerID`, `FK_SubmissionID`) VALUES
	(18, 16),
	(22, 17),
	(27, 16),
	(28, 17);

-- Dumping structure for table uttendance.attends
CREATE TABLE IF NOT EXISTS `attends` (
  `FK_UTDID` int(11) NOT NULL,
  `FK_CourseNum` int(11) NOT NULL,
  PRIMARY KEY (`FK_UTDID`,`FK_CourseNum`),
  KEY `FK_CourseNum` (`FK_CourseNum`),
  CONSTRAINT `attends_ibfk_1` FOREIGN KEY (`FK_UTDID`) REFERENCES `student` (`UTDID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `attends_ibfk_2` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`) ON DELETE CASCADE ON UPDATE CASCADE
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
  `ClassStartTime` time DEFAULT NULL,
  `ClassEndTime` time DEFAULT NULL,
  PRIMARY KEY (`CourseNum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.class: ~3 rows (approximately)
INSERT INTO `class` (`CourseNum`, `SectionNum`, `ClassSubject`, `ClassNum`, `ClassName`, `ClassStartTime`, `ClassEndTime`) VALUES
	(12345, 1, 'CS', 4349, 'Advanced Algorithms', '14:30:00', '15:45:00'),
	(123456, 1, 'CS', 4384, 'Operating Systems', '10:00:00', '11:15:00'),
	(999999, 1, 'CS', 9999, 'Computer Networking', '11:30:00', '12:45:00');

-- Dumping structure for table uttendance.form
CREATE TABLE IF NOT EXISTS `form` (
  `FormID` int(11) NOT NULL AUTO_INCREMENT,
  `PassWd` varchar(40) DEFAULT NULL,
  `ReleaseDateTime` datetime DEFAULT NULL,
  `CloseDateTime` datetime DEFAULT NULL,
  `FK_CourseNum` int(11) DEFAULT NULL,
  PRIMARY KEY (`FormID`),
  KEY `FK_CourseNum` (`FK_CourseNum`),
  CONSTRAINT `form_ibfk_1` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.form: ~5 rows (approximately)
INSERT INTO `form` (`FormID`, `PassWd`, `ReleaseDateTime`, `CloseDateTime`, `FK_CourseNum`) VALUES
	(1, 'potato', '2025-04-12 10:00:00', '2025-05-22 11:30:00', 123456),
	(2, 'tomato', '2025-04-14 10:00:00', '2025-06-14 11:30:00', 123456),
	(3, 'corn', '2025-04-16 10:00:00', '2025-05-16 11:30:00', 123456),
	(4, 'cake', '2025-05-01 10:00:00', '2025-03-18 11:30:00', 123456),
	(5, 'broccoli', '2025-05-21 10:00:00', '2025-04-21 11:30:00', 123456);

-- Dumping structure for table uttendance.has
CREATE TABLE IF NOT EXISTS `has` (
  `FK_FormID` int(11) NOT NULL,
  `FK_QuestionID` int(11) NOT NULL,
  PRIMARY KEY (`FK_FormID`,`FK_QuestionID`) USING BTREE,
  KEY `FK__question` (`FK_QuestionID`),
  CONSTRAINT `FK__form` FOREIGN KEY (`FK_FormID`) REFERENCES `form` (`FormID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK__question` FOREIGN KEY (`FK_QuestionID`) REFERENCES `question` (`QuestionID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci COMMENT='Relationship between Form and Question';

-- Dumping data for table uttendance.has: ~2 rows (approximately)
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

-- Dumping data for table uttendance.instructor: ~2 rows (approximately)
INSERT INTO `instructor` (`INetID`, `IFName`, `ILName`, `IPassword`) VALUES
	('mxm123456', 'Milly', 'Meron', 'h4Ga!'),
	('sxh392287', 'Sally', 'Hemmings', 'blowupmind');

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
	(1, 'Biology', 'sxh392287'),
	(2, 'Chemistry', 'sxh392287'),
	(3, 'Cellular', 'sxh392287'),
	(4, 'Molecules', 'mxm123456'),
	(5, 'Physics', 'mxm123456');

-- Dumping structure for table uttendance.question
CREATE TABLE IF NOT EXISTS `question` (
  `QuestionID` int(11) NOT NULL AUTO_INCREMENT,
  `ProblemStatement` varchar(200) DEFAULT NULL,
  `FK_BankID` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`QuestionID`),
  KEY `FK_question_qbank` (`FK_BankID`),
  CONSTRAINT `FK_question_qbank` FOREIGN KEY (`FK_BankID`) REFERENCES `qbank` (`BankID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.question: ~5 rows (approximately)
INSERT INTO `question` (`QuestionID`, `ProblemStatement`, `FK_BankID`) VALUES
	(1, 'What is the hypothesis biology?', NULL),
	(2, 'Where is the stem cell located?', 1),
	(3, 'What is the largest nucleus structure?', 3),
	(4, 'How does molecule change between states?', 1),
	(15, 'How does an acid produce liposome?', NULL);

-- Dumping structure for table uttendance.student
CREATE TABLE IF NOT EXISTS `student` (
  `UTDID` int(11) NOT NULL,
  `SNetID` varchar(9) DEFAULT NULL,
  `SFName` varchar(10) DEFAULT NULL,
  `SLName` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`UTDID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.student: ~8 rows (approximately)
INSERT INTO `student` (`UTDID`, `SNetID`, `SFName`, `SLName`) VALUES
	(2021070921, 'jxy123456', 'Judy', 'Yan'),
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
  CONSTRAINT `submission_ibfk_1` FOREIGN KEY (`FK_FormID`) REFERENCES `form` (`FormID`) ON DELETE CASCADE ON UPDATE CASCADE, 
  CONSTRAINT `submission_ibfk_2` FOREIGN KEY (`FK_UTDID`) REFERENCES `student` (`UTDID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.submission: ~2 rows (approximately)
INSERT INTO `submission` (`SubmissionID`, `AttendanceStatus`, `IPAddress`, `DateTime`, `FK_FormID`, `FK_UTDID`) VALUES
	(16, 'P', '129.110.242.224', '2025-05-08 17:13:28', 3, 2021070921),
	(17, 'P', '129.110.242.224', '2025-05-08 17:14:41', 3, 2021188666);

-- Dumping structure for table uttendance.teaches
CREATE TABLE IF NOT EXISTS `teaches` (
  `FK_INetID` varchar(9) NOT NULL,
  `FK_CourseNum` int(11) NOT NULL,
  PRIMARY KEY (`FK_CourseNum`,`FK_INetID`),
  KEY `FK_INetID` (`FK_INetID`),
  CONSTRAINT `teaches_ibfk_1` FOREIGN KEY (`FK_CourseNum`) REFERENCES `class` (`CourseNum`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `teaches_ibfk_2` FOREIGN KEY (`FK_INetID`) REFERENCES `instructor` (`INetID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Dumping data for table uttendance.teaches: ~3 rows (approximately)
INSERT INTO `teaches` (`FK_INetID`, `FK_CourseNum`) VALUES
	('mxm123456', 12345),
	('sxh392287', 123456),
	('sxh392287', 999999);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

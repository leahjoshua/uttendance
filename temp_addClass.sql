INSERT INTO `class` (`CourseNum`, `SectionNum`, `ClassSubject`, `ClassNum`, `ClassName`, `FK_ImageID`) VALUES
	(123456, 123, 'Fic', 1863, 'Three Ways to Survive and Apocalypse', NULL);
	
INSERT INTO `teaches` (`FK_INetID`, `FK_CourseNum`) VALUES
	('SXH210003', 123456);
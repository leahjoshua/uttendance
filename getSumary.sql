SELECT 
    s.*, 
    f.FormID, 
    sub.AttendanceStatus
FROM student s
JOIN attends a ON s.UTDID = a.FK_UTDID
JOIN form f ON a.FK_CourseNum = f.FK_CourseNum
LEFT JOIN submission sub ON sub.FK_FormID = f.FormID AND sub.FK_UTDID = s.UTDID
WHERE a.FK_CourseNum = 123456 AND f.CloseDateTime < '2025-04-17'
ORDER BY s.SLName ASC, f.ReleaseDateTime ASC;
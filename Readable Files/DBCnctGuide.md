## Database Connection Guide
1. Download [MariaDB](https://mariadb.org/download/).
2. Open up the MariaDB Installer, and click Next on every page, except for Default Instance Properties.
	- Modify root password to be kachowmeow.
3. Once done, keep clicking Next until MariaDB has been installed. 
4. Install [HeidiSQL](https://www.heidisql.com/download.php).
	- Keep clicking Next until the application has been installed. Modify nothing. 
5. Launch HeidiSQL.
6. Open up a new session.
	- User should be root.
	- Password should be kachowmeow.
	- Port should be 3306.
7. Click Open to start the session.
8. On the top left corner, hover to File > click on Load SQL File.
9. Navigate through the File System to load up create_uttendance_DB.sql.
10. Select the blue triangle on the top of HeidiSQL banner to execute the SQL Script. 
11. Once the SQL Script is successfully running, open up Visual Studio 2022 (make sure this is the latest version).
	- Otherwise, [install](https://visualstudio.microsoft.com/downloads/) it.
12. In File Explorer, navigate to UttendanceDesktop.sln.
	- Open this file using Visual Studio 2022.
13. Once everything is loaded up from this file in Visual Studio, select Start Without Debugging option in the top banner.
14. The login testbox should open up.
	- Use sxh210003 to test the login. 
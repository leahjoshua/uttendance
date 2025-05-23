# UTtenDance
A UTD Attendance Application.

### Team Members
- Leah Joshua
- Parisa Nawar
- Aendri Singh
- Joanna Yang
- Judy Yang

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
11. On the top menu, go to Tools > Preferences > Grid Formatting > uncheck local number format for commas to be removed from numbers. 

## Desktop Application Guide
The UI display differs per screen resolution display. Some buttons may seem out of place, cropped, or hard to access.
If the Sign-In button cannot be found, enter the NetID and password, press ‘Enter’ button, and it should log the user in on the Desktop Side.  

1. Once the SQL Script is successfully running, open up Visual Studio 2022 (make sure this is the latest version).
	- Otherwise, [install](https://visualstudio.microsoft.com/downloads/) it.
2. In File Explorer, navigate to UttendanceDesktop.sln.
	- Open this file using Visual Studio 2022.
3. Once everything is loaded up from this file in Visual Studio, select Start Without Debugging option in the top banner.
4. The desktop application should open up.
    - You can either create a new account, or use username 'sxh392287' and password 'blowupmind' for quick demo.

## Website Guide
Upon logging into the website, it takes a while to validate for the information to show up for unknown reasons.

1. In File Explorer, navigate to student_website.sln.
	- Open this file using Visual Studio 2022.
2. Once everything is loaded up from this file in Visual Studio, select https option in the top banner.
3. In your default browser, the website should open up.
    - Use UTDID '2021345555' and password 'corn' (has questions) or 'cake' (no questions) for quick demo. 

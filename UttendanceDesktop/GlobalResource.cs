/******************************************************************************
* GlobalResource Class for the UttendanceDesktop application.
* This static class provides global variables and resources for the Uttendance
* application. It stores the database connection string, the currently selected
* class ID, and the NetID of the logged-in user. These values are accessible
* throughout the application for database operations and user context.
* Written by Joanna Yang (jxy210012) and Parisa Nawar (pxn210032) 
* for CS4485.0W1 at The University of Texas at Dallas
* starting March 28, 2025.
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop
{
    class GlobalResource
    {
        // The connection string used for all database operations.
        public static string CONNECTION_STRING = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
        // The current class ID that is being used for Coursepage
        public static int CURRENT_CLASS_ID { get; set; }
        public static Coursepage COURSEPAGE { get; set; }

        // The NetID of the currently logged-in user.
        public static string? INetID { get; set; }
    }
}

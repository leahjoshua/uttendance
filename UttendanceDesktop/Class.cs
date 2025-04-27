/******************************************************************************
* Class Database Operations for the UttendanceDesktop application.
* This class handles database interactions for course management in the Uttendance system.
* It provides methods to add new courses to the database and link them to instructors.
* Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
* starting March 7, 2025.
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UttendanceDesktop
{
    internal class Class
    {
        // Database connection 
        string connectionString = GlobalResource.CONNECTION_STRING;

        /**************************************************************************
         * Adds a new course to the database and links it to the current instructor.
         * 
         * Inputs:
         *   name    - Course name (e.g., "Computer Science Project")
         *   prefix  - Class subject prefix (e.g., "CS")
         *   number  - Class number (e.g., 4485)
         *   section - Section number (e.g., 003)
         *   classId - Unique class ID (e.g., 21868)
         * 
         * Returns:
         *   Success message or error description
         **************************************************************************/
        public string AddClass(string name, string prefix, int number, int section, int classId, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to:
                    // 1. Insert into class table
                    // 2. Get auto-generated ID
                    // 3. Insert into teaches table to link instructor and course
                    string query = @"
                INSERT INTO class 
                    (CourseNum, SectionNum, ClassSubject, ClassNum, ClassName, ClassStartTime, ClassEndTime) 
                    VALUES (@classId, @section, @prefix, @number, @name, @start, @end);
                
                SELECT LAST_INSERT_ID();

                INSERT INTO teaches 
                    (FK_INetID, FK_CourseNum) 
                    VALUES (@netid, @classId);";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameters  
                        cmd.Parameters.AddWithValue("@name", name);        // Course name
                        cmd.Parameters.AddWithValue("@prefix", prefix);    // Subject prefix (e.g., CS)
                        cmd.Parameters.AddWithValue("@number", number);    // Class number (e.g., 4485)
                        cmd.Parameters.AddWithValue("@section", section);  // Section number (e.g., 003)
                        cmd.Parameters.AddWithValue("@classId", classId);  // Unique class ID
                        cmd.Parameters.AddWithValue("@netid", GlobalResource.INetID); // Current instructor's NetID
                        cmd.Parameters.AddWithValue("@start", startTime);  // Class start time
                        cmd.Parameters.AddWithValue("@end", endTime);      // Class end time

                        // Execute the query 
                        object result = cmd.ExecuteScalar();
                        return $"Course added successfully!";
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle database-specific errors 
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                // Handle all other unexpected errors
                return $"Unexpected error: {ex.Message}";
            }
        }
    }
}

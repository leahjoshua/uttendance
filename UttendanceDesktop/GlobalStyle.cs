﻿/******************************************************************************
* GlobalStyles Class for the UttendanceDesktop application.
* This static class provides global variables and styles for the Uttendance
* application. It stores the colors, some label positions, and font styles.
* These values are accessible throughout the application for database operations 
* and user context.
* Written by Joanna Yang (jxy210012)
* for CS4485.0W1 at The University of Texas at Dallas starting March 7, 2025.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop
{
    //Joanna
    class GlobalStyle
    {
        //Web frame size
        public static int WEB_WIDTH = 1012;
        public static int WEB_HEIGHT = 602;

        //Colors
        public static Color DARKEST_PURPLE = Color.FromArgb(37, 42, 69);
        public static Color LAVENDER = Color.FromArgb(166, 176, 230);
        public static Color OFF_WHITE = Color.FromArgb(222, 225, 241);
        public static Color BURNT_ORANGE = Color.FromArgb(233, 117, 2);

        public static Color PASTEL_BLUE = Color.FromArgb(88, 101, 168);
        public static Color MAROON = Color.FromArgb(146, 67, 133);

        public static Color GREEN = Color.FromArgb(24, 162, 104);

        //Location
        public static Point HEADING_POSITION = new Point(43, 37);
        public static Point ADD_PANEL_POSITION = new Point(687, 314);

        //Fonts
        public static Font NORMALT_TXT = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
    }
}

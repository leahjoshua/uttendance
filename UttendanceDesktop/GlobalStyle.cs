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
        public static Color OFF_WHITE = Color.FromArgb(224, 224, 224);

        public static Color PASTEL_BLUE = Color.FromArgb(88, 101, 168);
        public static Color MAROON = Color.FromArgb(146, 67, 133);

        //Location of headers
        public static Point HEADING_POSITION = new Point(43, 37);

        //Fonts
        public static Font NORMALT_TXT = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
    }
}

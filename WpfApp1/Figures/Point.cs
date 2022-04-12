using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Figures
{
    public class Point
    {
        internal protected int x { get; set; }
        internal protected int y { get; set; }

        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
    }
}

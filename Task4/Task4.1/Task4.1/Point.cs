using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    public class Point
    {
        private int x, y;

        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }
        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point p = (Point)obj;
            return (x == p.x) && (y == p.y);
        }

        public override string ToString()
        {
            return $"Point coordinates : {x},{y}";
        }
    }
}


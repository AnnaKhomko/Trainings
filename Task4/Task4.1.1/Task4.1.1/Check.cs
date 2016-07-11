using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5
{
    public class Check
    {
        public int CheckHorizontally(Rectangle bigRectangle, Rectangle smallRectangle)
        {

            int verticalCount = bigRectangle.Length / smallRectangle.Width;
            int horizontalCount = bigRectangle.Width / smallRectangle.Length;
            int totalHorizontal = horizontalCount * verticalCount;

            int horizontalRest = bigRectangle.Width - smallRectangle.Length * horizontalCount;
            int verticalRest = bigRectangle.Length - smallRectangle.Width * verticalCount;

            int missVerticalRectangleVert = verticalRest / smallRectangle.Length;
            int missHorisontalRectangleVert = bigRectangle.Width / smallRectangle.Width;
            int missTotalVertical = missVerticalRectangleVert * missHorisontalRectangleVert;
            if (missTotalVertical > 0)
                missTotalVertical = missVerticalRectangleVert * missHorisontalRectangleVert;
            else missTotalVertical = 0;

            int missVerticalRectangleHor = bigRectangle.Length / smallRectangle.Length;
            int missHorisontalRectangleHor = horizontalRest / smallRectangle.Width;
            int missTotalHorizontal = missVerticalRectangleHor * missHorisontalRectangleHor;
            if (missTotalHorizontal > 0)
                missTotalHorizontal = missVerticalRectangleHor * missHorisontalRectangleHor;
            else missTotalHorizontal = 0;

            int totalCount = totalHorizontal + missTotalVertical + missTotalHorizontal;

            return totalCount;
        }

        public int CheckVertically(Rectangle bigRectangle, Rectangle smallRectangle)
        {

            int verticalCount = bigRectangle.Length / smallRectangle.Length;
            int horizontalCount = bigRectangle.Width / smallRectangle.Width;
            int totalVertical = horizontalCount * verticalCount;

            int horizontalRest = bigRectangle.Width - smallRectangle.Width * horizontalCount;
            int verticalRest = bigRectangle.Length - smallRectangle.Length * verticalCount;

            int missVerticalRectangleVert = verticalRest / smallRectangle.Width;
            int missHorisontalRectangleVert = bigRectangle.Width / smallRectangle.Length;
            int missTotalVertical = missVerticalRectangleVert * missHorisontalRectangleVert;
            if (missTotalVertical > 0)
                missTotalVertical = missVerticalRectangleVert * missHorisontalRectangleVert;
            else missTotalVertical = 0;

            int missVerticalRectangleHor = bigRectangle.Length / smallRectangle.Width;
            int missHorisontalRectangleHor = horizontalRest / smallRectangle.Length;
            int missTotalHorizontal = missVerticalRectangleHor * missHorisontalRectangleHor;
            if (missTotalHorizontal > 0)
                missTotalHorizontal = missVerticalRectangleHor * missHorisontalRectangleHor;
            else missTotalHorizontal = 0;

            int totalCount = totalVertical + missTotalVertical + missTotalHorizontal;

            return totalCount;
        }

        public int TotalAmount(Rectangle bigRectangle, Rectangle smallRectangle)
        {
            return Math.Max(CheckVertically(bigRectangle, smallRectangle), CheckHorizontally(bigRectangle, smallRectangle));
        }

    }
}

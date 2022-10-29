using Microsoft.Extensions.Logging;
using System;

namespace ConsoleCalculator.Classes
{
    internal static class ShapeDrawer
    {
       public static void DrawRectangle(int width, int height, bool isFilled)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width must be greater than 0");
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height must be greater than 0");
            }

            for (int y = 0; y < height; y++)
            {
                string line = "";
                for (int x = 0; x < width; x++)
                {
                    if (y == 0 || y == height - 1 || x == 0 || x == width - 1 || isFilled)
                    {
                        line += "#";
                    }
                    else
                    {
                        line += " ";
                    }
                }
                Console.WriteLine(line);
            }
        }

        public static void DrawDiamond(int height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Height must be greater than 0");
            }

            bool isHeightOdd = height % 2 == 0;
            int center = ((int)Math.Ceiling(height / 2.0)) - 1;

            for (int lineNumber = 0; lineNumber < height; lineNumber++)
            {
                string line = "";

                for (int charNumber = 0; charNumber < height; charNumber++)
                {
                    //if (isHeightOdd)
                    //{
                    //    if (charNumber == center - lineNumber
                    //        || charNumber == center - lineNumber - 1)
                    //    {
                    //        line += "#";
                    //    }
                    //    else
                    //    {
                    //        line += " ";
                    //    }
                    //}
                    //else
                    //{
                    if (charNumber == Math.Abs(lineNumber - center)
                        || charNumber == lineNumber + center
                        || charNumber == height - 1 - (lineNumber - center))
                    {
                        line += "#";
                    }
                    else
                    {
                        line += " ";
                    }
                    //}
                }

                Console.WriteLine(line);
            }
        }
    }
}
